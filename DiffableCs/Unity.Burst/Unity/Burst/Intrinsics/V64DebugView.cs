namespace Unity.Burst.Intrinsics;

internal class V64DebugView
{
	private v64 m_Value; //Field offset: 0x10

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public byte[] Byte
	{
		 get { } //Length: 185
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public double[] Double
	{
		 get { } //Length: 97
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public float[] Float
	{
		 get { } //Length: 113
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public sbyte[] SByte
	{
		 get { } //Length: 185
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public int[] SInt
	{
		 get { } //Length: 105
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public long[] SLong
	{
		 get { } //Length: 95
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public short[] SShort
	{
		 get { } //Length: 137
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public uint[] UInt
	{
		 get { } //Length: 105
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public ulong[] ULong
	{
		 get { } //Length: 95
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public ushort[] UShort
	{
		 get { } //Length: 137
	}

	public V64DebugView(v64 value) { }

	public byte[] get_Byte() { }

	public double[] get_Double() { }

	public float[] get_Float() { }

	public sbyte[] get_SByte() { }

	public int[] get_SInt() { }

	public long[] get_SLong() { }

	public short[] get_SShort() { }

	public uint[] get_UInt() { }

	public ulong[] get_ULong() { }

	public ushort[] get_UShort() { }

}

