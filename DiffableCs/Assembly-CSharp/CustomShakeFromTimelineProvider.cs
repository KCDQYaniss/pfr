//Type is in global namespace

public class CustomShakeFromTimelineProvider : MonoBehaviour
{
	internal struct CustomShakeSettingsFromSignal
	{
		public string SignalID; //Field offset: 0x0
		public CustomExplosionShakeSettings Settings; //Field offset: 0x8

	}

	[SerializeField]
	private List _settingsFromSignal; //Field offset: 0x20
	private Action _unsubOnDestroy; //Field offset: 0x28
	private Dictionary _settingsDictionary; //Field offset: 0x30

	public CustomShakeFromTimelineProvider() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void TimelineSignalEmitEventHandler(TimelineSignalEmitEvent emitEvent) { }

}

