namespace Audio.AmbientSubsystem;

public class AmbientSoundPlayerGroupController : MonoBehaviour
{
	[SerializeField]
	private List _dayGroup; //Field offset: 0x20
	[SerializeField]
	private List _nightGroup; //Field offset: 0x28
	private readonly Dictionary _groupsByDayTime; //Field offset: 0x30
	private Action _unsubscribeOnDestroy; //Field offset: 0x38

	public AmbientSoundPlayerGroupController() { }

	private void ActivateGroups(EDayTime dayTime, EDayTimeBlendState blendState) { }

	private void Awake() { }

	private bool GetGroupNewActiveStatus(EDayTime targetDayTime, EDayTimeBlendState blendState) { }

	private void OnDayTimeBlendChange(DayTimeSoundBlendEvent blendEvent) { }

	private void OnDestroy() { }

}

