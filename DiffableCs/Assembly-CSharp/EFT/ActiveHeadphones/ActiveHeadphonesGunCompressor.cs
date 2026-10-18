namespace EFT.ActiveHeadphones;

public class ActiveHeadphonesGunCompressor : BaseActiveHeadphonesMixerDependentComponent
{
	private const string GUN_COMPRESSOR_ATTACK = "GunCompressorAttack"; //Field offset: 0x0
	private const string GUN_COMPRESSOR_GAIN = "GunCompressorGain"; //Field offset: 0x0
	private const string GUN_COMPRESSOR_RELEASE = "GunCompressorRelease"; //Field offset: 0x0
	private const string GUN_COMPRESSOR_THRESHOLD = "GunCompressorThreshold"; //Field offset: 0x0
	private const string GUN_COMPRESSOR_DISTORTION = "GunCompressorDistortion"; //Field offset: 0x0

	public ActiveHeadphonesGunCompressor(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

	protected virtual void ConfigureTemplate(HeadphonesTemplate template, bool doFade = true) { }

}

