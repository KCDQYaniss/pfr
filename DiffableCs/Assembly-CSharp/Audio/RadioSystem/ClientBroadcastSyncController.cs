namespace Audio.RadioSystem;

public class ClientBroadcastSyncController : IBroadcastDataProvider, IDisposable
{
	private readonly IAudioCullingController _cullingController; //Field offset: 0x10
	private readonly Dictionary _currentClipByStation; //Field offset: 0x18
	private readonly Dictionary _endClipTimeByStation; //Field offset: 0x20
	private readonly Dictionary _playersByStation; //Field offset: 0x28
	private readonly ClientBroadcastPlayer[] _allClientBroadcastPlayers; //Field offset: 0x30
	private Action _unsubOnDestroy; //Field offset: 0x38

	public ClientBroadcastSyncController() { }

	private void AudibleStateChangedHandler(EAudibleState state) { }

	private void BroadcastItemChangedEventHandler(BroadcastItemChangedEvent changedEvent) { }

	public void ChangePlayerStation(IBroadcastPlayer player, ERadioStation newStation) { }

	public override void Dispose() { }

	private void RadioStationsSyncEventHandler(RadioStationsSyncEvent syncEvent) { }

	public void RegisterBroadcastPlayer(IBroadcastPlayer player) { }

	private void SyncPlayerBroadcast(IBroadcastPlayer player) { }

	public override bool TryGetClipAndBroadcastTime(ERadioStation station, out AudioClip clip, out double broadcastTime) { }

}

