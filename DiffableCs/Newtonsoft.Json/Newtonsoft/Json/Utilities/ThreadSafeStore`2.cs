namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class ThreadSafeStore`2
{
	private readonly ConcurrentDictionary _concurrentStore; //Field offset: 0x0
	private readonly Func _creator; //Field offset: 0x0

	public ThreadSafeStore`2(Func creator) { }

	public TValue Get(TKey key) { }

}

