namespace EFT.ActiveHeadphones;

public class ActiveHeadphonesThreeBandEQ : BaseActiveHeadphonesMixerDependentComponent
{
	private const string HEADPHONES_BAND1_GAIN = "HeadphonesBand1Gain"; //Field offset: 0x0
	private const string HEADPHONES_BAND1_FREQ = "HeadphonesBand1Freq"; //Field offset: 0x0
	private const string HEADPHONES_BAND1_Q = "HeadphonesBand1Q"; //Field offset: 0x0
	private const string HEADPHONES_BAND2_GAIN = "HeadphonesBand2Gain"; //Field offset: 0x0
	private const string HEADPHONES_BAND2_FREQ = "HeadphonesBand2Freq"; //Field offset: 0x0
	private const string HEADPHONES_BAND2_Q = "HeadphonesBand2Q"; //Field offset: 0x0
	private const string HEADPHONES_BAND3_GAIN = "HeadphonesBand3Gain"; //Field offset: 0x0
	private const string HEADPHONES_BAND3_FREQ = "HeadphonesBand3Freq"; //Field offset: 0x0
	private const string HEADPHONES_BAND3_Q = "HeadphonesBand3Q"; //Field offset: 0x0
	private const string HEADPHONES_HIGH_PASS_FREQ = "HeadphonesHighpassFreq"; //Field offset: 0x0
	private const string HEADPHONES_HIGHPASS_RESONANCE = "HeadphonesHighpassResonance"; //Field offset: 0x0
	private const string HEADPHONES_LOWPASS_FREQ = "HeadphonesLowpassFreq"; //Field offset: 0x0
	private readonly EQBandExposedParameters _eqBand1Params; //Field offset: 0x30
	private readonly EQBandExposedParameters _eqBand2Params; //Field offset: 0x38
	private readonly EQBandExposedParameters _eqBand3Params; //Field offset: 0x40

	public ActiveHeadphonesThreeBandEQ(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

	private void ApplyBandParams(EQBand band, EQBandExposedParameters exposedParameters, bool doFade) { }

	private void ApplyHighpass(float freq, float resonance, bool doFade) { }

	private void ApplyLowpass(float freq, bool doFade) { }

	protected virtual void ConfigureTemplate(HeadphonesTemplate template, bool doFade = true) { }

}

