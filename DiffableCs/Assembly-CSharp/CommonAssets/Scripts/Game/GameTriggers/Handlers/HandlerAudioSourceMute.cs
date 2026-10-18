namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public class HandlerAudioSourceMute : BaseTriggerHandler
{
	[CompilerGenerated]
	private Action OnMuteStateChanged; //Field offset: 0x28
	[SerializeField]
	private bool _targetMuteState; //Field offset: 0x30
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x38

	public event Action OnMuteStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public HandlerAudioSourceMute() { }

	[CompilerGenerated]
	public void add_OnMuteStateChanged(Action value) { }

	public void ApplyState(bool state) { }

	private void Awake() { }

	private void OnTrigger(TriggerEvent triggerEvent) { }

	[CompilerGenerated]
	public void remove_OnMuteStateChanged(Action value) { }

	private void Start() { }

}

