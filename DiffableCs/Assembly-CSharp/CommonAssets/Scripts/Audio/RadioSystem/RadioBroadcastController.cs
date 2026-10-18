namespace CommonAssets.Scripts.Audio.RadioSystem;

public class RadioBroadcastController : MonoBehaviourSingleton, IRadioBroadcastController, IDisposable
{
	internal class RadioStationGridData
	{
		public BroadcastItemsContainer BroadcastItemsContainer; //Field offset: 0x10
		public BroadcastRule BroadcastRule; //Field offset: 0x18

		public RadioStationGridData() { }

	}

	internal class RadioStationsGridData : SerializableEnumDictionary
	{

		public RadioStationsGridData() { }

	}

	[SerializeField]
	private RadioStationsGridData _radioStationsGridData; //Field offset: 0x20
	private readonly List _stations; //Field offset: 0x28
	private readonly List _syncData; //Field offset: 0x30
	private bool _isBroadcastStarted; //Field offset: 0x38
	private EGameType _gameType; //Field offset: 0x3C
	private bool _isOffline; //Field offset: 0x40
	private RadioBroadcastSettings _globalSettings; //Field offset: 0x48

	public RadioBroadcastController() { }

	public virtual void Awake() { }

	private void CreateStations() { }

	public override void Dispose() { }

	public virtual void OnDestroy() { }

	public override void StartBroadcast() { }

	public override void StopBroadcast() { }

	private void SyncStations(IPlayer player) { }

	public bool TryGetConcreteStationClipByIndex(ERadioStation station, EBroadcastItemType broadcastItemType, int index, out AudioClip clip) { }

}

