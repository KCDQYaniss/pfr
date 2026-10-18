namespace System;

internal struct MutableDecimal
{
	public uint Flags; //Field offset: 0x0
	public uint High; //Field offset: 0x4
	public uint Low; //Field offset: 0x8
	public uint Mid; //Field offset: 0xC

	public bool IsNegative
	{
		 get { } //Length: 10
	}

	public int Scale
	{
		 get { } //Length: 5
	}

	public bool get_IsNegative() { }

	public int get_Scale() { }

}

