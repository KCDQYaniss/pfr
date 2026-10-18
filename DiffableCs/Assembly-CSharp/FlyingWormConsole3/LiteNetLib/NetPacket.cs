namespace FlyingWormConsole3.LiteNetLib;

internal sealed class NetPacket
{
	private static readonly int LastProperty; //Field offset: 0x0
	private static readonly int[] HeaderSizes; //Field offset: 0x8
	public byte[] RawData; //Field offset: 0x10
	public int Size; //Field offset: 0x18
	public object UserData; //Field offset: 0x20
	public NetPacket Next; //Field offset: 0x28

	public byte ChannelId
	{
		 get { } //Length: 39
		 set { } //Length: 38
	}

	public byte ConnectionNumber
	{
		 get { } //Length: 44
		 set { } //Length: 52
	}

	public ushort FragmentId
	{
		 get { } //Length: 89
		 set { } //Length: 51
	}

	public ushort FragmentPart
	{
		 get { } //Length: 89
		 set { } //Length: 51
	}

	public ushort FragmentsTotal
	{
		 get { } //Length: 89
		 set { } //Length: 51
	}

	public bool IsFragmented
	{
		 get { } //Length: 42
	}

	public PacketProperty Property
	{
		 get { } //Length: 41
		 set { } //Length: 49
	}

	public ushort Sequence
	{
		 get { } //Length: 89
		 set { } //Length: 51
	}

	private static NetPacket() { }

	public NetPacket(PacketProperty property, int size) { }

	public NetPacket(int size) { }

	public byte get_ChannelId() { }

	public byte get_ConnectionNumber() { }

	public ushort get_FragmentId() { }

	public ushort get_FragmentPart() { }

	public ushort get_FragmentsTotal() { }

	public bool get_IsFragmented() { }

	public PacketProperty get_Property() { }

	public ushort get_Sequence() { }

	public static int GetHeaderSize(PacketProperty property) { }

	public int GetHeaderSize() { }

	public void MarkFragmented() { }

	public void set_ChannelId(byte value) { }

	public void set_ConnectionNumber(byte value) { }

	public void set_FragmentId(ushort value) { }

	public void set_FragmentPart(ushort value) { }

	public void set_FragmentsTotal(ushort value) { }

	public void set_Property(PacketProperty value) { }

	public void set_Sequence(ushort value) { }

	public bool Verify() { }

}

