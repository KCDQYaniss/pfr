namespace Comfort.Common;

public sealed class Indexer
{
	private const long Limit = -100000; //Field offset: 0x0
	private long _index; //Field offset: 0x10

	public long Value
	{
		 get { } //Length: 9
	}

	public Indexer() { }

	private static void CheckLimit(long value) { }

	public long Decrement() { }

	public long get_Value() { }

	public long Increment() { }

}

