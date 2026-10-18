namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class CutsceneEnvironmentSoundSwitchController : EnvironmentSoundSwitchControllerBase
{
	private struct EnvironmentConfig
	{
		public string signalID; //Field offset: 0x0
		public EEnvironmentAction targetAction; //Field offset: 0x8
		public bool enabledHeadphones; //Field offset: 0xC

	}

	[SerializeField]
	private EnvironmentConfig[] _ambientConfigs; //Field offset: 0x50
	private Action _unsubOnDestroy; //Field offset: 0x58

	public CutsceneEnvironmentSoundSwitchController() { }

	protected virtual void Awake() { }

	private void OnDestroy() { }

	private void ResetFilterPassedHandler(CutSceneEndEvent cutSceneEndEvent) { }

	private void TimelineSignalEmitEventHandler(TimelineSignalEmitEvent emitEvent) { }

}

