namespace Dissonance;

public struct RoomChannel : IChannel, IDisposable, IEquatable
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly ushort _subscriptionId; //Field offset: 0x0
	private readonly string _roomId; //Field offset: 0x8
	private readonly ChannelProperties _properties; //Field offset: 0x10
	private readonly RoomChannels _channels; //Field offset: 0x18

	private override ChannelProperties Dissonance.IChannel<System.String>.Properties
	{
		private get { } //Length: 5
	}

	public bool IsOpen
	{
		 get { } //Length: 213
	}

	public bool Positional
	{
		 get { } //Length: 97
		 set { } //Length: 109
	}

	public ChannelPriority Priority
	{
		 get { } //Length: 96
		 set { } //Length: 107
	}

	[NotNull]
	internal ChannelProperties Properties
	{
		internal get { } //Length: 5
	}

	public override ushort SubscriptionId
	{
		 get { } //Length: 4
	}

	[NotNull]
	public override string TargetId
	{
		 get { } //Length: 5
	}

	public float Volume
	{
		 get { } //Length: 98
		 set { } //Length: 145
	}

	private static RoomChannel() { }

	internal RoomChannel(ushort subscriptionId, string roomId, RoomChannels channels, ChannelProperties properties) { }

	private void CheckValidProperties() { }

	public override void Dispose() { }

	private override ChannelProperties Dissonance.IChannel<System.String>.get_Properties() { }

	public override bool Equals(RoomChannel other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsOpen() { }

	public bool get_Positional() { }

	public ChannelPriority get_Priority() { }

	internal ChannelProperties get_Properties() { }

	public override ushort get_SubscriptionId() { }

	public override string get_TargetId() { }

	public float get_Volume() { }

	public virtual int GetHashCode() { }

	public void set_Positional(bool value) { }

	public void set_Priority(ChannelPriority value) { }

	public void set_Volume(float value) { }

}

