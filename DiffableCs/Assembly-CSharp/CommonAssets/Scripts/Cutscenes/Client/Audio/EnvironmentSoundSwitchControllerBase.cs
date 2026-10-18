namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public abstract class EnvironmentSoundSwitchControllerBase : HandlerStateBase
{
	[SerializeField]
	protected SpatialAudioRoom _fakeOutdoorRoom; //Field offset: 0x20
	[SerializeField]
	protected SpatialAudioRoom _fakeIndoorRoom; //Field offset: 0x28
	[SerializeField]
	protected float _transitionTime; //Field offset: 0x30
	private SoundSwitcher _soundSwitcher; //Field offset: 0x38
	private EEnvironmentAction _lastAction; //Field offset: 0x40
	private bool _lastEnabledHeadphones; //Field offset: 0x44
	private bool _hasSavedState; //Field offset: 0x45
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x48

	public virtual event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected EnvironmentSoundSwitchControllerBase() { }

	[CompilerGenerated]
	public virtual void add_StateChanged(Action value) { }

	public virtual void ApplyState(bool state) { }

	protected override void Awake() { }

	[CompilerGenerated]
	public virtual void remove_StateChanged(Action value) { }

	protected void ResetEnvironment() { }

	protected void SetEnvironment(EEnvironmentAction targetAction, bool enabledHeadphones) { }

}

