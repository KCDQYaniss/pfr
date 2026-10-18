namespace EFT.ActiveHeadphones;

public abstract class BaseActiveHeadphonesMixerDependentComponent : IHeadphonesTemplateComponent
{
	private readonly Dictionary _prevValues; //Field offset: 0x10
	private readonly ActiveHeadphonesSettings _headphonesSettings; //Field offset: 0x18
	private readonly AudioMixer _masterMixer; //Field offset: 0x20
	private readonly IAudioMixerFader _fader; //Field offset: 0x28

	protected BaseActiveHeadphonesMixerDependentComponent(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

	public override void Configure(HeadphonesApplyContext context, bool doFade = true) { }

	protected abstract void ConfigureTemplate(HeadphonesTemplate template, bool doFade = true) { }

	private EAudioFadeType GetFadeTypeByValue(string paramName, float value) { }

	protected void SetMixerFloat(string paramName, float value, bool doFade = true) { }

	protected bool TryGetMixerFloat(string paramName, out float value) { }

}

