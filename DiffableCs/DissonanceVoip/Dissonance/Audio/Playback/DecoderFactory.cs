namespace Dissonance.Audio.Playback;

internal class DecoderFactory
{
	private static readonly Log Log; //Field offset: 0x0

	private static DecoderFactory() { }

	public DecoderFactory() { }

	[NotNull]
	public static IVoiceDecoder Create(FrameFormat format) { }

}

