namespace Dissonance.Networking;

public class TrafficCounter
{
	[CompilerGenerated]
	private uint <Packets>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private uint <Bytes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private uint <BytesPerSecond>k__BackingField; //Field offset: 0x18
	private uint _runningTotal; //Field offset: 0x1C
	private readonly Queue _updated; //Field offset: 0x20

	public private uint Bytes
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private uint BytesPerSecond
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private uint Packets
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TrafficCounter() { }

	public static void Combine(out uint packets, out uint bytes, out uint totalBytesPerSecond, TrafficCounter[] counters) { }

	[NotNull]
	public static string Format(ulong packets, ulong bytes, ulong bytesPerSecond) { }

	[NotNull]
	private static string FormatByteString(decimal bytes) { }

	[CompilerGenerated]
	public uint get_Bytes() { }

	[CompilerGenerated]
	public uint get_BytesPerSecond() { }

	[CompilerGenerated]
	public uint get_Packets() { }

	[CompilerGenerated]
	private void set_Bytes(uint value) { }

	[CompilerGenerated]
	private void set_BytesPerSecond(uint value) { }

	[CompilerGenerated]
	private void set_Packets(uint value) { }

	public virtual string ToString() { }

	public void Update(int bytes, Nullable now = null) { }

}

