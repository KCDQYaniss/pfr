namespace Dissonance;

public abstract class Channels`2
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public IChannelPriorityProvider priorityProvider; //Field offset: 0x0

		public <>c__DisplayClass12_0() { }

		internal ChannelProperties <.ctor>b__0() { }

	}

	protected readonly Log Log; //Field offset: 0x0
	private readonly Dictionary _openChannelsBySubId; //Field offset: 0x0
	private readonly Pool _propertiesPool; //Field offset: 0x0
	private ushort _nextId; //Field offset: 0x0
	[CompilerGenerated]
	private Action OpenedChannel; //Field offset: 0x0
	[CompilerGenerated]
	private Action ClosedChannel; //Field offset: 0x0

	public event Action ClosedChannel
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OpenedChannel
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int Count
	{
		 get { } //Length: 29
	}

	internal Channels`2(IChannelPriorityProvider priorityProvider) { }

	[CompilerGenerated]
	public void add_ClosedChannel(Action value) { }

	[CompilerGenerated]
	public void add_OpenedChannel(Action value) { }

	public bool Close(T channel) { }

	public bool Contains(T item) { }

	[NotNull]
	protected abstract T CreateChannel(ushort subscriptionId, TId channelId, ChannelProperties properties) { }

	public int get_Count() { }

	public Enumerator GetEnumerator() { }

	[NotNull]
	public T Open(TId id, bool positional = false, ChannelPriority priority = 0, float amplitudeMultiplier = 1) { }

	internal void Refresh() { }

	[CompilerGenerated]
	public void remove_ClosedChannel(Action value) { }

	[CompilerGenerated]
	public void remove_OpenedChannel(Action value) { }

}

