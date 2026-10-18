//Type is in global namespace

public class BotsForceAttackEvent : BaseBotsEvent
{
	private readonly HashSet _idsInteractableToActivate; //Field offset: 0x20
	private readonly HashSet _idsZoneToActivate; //Field offset: 0x28
	private HashSet _idsEventsToActivate; //Field offset: 0x30
	private ITimer _timer; //Field offset: 0x38
	private GameDateTime _gameTime; //Field offset: 0x40
	private WorldInteractiveObjectDelegate OnInteractObject; //Field offset: 0x48
	private Action OnPlayerComeToZone; //Field offset: 0x50
	private Action OnEvent; //Field offset: 0x58
	private BotZonesLeaveController _botZonesLeaveController; //Field offset: 0x60
	private bool _isActivated; //Field offset: 0x68

	public virtual List LayersToActivate
	{
		 get { } //Length: 297
	}

	public virtual List LayersToDeActivate
	{
		 get { } //Length: 95
	}

	public BotsForceAttackEvent(GameDateTime gameDateTime, BotsList botsList, BotZonesLeaveController botZonesLeaveController) { }

	[CompilerGenerated]
	private void <Activate>b__19_0(string id, Vector3 position) { }

	[CompilerGenerated]
	private void <Activate>b__19_1(string id) { }

	[CompilerGenerated]
	private void <Activate>b__19_2(string id) { }

	[CompilerGenerated]
	private void <Activate>b__19_3() { }

	public virtual void Activate() { }

	protected virtual void BotEventActive(BotOwner bot) { }

	protected virtual bool CanActivate(BotOwner bot) { }

	private void ConverToHashSet(HashSet ids, string from) { }

	public void DebugActivate() { }

	public void Dispose() { }

	public void ExternalStart() { }

	public virtual List get_LayersToActivate() { }

	public virtual List get_LayersToDeActivate() { }

	private void OnBotAdd(BotOwner bot) { }

	protected virtual bool Start(string cause) { }

	private bool TryActivateByEventId(string id) { }

	private bool TryActivateById(string doorId) { }

	private bool TryActivateByZoneId(string id) { }

}

