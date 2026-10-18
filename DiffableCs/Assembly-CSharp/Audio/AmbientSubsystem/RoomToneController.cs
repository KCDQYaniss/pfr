namespace Audio.AmbientSubsystem;

public class RoomToneController : IDisposable
{
	private const int INVALID_CLIP_HASH = -1; //Field offset: 0x0
	private bool _isPlayerIndoorPrev; //Field offset: 0x10
	private ISpatialAudioRoom _prevEnteredRoom; //Field offset: 0x18
	private int _lastIndoorClipHash; //Field offset: 0x20
	private Action _unsubscribeOnDestroy; //Field offset: 0x28

	public RoomToneController() { }

	private void ChangeRoomTone(ISpatialAudioRoom newRoom) { }

	private void Clear() { }

	public override void Dispose() { }

	private void OnPlayerRoomChanged(MyPlayerRoomChangedEvent roomChangedEvent) { }

	private void TryStopPrevRoomToneSound() { }

}

