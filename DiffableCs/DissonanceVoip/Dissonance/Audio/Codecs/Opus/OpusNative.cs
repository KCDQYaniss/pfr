namespace Dissonance.Audio.Codecs.Opus;

internal class OpusNative
{
	private enum Application
	{
		Voip = 2048,
		Audio = 2049,
		RestrictedLowLatency = 2051,
	}

	internal enum Bandwidth
	{
		Narrowband = 1101,
		Mediumband = 1102,
		Wideband = 1103,
		SuperWideband = 1104,
		Fullband = 1105,
	}

	private enum Ctl
	{
		SetBitrateRequest = 4002,
		GetBitrateRequest = 4003,
		SetInbandFECRequest = 4012,
		GetInbandFECRequest = 4013,
		SetPacketLossPercRequest = 4014,
		GetPacketLossPercRequest = 4015,
		ResetState = 4028,
	}

	internal sealed class OpusDecoder : IDisposable
	{
		private static readonly Log Log; //Field offset: 0x0
		private readonly LockedValue _decoder; //Field offset: 0x10
		[CompilerGenerated]
		private bool <EnableForwardErrorCorrection>k__BackingField; //Field offset: 0x18
		private bool _disposed; //Field offset: 0x19

		public bool EnableForwardErrorCorrection
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		private static OpusDecoder() { }

		public OpusDecoder(int outputSampleRate, int outputChannelCount) { }

		public int DecodeFloats(EncodedBuffer srcEncodedBuffer, ArraySegment dstBuffer) { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		[CompilerGenerated]
		public bool get_EnableForwardErrorCorrection() { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_EnableForwardErrorCorrection(bool value) { }

	}

	internal sealed class OpusEncoder : IDisposable
	{
		private static readonly Log Log; //Field offset: 0x0
		private readonly LockedValue _encoder; //Field offset: 0x10
		private int _packetLoss; //Field offset: 0x18
		private bool _disposed; //Field offset: 0x1C

		public int Bitrate
		{
			 get { } //Length: 39
			 set { } //Length: 16
		}

		public bool EnableForwardErrorCorrection
		{
			 get { } //Length: 43
			 set { } //Length: 99
		}

		public float PacketLoss
		{
			 get { } //Length: 52
			 set { } //Length: 316
		}

		private static OpusEncoder() { }

		public OpusEncoder(int srcSamplingRate, int srcChannelCount) { }

		public override void Dispose() { }

		public int EncodeFloats(ArraySegment sourcePcm, ArraySegment dstEncoded) { }

		protected virtual void Finalize() { }

		public int get_Bitrate() { }

		public bool get_EnableForwardErrorCorrection() { }

		public float get_PacketLoss() { }

		private int OpusCtlIn(Ctl ctl, int value) { }

		private int OpusCtlOut(Ctl ctl, out int value) { }

		public void Reset() { }

		public void set_Bitrate(int value) { }

		public void set_EnableForwardErrorCorrection(bool value) { }

		public void set_PacketLoss(float value) { }

	}

	private enum OpusErrors
	{
		Ok = 0,
		BadArg = -1,
		BufferToSmall = -2,
		InternalError = -3,
		InvalidPacket = -4,
		Unimplemented = -5,
		InvalidState = -6,
		AllocFail = -7,
	}

	internal class OpusException : Exception
	{

		public OpusException(string message) { }

	}

	private static class OpusNativeMethods
	{

		internal static int dissonance_opus_decoder_ctl_in(IntPtr st, Ctl request, int value) { }

		internal static int dissonance_opus_decoder_ctl_out(IntPtr st, Ctl request, out int value) { }

		internal static int dissonance_opus_encoder_ctl_in(IntPtr st, Ctl request, int value) { }

		internal static int dissonance_opus_encoder_ctl_out(IntPtr st, Ctl request, out int value) { }

		internal static int opus_decode_float(IntPtr decoder, IntPtr byteData, int dataLength, IntPtr floatPcm, int frameSize, bool decodeFEC) { }

		internal static IntPtr opus_decoder_create(int samplingRate, int channels, out int error) { }

		internal static IntPtr opus_decoder_destroy(IntPtr decoder) { }

		internal static int opus_encode_float(IntPtr encoder, IntPtr floatPcm, int frameSize, IntPtr byteEncoded, int maxEncodedLength) { }

		internal static IntPtr opus_encoder_create(int samplingRate, int channels, int application, out int error) { }

		internal static void opus_encoder_destroy(IntPtr encoder) { }

		internal static IntPtr opus_get_version_string() { }

		internal static void opus_pcm_soft_clip(IntPtr pcm, int frameSize, int channels, float[] softClipMem) { }

	}

	internal sealed class OpusSoftClip
	{
		private readonly bool _disabled; //Field offset: 0x10
		private readonly float[] _memory; //Field offset: 0x18

		public OpusSoftClip(int channels = 1) { }

		public void Clip(ArraySegment samples) { }

		public void Reset() { }

	}

	private const string ImportString = "opus"; //Field offset: 0x0
	private const CallingConvention Convention = 2; //Field offset: 0x0

	public OpusNative() { }

	[NotNull]
	public static string OpusVersion() { }

}

