namespace NullableFailRepro
{
    internal static class Extensions
    {
        public static IEnumerable<(int, T)> AsIndexed<T>(this IEnumerable<T> source)
        {
            var e = source.GetEnumerator();
            for (int i = 0; e.MoveNext(); i++)
            {
                yield return (i, e.Current);
            }
        }
    }
}
