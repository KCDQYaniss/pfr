//Type is in global namespace

public class SitReservWay : AReserveWayAction
{
	public Transform lookToPoint; //Field offset: 0x30
	public bool ShallLoot; //Field offset: 0x38
	public string LootableContainerId; //Field offset: 0x40
	private bool _containerSearch; //Field offset: 0x48
	private bool _haveContainer; //Field offset: 0x49
	private bool _shallStartInteract; //Field offset: 0x4A
	private bool _errorCreated; //Field offset: 0x4B
	private float _startTimeInteract; //Field offset: 0x4C
	private LootableContainer _lootContainer; //Field offset: 0x50

	public virtual Vector3 GoTo
	{
		 get { } //Length: 204
	}

	public virtual Vector3 LookShootTo
	{
		 get { } //Length: 138
	}

	public SitReservWay() { }

	[CompilerGenerated]
	private bool <TryFind>b__23_0(LootableContainer x) { }

	public virtual void AutoFix() { }

	public virtual void ComeTo(BotOwner bot) { }

	public virtual void DrawGizmos() { }

	public virtual Vector3 get_GoTo() { }

	public virtual Vector3 get_LookShootTo() { }

	public virtual EReserveWayResult ManualUpdate(BotOwner bot) { }

	public virtual void RefreshBot() { }

	public virtual void RefreshData() { }

	public virtual void SetLeaveUser(BotOwner bot) { }

	public void SetLootId(string lootableContainerId) { }

	public virtual float TimeToUse(BotOwner owner) { }

	private void TryCloseContainer(BotOwner bot) { }

	private void TryFind() { }

}

