namespace Dissonance.Audio.Playback;

internal class EncodedAudioBuffer
{
	internal class VoicePacketComparer : IComparer
	{

		public VoicePacketComparer() { }

		public override int Compare(VoicePacket x, VoicePacket y) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private readonly MinHeap _heap; //Field offset: 0x10
	private readonly Action _droppedFrameHandler; //Field offset: 0x18
	private bool _complete; //Field offset: 0x20
	private int _count; //Field offset: 0x24
	[CompilerGenerated]
	private uint <SequenceNumber>k__BackingField; //Field offset: 0x28
	private readonly PacketLossCalculator _loss; //Field offset: 0x30

	public int Count
	{
		 get { } //Length: 4
	}

	public float PacketLoss
	{
		 get { } //Length: 235
	}

	public private uint SequenceNumber
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static EncodedAudioBuffer() { }

	public EncodedAudioBuffer(Action droppedFrameHandler) { }

	public int get_Count() { }

	public float get_PacketLoss() { }

	[CompilerGenerated]
	public uint get_SequenceNumber() { }

	private bool IsComplete() { }

	public void Push(VoicePacket frame) { }

	public bool Read(out Nullable frame, out bool lostPacket) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_SequenceNumber(uint value) { }

	public void Stop() { }

}

