namespace DSA.Utilities;

public static class DictionaryExtensions
{
    public static Dictionary<TKey, TValue> AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key, TValue updateValue, TValue addValue)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        if (source.ContainsKey(key))
            source[key] = updateValue;
        else
            source.Add(key, addValue);

        return source;
    }
}
