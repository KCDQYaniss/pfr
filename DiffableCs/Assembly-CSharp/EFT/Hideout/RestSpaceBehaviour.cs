namespace EFT.Hideout;

public class RestSpaceBehaviour : BaseItemSlotsAreaBehaviour, IEnergyDependentBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_HasGameDiscInserted>b__13_0(Item item) { }

	}

	private ItemSelectionCell _selectionCell; //Field offset: 0x78
	private bool _isEnergyOn; //Field offset: 0x80
	private EventDialogScreenController _dialogScreen; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnGameDiscInserted; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnGameDiscRemoved; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnEnergyStatusChanged; //Field offset: 0xA0
	[CompilerGenerated]
	private GameDisk <CurrentGameDisc>k__BackingField; //Field offset: 0xA8

	public event Action OnEnergyStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnGameDiscInserted
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnGameDiscRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool CanPlayGame
	{
		 get { } //Length: 39
	}

	public private GameDisk CurrentGameDisc
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HasGameDiscInserted
	{
		 get { } //Length: 354
	}

	public RestSpaceBehaviour() { }

	[CompilerGenerated]
	public void add_OnEnergyStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnGameDiscInserted(Action value) { }

	[CompilerGenerated]
	public void add_OnGameDiscRemoved(Action value) { }

	public bool CanAcceptGameDisc(Item item) { }

	public virtual bool CanAcceptItem(Item item) { }

	public override void EnergyGenerationChanged(bool isOn) { }

	private void FocusGameZoneCamera(bool focus) { }

	public bool get_CanPlayGame() { }

	[CompilerGenerated]
	public GameDisk get_CurrentGameDisc() { }

	public bool get_HasGameDiscInserted() { }

	private void HandleGameDiscInserted(Item gameDisc) { }

	private void HandleGameDiscRemoved() { }

	public virtual void Init(AreaData area, AreaInfo profileInfo, InventoryController inventoryController, IEftSession session) { }

	protected virtual void OnInitializeItemInserted(Item item, int slotIndex) { }

	private void OnItemInSlotChangedHandler(Item item, int index) { }

	public virtual void ReleaseSubscriptions() { }

	[CompilerGenerated]
	public void remove_OnEnergyStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnGameDiscInserted(Action value) { }

	[CompilerGenerated]
	public void remove_OnGameDiscRemoved(Action value) { }

	[CompilerGenerated]
	private void set_CurrentGameDisc(GameDisk value) { }

	public void SetSelectionCell(ItemSelectionCell cell) { }

	private void ShowGameScreen() { }

	public void StartGame() { }

}

