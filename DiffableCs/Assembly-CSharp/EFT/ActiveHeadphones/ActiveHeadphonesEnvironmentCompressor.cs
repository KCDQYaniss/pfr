namespace EFT.ActiveHeadphones;

public class ActiveHeadphonesEnvironmentCompressor : BaseActiveHeadphonesMixerDependentComponent
{
	private const string COMPRESSOR_ATTACK = "CompressorAttack"; //Field offset: 0x0
	private const string COMPRESSOR_GAIN = "CompressorGain"; //Field offset: 0x0
	private const string COMPRESSOR_RELEASE = "CompressorRelease"; //Field offset: 0x0
	private const string COMPRESSOR_THRESHOLD = "CompressorThreshold"; //Field offset: 0x0
	private const string COMPRESSOR_DISTORTION = "CompressorDistortion"; //Field offset: 0x0

	public ActiveHeadphonesEnvironmentCompressor(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

	protected virtual void ConfigureTemplate(HeadphonesTemplate template, bool doFade = true) { }

}

