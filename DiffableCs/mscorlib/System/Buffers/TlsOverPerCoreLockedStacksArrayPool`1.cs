namespace System.Buffers;

internal sealed class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool
{
	private sealed class LockedStack
	{
		private readonly T[][] _arrays; //Field offset: 0x0
		private int _count; //Field offset: 0x0
		private uint _firstStackItemMS; //Field offset: 0x0

		public LockedStack() { }

		public void Trim(uint tickCount, int id, MemoryPressure pressure, int bucketSize) { }

		public T[] TryPop() { }

		public bool TryPush(T[] array) { }

	}

	private enum MemoryPressure
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	private sealed class PerCoreLockedStacks
	{
		private readonly LockedStack[] _perCoreStacks; //Field offset: 0x0

		public PerCoreLockedStacks() { }

		public bool Trim(uint tickCount, int id, MemoryPressure pressure, int[] bucketSizes) { }

		public T[] TryPop() { }

		public void TryPush(T[] array) { }

	}

	[ThreadStatic]
	private static T[][] t_tlsBuckets; //Field offset: 0xFFFFFFFF
	private static readonly bool s_trimBuffers; //Field offset: 0x0
	private static readonly ConditionalWeakTable s_allTlsBuckets; //Field offset: 0x0
	private readonly int[] _bucketArraySizes; //Field offset: 0x0
	private readonly PerCoreLockedStacks[] _buckets; //Field offset: 0x0
	private int _callbackCreated; //Field offset: 0x0

	private int Id
	{
		private get { } //Length: 38
	}

	private static TlsOverPerCoreLockedStacksArrayPool`1() { }

	public TlsOverPerCoreLockedStacksArrayPool`1() { }

	private PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex) { }

	private static bool Gen2GcCallbackFunc(object target) { }

	private int get_Id() { }

	private static MemoryPressure GetMemoryPressure() { }

	private static bool GetTrimBuffers() { }

	public virtual T[] Rent(int minimumLength) { }

	public virtual void Return(T[] array, bool clearArray = false) { }

	public bool Trim() { }

}

