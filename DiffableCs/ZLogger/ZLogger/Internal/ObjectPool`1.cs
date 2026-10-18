namespace ZLogger.Internal;

[Nullable(0)]
[NullableContext(1)]
internal sealed class ObjectPool`1
{
	private int gate; //Field offset: 0x0
	[Nullable(2)]
	private T root; //Field offset: 0x0

	public ObjectPool`1() { }

	[NullableContext(2)]
	public bool TryPop(out T result) { }

	public bool TryPush(T item) { }

}

