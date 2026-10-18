//Type is in global namespace

public sealed class SpectatorAudioController : ISpectatorAudio
{
	private const int INVALID_PLAYER_ID = -1; //Field offset: 0x0
	private const int INVALID_ROOM_ID = -1; //Field offset: 0x0
	private readonly Player _player; //Field offset: 0x10
	private readonly int _myPlayerRaidId; //Field offset: 0x18
	private int _targetPlayerId; //Field offset: 0x1C
	private int _targetRaidId; //Field offset: 0x20
	private int _overrideRoomId; //Field offset: 0x24
	private Nullable _savedHeadphonesContext; //Field offset: 0x28
	private bool _acousticReflectionMuted; //Field offset: 0x40
	private Action _unsubscribe; //Field offset: 0x48

	public SpectatorAudioController(Player player) { }

	private void ApplyAcousticReflectionMute() { }

	private void ApplyHeadphonesTemplate(HeadphonesApplyContext headphonesApplyContext) { }

	private void ApplyListenerOverride(SpatialAudioSystem spatialAudio, ISpatialAudioRoom room, string source) { }

	private void BeginForTarget(int targetPlayerId, int targetRaidId) { }

	private void ClearListenerOverride() { }

	public void Dispose() { }

	public void Initialize() { }

	private void OnChangeSpectating(ChangeSpectatingTeammateEventFromServer eventFromServer) { }

	private void OnOtherPlayerSpatialRoomChanged(OtherPlayerSpatialRoomChangedEvent roomChangedEvent) { }

	private void OnStartSpectating(StartSpectatingForTeammateEvent eventFromServer) { }

	private void OnTargetChanged(LocalSpectatorTargetChangedEvent targetEvent) { }

	private void ReapplyAcousticReflectionMuteIfNeeded() { }

	private void RefreshAcousticReflectionFromEnvironment() { }

	private EnvironmentType ResolveTargetEnvironment() { }

	public override void Restore() { }

	private void RestoreHeadphones() { }

	public override void SetMuted(bool muted) { }

}

