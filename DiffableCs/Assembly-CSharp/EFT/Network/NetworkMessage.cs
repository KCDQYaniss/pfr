namespace EFT.Network;

public struct NetworkMessage
{
	[CompilerGenerated]
	private NetworkConnection <Connection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private NetworkChannel <Channel>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private short <MessageType>k__BackingField; //Field offset: 0xA
	[CompilerGenerated]
	private ArraySegment <buffer>k__BackingField; //Field offset: 0x10

	public ArraySegment buffer
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public NetworkChannel Channel
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NetworkConnection Connection
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public short MessageType
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[CompilerGenerated]
	[IsReadOnly]
	public ArraySegment get_buffer() { }

	[CompilerGenerated]
	[IsReadOnly]
	public NetworkChannel get_Channel() { }

	[CompilerGenerated]
	[IsReadOnly]
	public NetworkConnection get_Connection() { }

	[CompilerGenerated]
	[IsReadOnly]
	public short get_MessageType() { }

	public T ReadMessage() { }

	[CompilerGenerated]
	public void set_buffer(ArraySegment value) { }

	[CompilerGenerated]
	public void set_Channel(NetworkChannel value) { }

	[CompilerGenerated]
	public void set_Connection(NetworkConnection value) { }

	[CompilerGenerated]
	public void set_MessageType(short value) { }

}

