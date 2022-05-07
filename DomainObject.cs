namespace NullableFailRepro
{
#nullable disable warnings
    public sealed class ObjectWrapper<T>
    {
        public string? Id { get; }
        public T Value { get; }

        public void Deconstruct(out string? id, out T value)
        {
            id = Id;
            value = Value;
        }
    }

    public sealed class DomainObject
    {
        public int N { get; }
    }
}