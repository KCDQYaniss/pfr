namespace FlyingWormConsole3.LiteNetLib.Utils;

public class NtpPacket
{
	private static readonly DateTime Epoch; //Field offset: 0x0
	[CompilerGenerated]
	private byte[] <Bytes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable <DestinationTimestamp>k__BackingField; //Field offset: 0x18

	public private byte[] Bytes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TimeSpan CorrectionOffset
	{
		 get { } //Length: 370
	}

	public private Nullable DestinationTimestamp
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public NtpLeapIndicator LeapIndicator
	{
		 get { } //Length: 42
	}

	public private NtpMode Mode
	{
		 get { } //Length: 42
		private set { } //Length: 49
	}

	public Nullable OriginTimestamp
	{
		 get { } //Length: 43
	}

	public int Poll
	{
		 get { } //Length: 39
	}

	public int Precision
	{
		 get { } //Length: 39
	}

	public Nullable ReceiveTimestamp
	{
		 get { } //Length: 43
	}

	public uint ReferenceId
	{
		 get { } //Length: 13
	}

	public Nullable ReferenceTimestamp
	{
		 get { } //Length: 43
	}

	public TimeSpan RootDelay
	{
		 get { } //Length: 13
	}

	public TimeSpan RootDispersion
	{
		 get { } //Length: 13
	}

	public TimeSpan RoundTripTime
	{
		 get { } //Length: 361
	}

	public int Stratum
	{
		 get { } //Length: 39
	}

	public private Nullable TransmitTimestamp
	{
		 get { } //Length: 43
		private set { } //Length: 35
	}

	public private int VersionNumber
	{
		 get { } //Length: 45
		private set { } //Length: 52
	}

	private static NtpPacket() { }

	internal NtpPacket(byte[] bytes) { }

	public NtpPacket() { }

	private void CheckTimestamps() { }

	public static NtpPacket FromServerResponse(byte[] bytes, DateTime destinationTimestamp) { }

	[CompilerGenerated]
	public byte[] get_Bytes() { }

	public TimeSpan get_CorrectionOffset() { }

	[CompilerGenerated]
	public Nullable get_DestinationTimestamp() { }

	public NtpLeapIndicator get_LeapIndicator() { }

	public NtpMode get_Mode() { }

	public Nullable get_OriginTimestamp() { }

	public int get_Poll() { }

	public int get_Precision() { }

	public Nullable get_ReceiveTimestamp() { }

	public uint get_ReferenceId() { }

	public Nullable get_ReferenceTimestamp() { }

	public TimeSpan get_RootDelay() { }

	public TimeSpan get_RootDispersion() { }

	public TimeSpan get_RoundTripTime() { }

	public int get_Stratum() { }

	public Nullable get_TransmitTimestamp() { }

	public int get_VersionNumber() { }

	private Nullable GetDateTime64(int offset) { }

	private int GetInt32BE(int offset) { }

	private TimeSpan GetTimeSpan32(int offset) { }

	private uint GetUInt32BE(int offset) { }

	private ulong GetUInt64BE(int offset) { }

	[CompilerGenerated]
	private void set_Bytes(byte[] value) { }

	[CompilerGenerated]
	private void set_DestinationTimestamp(Nullable value) { }

	private void set_Mode(NtpMode value) { }

	private void set_TransmitTimestamp(Nullable value) { }

	private void set_VersionNumber(int value) { }

	private void SetDateTime64(int offset, Nullable value) { }

	private void SetUInt64BE(int offset, ulong value) { }

	private static ulong SwapEndianness(ulong x) { }

	private static uint SwapEndianness(uint x) { }

	internal void ValidateReply() { }

	internal void ValidateRequest() { }

}

