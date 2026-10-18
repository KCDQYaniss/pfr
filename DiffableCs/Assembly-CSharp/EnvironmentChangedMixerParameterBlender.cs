//Type is in global namespace

public class EnvironmentChangedMixerParameterBlender : MonoBehaviour
{
	private struct EnvironmentData
	{
		public float IndoorValue; //Field offset: 0x0
		public float OutdoorValue; //Field offset: 0x4
		public float IsolatedValue; //Field offset: 0x8

	}

	[SerializeField]
	private string _exposedParameterName; //Field offset: 0x20
	[SerializeField]
	private EnvironmentData _environmentData; //Field offset: 0x28
	[SerializeField]
	private float _blendDuration; //Field offset: 0x34
	private Action _unsubOnDestroy; //Field offset: 0x38
	private EAudioRoomTypeMask _currentRoomType; //Field offset: 0x40

	public EnvironmentChangedMixerParameterBlender() { }

	private void AmbientSystemInitEventHandler(AmbientAudioSystemInitializedEvent initEvent) { }

	private void Awake() { }

	private void MyPlayerRoomChangedEvent(MyPlayerRoomChangedEvent myPlayerRoomChangedEvent) { }

	private void OnDestroy() { }

	private void UpdateParameters(EAudioRoomTypeMask newRoomType) { }

}

