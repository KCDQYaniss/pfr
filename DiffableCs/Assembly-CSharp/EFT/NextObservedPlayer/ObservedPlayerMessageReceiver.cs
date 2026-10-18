namespace EFT.NextObservedPlayer;

public class ObservedPlayerMessageReceiver : IDisposable
{
	public float lastWorldTime; //Field offset: 0x10
	public int lastRemoteFrame; //Field offset: 0x14
	private readonly ObservedPlayerControllers _observedPlayerControllers; //Field offset: 0x18
	private readonly ByteSegmentRingBuffer _snapshotMessageBuffer; //Field offset: 0x20
	private readonly ByteSegmentRingBuffer _commandsMessageBuffer; //Field offset: 0x28
	private int _snapshotsProcessedCount; //Field offset: 0x30
	private int _commandsProcessedCount; //Field offset: 0x34
	private JobHandle _processHandle; //Field offset: 0x38
	public readonly ObservedPlayerModel[] Models; //Field offset: 0x48
	private bool _isDisposed; //Field offset: 0x50

	public ObservedPlayerMessageReceiver(ObservedPlayerControllers observedPlayerControllers) { }

	public override void Dispose() { }

	public void ManualLateUpdate() { }

	public void ManualUpdate() { }

	public void OnChangeFramerate(NetworkMessage networkMessage) { }

	public void OnCommandsObservedPlayers(NetworkMessage networkMessage) { }

	public void OnSnapshotObservedPlayers(NetworkMessage networkMessage) { }

	public void OnSpawnObservedPlayer(NetworkMessage networkMessage) { }

	public void OnSpawnObservedPlayers(NetworkMessage networkMessage) { }

	public void OnSpectatorCommandsObservedPlayers(NetworkMessage networkMessage) { }

	public void RemoveObservedController(ObservedPlayerController controller, float remoteTime) { }

	private void SpawnObservedPlayer(int id, ArraySegment segment) { }

	private void SpawnObservedPlayer(int id, ObservedPlayerSpawnMessage message) { }

}

