namespace NullableFailRepro
{
    public sealed class Problem
    {
        public static void M(IEnumerable<ObjectWrapper<DomainObject?>> domainObjects)
        {
            // QuickInfo on 'AsIndexed()' correctly says the return includes
            // {Non-nullable wrapper<Nullable object>}
            // But 'w' is mistakenly annotated as a
            // {Nullable wrapper<Non-nullable object>}
            foreach (var (idx, w) in domainObjects.AsIndexed())
            {
                var (id, obj) = w;

                // The correct expectation is the compiler
                // emitting a warning here, but it doesn't
                Console.WriteLine(obj.N);
            }
        }
    }
}
