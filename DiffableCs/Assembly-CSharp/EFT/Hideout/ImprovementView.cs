namespace EFT.Hideout;

public class ImprovementView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__34_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CanImprove>b__34_0(Requirement v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public ImprovementView <>4__this; //Field offset: 0x10
		public AreaData area; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1(Requirement requirement, ItemRequirementPanel itemView) { }

	}

	private static readonly string _improvementProcessKey; //Field offset: 0x0
	protected const string REQUIREMENTS_NOT_FULFILLED = "hideout/Requirements are not fulfilled"; //Field offset: 0x0
	private const int INTERVAL_SECONDS = 1; //Field offset: 0x0
	private static readonly string _improvementCompletedKey; //Field offset: 0x8
	[SerializeField]
	[Space]
	private DefaultUIButton _startButton; //Field offset: 0x70
	[SerializeField]
	[Space]
	private GameObject _percentagePanel; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _percentageText; //Field offset: 0x80
	[SerializeField]
	private GameObject _expectedTimePanel; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _expectedTime; //Field offset: 0x90
	[SerializeField]
	[Space]
	private TextMeshProUGUI _status; //Field offset: 0x98
	[SerializeField]
	[Space]
	private ItemRequirementPanel _requiredItemTemplate; //Field offset: 0xA0
	[SerializeField]
	private Transform _requiredItemsContainer; //Field offset: 0xA8
	[CompilerGenerated]
	private InventoryController <InventoryController>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private ItemUiContext <ItemUiContext>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private AreaData <Area>k__BackingField; //Field offset: 0xC0
	private DateTime _lastTimerUpdate; //Field offset: 0xC8
	private ViewList _requirementsViewList; //Field offset: 0xD0
	private bool _isRequirementsFulfilled; //Field offset: 0xD8
	private bool _anyItemsReady; //Field offset: 0xD9
	private Improvement _improvement; //Field offset: 0xE0

	private AreaData Area
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private InventoryController InventoryController
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private ItemUiContext ItemUiContext
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static ImprovementView() { }

	public ImprovementView() { }

	private void ButtonUpdate() { }

	private bool CanImprove() { }

	private void CompleteState() { }

	private void ExpectedTimeUpdate() { }

	[CompilerGenerated]
	private AreaData get_Area() { }

	[CompilerGenerated]
	private InventoryController get_InventoryController() { }

	[CompilerGenerated]
	private ItemUiContext get_ItemUiContext() { }

	private void HandleButton() { }

	private void ManualUpdate() { }

	private void ProducingState() { }

	[CompilerGenerated]
	private void set_Area(AreaData value) { }

	[CompilerGenerated]
	private void set_InventoryController(InventoryController value) { }

	[CompilerGenerated]
	private void set_ItemUiContext(ItemUiContext value) { }

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, Improvement improvement, AreaData area) { }

	public void ShowGameObject() { }

	private void Update() { }

	private void UpdateImprovementInfo() { }

	public void UpdateView() { }

	private void WaitingState() { }

}

