namespace Audio.AmbientSubsystem;

[RequireComponent(typeof(BaseAmbientSoundPlayer))]
public class SoundPlayerRoomObserverComponent : MonoBehaviour
{
	private const int INVALID_ROOM_ID = -1; //Field offset: 0x0
	[SerializeField]
	private List _observedRooms; //Field offset: 0x20
	private ISoundPlayer _observerPlayer; //Field offset: 0x28
	private readonly HashSet _observedRoomsID; //Field offset: 0x30
	private Action _unsubscribeOnDestroy; //Field offset: 0x38
	private int _lastPlayerRoomID; //Field offset: 0x40
	private bool _lastIsRoomValid; //Field offset: 0x44
	private bool _isFirstValidation; //Field offset: 0x45

	public SoundPlayerRoomObserverComponent() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnMyPlayerRoomChanged(MyPlayerRoomChangedEvent changedEvent) { }

	private void OnStartPlay(AmbientAudioSystemInitializedEvent ambientAudioSystemInitializedEvent) { }

	private void Subscribe() { }

	private void ValidatePlayer(int roomID) { }

	private void ValidateRoomsList() { }

}

