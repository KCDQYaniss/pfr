//Type is in global namespace

public class TimeQueue
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__10_0(TimeAction a, TimeAction b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public ITimeQueueItem queueItem; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <Remove>b__0(TimeAction x) { }

	}

	internal interface ITimeQueueItem
	{

		public void Release() { }

	}

	private struct TimeAction
	{
		public double time; //Field offset: 0x0
		public ITimeQueueItem item; //Field offset: 0x8

	}

	private static readonly IComparer _comparer; //Field offset: 0x0
	private readonly List _actions; //Field offset: 0x10

	private static TimeQueue() { }

	public TimeQueue() { }

	public void Add(double time, double keyTime, ITimeQueueItem queueItem) { }

	public void Clear() { }

	public bool Remove(ITimeQueueItem queueItem) { }

	public void Update() { }

	private void Update(double time) { }

}

