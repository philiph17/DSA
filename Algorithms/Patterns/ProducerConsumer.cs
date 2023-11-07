using System.Threading.Tasks.Dataflow;

namespace Algorithms.Patterns;

public class ProducerConsumer
{
    public async Task Run(IList<int> values, int batchSize, CancellationToken cancellationToken = default)
    {
        var queue = new BufferBlock<IList<int>>(new DataflowBlockOptions { BoundedCapacity = 2 });

        _ = Task.Run(() => ProduceAsync(queue, values, batchSize, cancellationToken), cancellationToken);

        await ConsumeAsync(queue);

        await queue.Completion;
    }

    public async Task ProduceAsync(ITargetBlock<IList<int>> queue, IList<int> values, int batchSize, CancellationToken cancellationToken)
    {
        try
        {
            var batch = new List<int>();
            foreach (var value in values)
            {
                batch.Add(value);

                if (batch.Count >= batchSize)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        throw new TaskCanceledException("Processing has been cancelled");
                    }

                    if (!await queue.SendAsync(batch))
                    {
                        return;
                    }
                    batch = new List<int>();
                }
            }

            if (batch.Any())
            {
                await queue.SendAsync(batch);
            }

            await queue.SendAsync(null);
        }
        catch (Exception e)
        {
            queue.Fault(e);
        }
    }

    public async Task ConsumeAsync(IReceivableSourceBlock<IList<int>> queue)
    {
        try
        {
            while (await queue.OutputAvailableAsync())
            {
                if (!queue.TryReceive(out var batch))
                {
                    break;
                }

                if (batch is null)
                {
                    queue.Complete();
                    break;
                }

                // do something with IList<int>
            }
        }
        catch (Exception e)
        {
            queue.Fault(e);
        }
    }
}