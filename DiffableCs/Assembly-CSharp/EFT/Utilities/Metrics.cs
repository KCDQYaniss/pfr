namespace EFT.Utilities;

public sealed class Metrics
{
	internal sealed class Timing
	{
		public uint Key; //Field offset: 0x10
		public ulong Value; //Field offset: 0x18

		public Timing() { }

	}

	public float TimeSpan; //Field offset: 0x10
	public Timing[] Timings; //Field offset: 0x18
	public Dictionary BinTimings; //Field offset: 0x20
	public ulong[] Memory; //Field offset: 0x28
	public int RaidNum; //Field offset: 0x30

	public Metrics() { }

}

