namespace Dissonance.Datastructures;

internal class POTBuffer
{
	private readonly List _buffers; //Field offset: 0x10
	[CompilerGenerated]
	private uint <MaxCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private uint <Count>k__BackingField; //Field offset: 0x1C

	public private uint Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private uint MaxCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public uint Pow2
	{
		 get { } //Length: 65
	}

	public POTBuffer(byte initialMaxPow) { }

	public void Alloc(uint count) { }

	public bool Expand(int limit = 2147483647) { }

	public void Free() { }

	[CompilerGenerated]
	public uint get_Count() { }

	[CompilerGenerated]
	public uint get_MaxCount() { }

	public uint get_Pow2() { }

	[NotNull]
	public float[] GetBuffer(ref uint count, bool zeroed = false) { }

	[CompilerGenerated]
	private void set_Count(uint value) { }

	[CompilerGenerated]
	private void set_MaxCount(uint value) { }

}

