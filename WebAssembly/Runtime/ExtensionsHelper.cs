using System.Collections.Generic;
    
/// Extensions implementing missing methods on NET Framework 4.5 
public static class ExtensionsHelper {

    /// <summary>
    /// Appends a value to the end of the sequence. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source">A sequence of values.</param>
    /// <param name="element">The value to append to source.</param>
    /// <returns>A new sequence that ends with element.</returns>
    public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element) 
    {
        foreach (var item in source) {
            yield return item;
        }
        yield return element;
    }

    /// <summary>
    /// Adds a value to the beginning of the sequence.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source">A sequence of values.</param>
    /// <param name="element">The value to prepend to source.</param>
    /// <returns>A new sequence that begins with element</returns>
    public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element) 
    {
        yield return element;
        foreach (var item in source) {
            yield return item;
        }
    }

    /// <summary>
    /// Returns an empty array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>An empty array</returns>
    public static T[] Empty<T>()
    {
        return EmptyArray<T>.Value;
    }

    internal static class EmptyArray<T>
    {
        public static readonly T[] Value = new T[0];
    }
}