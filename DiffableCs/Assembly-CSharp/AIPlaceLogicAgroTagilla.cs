//Type is in global namespace

public class AIPlaceLogicAgroTagilla : AIPlaceInfoLogic
{
	private const string alarm_stop = "alarm_stop"; //Field offset: 0x0
	private const string alarm = "alarm"; //Field offset: 0x0
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x20
	public HashSet IdsOfVisitedPlayers; //Field offset: 0x28
	private float _nextCheckTime; //Field offset: 0x30
	public bool IsEnableTimeTest; //Field offset: 0x34
	public bool _isEventStopped; //Field offset: 0x35
	private AIPeriodAction _periodInfo; //Field offset: 0x38
	private bool _isAlarmLaunched; //Field offset: 0x40

	public AIPlaceLogicAgroTagilla() { }

	public virtual void Dispose() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnPlayerEnter(Player player) { }

	private void OnPlayerExit(Player player) { }

	private void SendInfo() { }

	private void StopEvent(string obj) { }

	private void Update() { }

}

