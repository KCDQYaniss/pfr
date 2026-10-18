namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class EventFilterEnvironmentSoundSwitchController : EnvironmentSoundSwitchControllerBase
{
	private struct EnvironmentConfig
	{
		public BaseEventFilter eventFilter; //Field offset: 0x0
		public EEnvironmentAction targetAction; //Field offset: 0x8
		public bool enabledHeadphones; //Field offset: 0xC

	}

	[SerializeField]
	private EnvironmentConfig[] _ambientConfigs; //Field offset: 0x50
	private readonly Dictionary _configsByEventFilterType; //Field offset: 0x58

	public EventFilterEnvironmentSoundSwitchController() { }

	protected virtual void Awake() { }

	private void EventFilterOnOnFilterPassed(BaseEventFilter eventFilter, BaseEvent eventToReact) { }

	private void OnDestroy() { }

	private void ValidateConfigs() { }

}

