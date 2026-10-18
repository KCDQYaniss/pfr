namespace EFT.ActiveHeadphones;

public class ActiveHeadphonesController : IDisposable
{
	private readonly IAudioMixerFader _mixerFader; //Field offset: 0x10
	private readonly IActiveHeadphones _headphones; //Field offset: 0x18
	private readonly HeadphonesApplyContext _defaultContext; //Field offset: 0x20
	private HeadphonesApplyContext _currentContext; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x40

	public HeadphonesApplyContext CurrentContext
	{
		 get { } //Length: 11
	}

	public HeadphonesTemplate CurrentTemplate
	{
		 get { } //Length: 5
	}

	public private bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ActiveHeadphonesController(HeadphonesApplyContext defaultContext, IActiveHeadphonesFactory headphonesFactory, AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

	public void ApplyTemplate(HeadphonesApplyContext context, bool doFade = true) { }

	private void Configure(HeadphonesApplyContext context, bool doFade = true) { }

	public override void Dispose() { }

	public void EnabledHeadphones(bool enabled, bool doFade = true) { }

	public HeadphonesApplyContext get_CurrentContext() { }

	public HeadphonesTemplate get_CurrentTemplate() { }

	[CompilerGenerated]
	public bool get_Enabled() { }

	public void ResetTemplate() { }

	[CompilerGenerated]
	private void set_Enabled(bool value) { }

}

