namespace Dissonance;

internal class CodecSettingsLoader
{
	private static readonly Log Log; //Field offset: 0x0
	private bool _started; //Field offset: 0x10
	private bool _settingsReady; //Field offset: 0x11
	private readonly object _settingsWriteLock; //Field offset: 0x18
	private CodecSettings _config; //Field offset: 0x20
	private AudioQuality _encoderQuality; //Field offset: 0x2C
	private FrameSize _encoderFrameSize; //Field offset: 0x30
	private Codec _codec; //Field offset: 0x34
	private bool _encodeFec; //Field offset: 0x35

	public CodecSettings Config
	{
		 get { } //Length: 55
	}

	private static CodecSettingsLoader() { }

	public CodecSettingsLoader() { }

	[NotNull]
	public IVoiceEncoder CreateEncoder() { }

	private void GenerateSettings() { }

	public CodecSettings get_Config() { }

	private static CodecSettings GetEncoderSettings(Codec codec, AudioQuality quality, FrameSize frameSize) { }

	public void Start(Codec codec = 1) { }

	public virtual string ToString() { }

}

