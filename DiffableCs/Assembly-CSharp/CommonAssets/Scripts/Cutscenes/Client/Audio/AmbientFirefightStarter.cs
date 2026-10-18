namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class AmbientFirefightStarter : HandlerStateBase
{
	[SerializeField]
	private BaseEventFilter _startFilter; //Field offset: 0x20
	[SerializeField]
	private AmbientFirefightDirector _firefightDirector; //Field offset: 0x28
	private Action _unsubOnDestroy; //Field offset: 0x30
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x38

	public virtual event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public AmbientFirefightStarter() { }

	[CompilerGenerated]
	public virtual void add_StateChanged(Action value) { }

	public virtual void ApplyState(bool state) { }

	private void Awake() { }

	private void CutsceneStartEventHandler(BaseEventFilter baseEventFilter, BaseEvent baseEvent) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public virtual void remove_StateChanged(Action value) { }

}

