//Type is in global namespace

public class BotDeadBodyWork : BotData
{
	private enum ELookState
	{
		Initial = 0,
		Loot = 1,
		DropBodyVest = 2,
		DropBodyBackpack = 3,
		Exit = 4,
	}

	private const float MOVEITEM_TRANSACTION_DELAY = 1; //Field offset: 0x0
	public const float LOOK_TO_CLOSE_SAFE_SDIST = 0.0225; //Field offset: 0x0
	private List _bodies; //Field offset: 0x18
	private float _nextCheckClose; //Field offset: 0x20
	private float _nextPosibleGo; //Field offset: 0x24
	private float _nextCheckBody; //Field offset: 0x28
	private float _nextShallStopCheck; //Field offset: 0x2C
	private float _lastBodyDistCheck; //Field offset: 0x30
	private float _leaveBodyTime; //Field offset: 0x34
	private bool _lookInProgress; //Field offset: 0x38
	private bool _lastDesicion; //Field offset: 0x39
	private DeadBody _activeBody; //Field offset: 0x40
	private bool _isStay; //Field offset: 0x48
	private ELookState _curLookState; //Field offset: 0x4C
	private float _unpauseTime; //Field offset: 0x50
	private List _itemsCache; //Field offset: 0x58
	private List _containersCache; //Field offset: 0x60
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Weight", "Item"})]
	private List _weightedItems; //Field offset: 0x68
	private int _takeItemsLeft; //Field offset: 0x70
	private int _curItemIndex; //Field offset: 0x74
	private Task _moveItemTask; //Field offset: 0x78
	private CancellationTokenSource _lootTokenSource; //Field offset: 0x80
	private Task _lootTask; //Field offset: 0x88
	private Vector3 _cachedOffset; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnStartLookToBody; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <ShallUse>k__BackingField; //Field offset: 0xA8

	public event Action OnStartLookToBody
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private float LOOK_PERIOD
	{
		private get { } //Length: 58
	}

	private bool ShallLeave
	{
		private get { } //Length: 17
	}

	public private bool ShallUse
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public BotDeadBodyWork(BotOwner owner) { }

	[CompilerGenerated]
	private void <FirstTimeUsed>b__51_0() { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnStartLookToBody(Action value) { }

	public void CancelLootingProcessIfNeeded() { }

	private void CheckBodies() { }

	private void FirstTimeUsed() { }

	private float get_LOOK_PERIOD() { }

	private bool get_ShallLeave() { }

	[CompilerGenerated]
	public bool get_ShallUse() { }

	public bool HaveBody(out Vector3 pos) { }

	protected bool IsClose(out float dist) { }

	private void LeaveBody() { }

	private void LookToBody() { }

	public static void LookToLoot(BotOwner bot, Vector3 posLoot) { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	public void remove_OnStartLookToBody(Action value) { }

	[CompilerGenerated]
	private void set_ShallUse(bool value) { }

	private void SetPauseFor(float pTime) { }

	private void ShallStopUse() { }

	private void StartLook(DeadBody body) { }

	private void TryGoTo() { }

	public void UpdateCheck() { }

	private void UpdateLook() { }

	private void UseSurgialKit() { }

}

