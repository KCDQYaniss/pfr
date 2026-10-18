namespace CommonAssets.Scripts.ArtilleryShelling.Client;

public class ArtilleryAlarmLogic : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ReceiveChangeAlertPlayerState>b__16_0(ArtilleryShellingZone x) { }

	}

	private const string ALARM_SIGNAL_PATH = "Audio/item_mobile_phone_vibration_oneshot"; //Field offset: 0x0
	private const int ALARM_SOUND_ROLLOFF = 15; //Field offset: 0x0
	private const float ALARM_SOUND_VOLUME = 0.3; //Field offset: 0x0
	private const string SHELLING_WARNING_MESSAGE_KEY = "ShellingWarningMessage"; //Field offset: 0x0
	private const string SHELLING_BUSY_MESSAGE_KEY = "ShellingBusy"; //Field offset: 0x0
	private const float SHELLING_NOTIFY_HOLD_TIME = 1; //Field offset: 0x0
	private AudioClip _alarmSound; //Field offset: 0x10
	private ArtilleryShellingControllerClient _shellingController; //Field offset: 0x18
	private Dictionary _currentPlayersAlarmStages; //Field offset: 0x20
	private float _elapsedAlarmTime; //Field offset: 0x28
	private float _elapseNotifyTime; //Field offset: 0x2C
	private Action _unsubscribeOnDestroy; //Field offset: 0x30
	private Queue _notifyMessageQueue; //Field offset: 0x38

	public ArtilleryAlarmLogic() { }

	private void AddOrUpdateAlarmDeviceStage(int playerRaidId, Vector2 alarmStage, IPlayer player, ArtilleryShellingZone zone, Vector3 nearestPoint) { }

	private void AlarmTimer() { }

	public override void Dispose() { }

	private bool GetZoneById(string zoneId, out ArtilleryShellingZone foundZone) { }

	public void Init(ArtilleryShellingControllerClient controller) { }

	private void InvokeAlarmSignal(IPlayer player) { }

	private void NotifyProcess() { }

	private void OnChangePlayerShellingAlertStateEvent(ChangePlayerShellingAlertStateEvent changeStateEvent) { }

	private void OnNotifyEvent(NotifyEvent notifyEvent) { }

	private void OnReceiveShellingNotify(ShellingNotifyEvent notifyEvent) { }

	public void OnUpdate() { }

	public void ReceiveChangeAlertPlayerState(int playerRaidId, string zoneId, Vector3 nearestPoint) { }

	public void ReceiveShellingNotificationToPlayers(string zoneId, int[] playersToNotify) { }

	private void ShowNotifyMessage(string zoneId) { }

	private void StopAlarmStage(int playerRaidId) { }

	private void Subscribe() { }

}

