//Type is in global namespace

public static class WsWireProtocol
{
	[IsReadOnly]
	internal struct Frame
	{
		[CompilerGenerated]
		private readonly WsWireMessageType <MessageType>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly byte[] <TrackingIdBytes>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly byte[] <PayloadTypeBytes>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly byte[] <PayloadBytes>k__BackingField; //Field offset: 0x18

		public WsWireMessageType MessageType
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public string Payload
		{
			 get { } //Length: 130
		}

		public byte[] PayloadBytes
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public string PayloadType
		{
			 get { } //Length: 130
		}

		public byte[] PayloadTypeBytes
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public string TrackingId
		{
			 get { } //Length: 130
		}

		public byte[] TrackingIdBytes
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Frame(WsWireMessageType messageType, byte[] trackingIdBytes, byte[] payloadTypeBytes, byte[] payloadBytes) { }

		[CompilerGenerated]
		public WsWireMessageType get_MessageType() { }

		public string get_Payload() { }

		[CompilerGenerated]
		public byte[] get_PayloadBytes() { }

		public string get_PayloadType() { }

		[CompilerGenerated]
		public byte[] get_PayloadTypeBytes() { }

		public string get_TrackingId() { }

		[CompilerGenerated]
		public byte[] get_TrackingIdBytes() { }

	}

	private const int HEADER_SIZE = 17; //Field offset: 0x0

	public static byte[] Encode(WsWireMessageType messageType, byte[] trackingIdBytes, byte[] payloadTypeBytes, byte[] payloadBytes) { }

	public static byte[] Encode(WsWireMessageType messageType, string trackingId, string payloadType, string payload) { }

	public static byte[] GetUtf8BytesOrEmpty(string value) { }

	private static byte[] ReadBytes(byte[] data, ref int offset, ulong length) { }

	private static uint ReadUInt32BE(byte[] buffer, int offset) { }

	private static ulong ReadUInt64BE(byte[] buffer, int offset) { }

	public static bool TryDecode(byte[] data, out Frame frame) { }

	private static void WriteUInt32BE(byte[] buffer, int offset, uint value) { }

	private static void WriteUInt64BE(byte[] buffer, int offset, ulong value) { }

}

