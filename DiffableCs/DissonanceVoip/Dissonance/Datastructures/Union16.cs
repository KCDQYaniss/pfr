namespace Dissonance.Datastructures;

internal struct Union16
{
	private ushort _ushort; //Field offset: 0x0
	private byte _byte1; //Field offset: 0x0
	private byte _byte2; //Field offset: 0x1

	public byte LSB
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public byte MSB
	{
		 get { } //Length: 7
		 set { } //Length: 4
	}

	public ushort UInt16
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public byte get_LSB() { }

	public byte get_MSB() { }

	public ushort get_UInt16() { }

	public void set_LSB(byte value) { }

	public void set_MSB(byte value) { }

	public void set_UInt16(ushort value) { }

}

