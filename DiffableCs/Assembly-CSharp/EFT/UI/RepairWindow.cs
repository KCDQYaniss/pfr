namespace EFT.UI;

public sealed class RepairWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <UpdateInfoWindowParameters>b__25_0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public RepairWindow <>4__this; //Field offset: 0x10
		public IItemOwner itemOwner; //Field offset: 0x18
		public ItemContext itemContext; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public Mastering mastered; //Field offset: 0x10
		public <>c__DisplayClass22_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass22_1() { }

		internal float <Show>b__3() { }

	}

	[CompilerGenerated]
	private struct <RepairItem>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RepairWindow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TextMeshProUGUI _masteringLabel; //Field offset: 0xB8
	[SerializeField]
	private RepairerParametersPanel _repairerParameters; //Field offset: 0xC0
	[SerializeField]
	private RepairWarningStatusPanel _repairWarningStatusPanel; //Field offset: 0xC8
	[SerializeField]
	private ItemInfoWindowLabels _itemLabels; //Field offset: 0xD0
	[SerializeField]
	private CameraImage _cameraImage; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _repairButton; //Field offset: 0xE0
	[SerializeField]
	private GameObject _repairProcess; //Field offset: 0xE8
	[SerializeField]
	private GameObject _loader; //Field offset: 0xF0
	private WeaponPreview _weaponPreview; //Field offset: 0xF8
	private Item _item; //Field offset: 0x100
	private IRepairStrategy _repairStrategy; //Field offset: 0x108
	private ItemContext _itemContext; //Field offset: 0x110
	private ItemController _itemController; //Field offset: 0x118
	private HandbookNode _handbookNode; //Field offset: 0x120
	private WeaponPreviewPool _weaponPreviewPool; //Field offset: 0x128
	private MessageWindow _messageWindow; //Field offset: 0x130
	private bool _unableToRepair; //Field offset: 0x138
	private RepairController _repairController; //Field offset: 0x140
	private RepairKit _draggedRepairKit; //Field offset: 0x148

	private bool Examined
	{
		private get { } //Length: 55
	}

	public RepairWindow() { }

	[CompilerGenerated]
	private void <Awake>b__21_0() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private IRepairStrategy CreateRepairStrategy(Item item, RepairController repairController) { }

	private bool get_Examined() { }

	public void ItemRemovedHandler(RemoveItemEventArgs eventArgs) { }

	[AsyncStateMachine(typeof(<RepairItem>d__26))]
	private Task RepairItem() { }

	private void RepairStatusHandler(Nullable status) { }

	public WindowContext Show(RepairController repairController, ItemContext itemContext, Inventory inventory, MessageWindow messageWindow, ItemController itemController, SkillManager skills, WeaponPreviewPool weaponPreviewPool) { }

	private void UpdateInfoWindowParameters() { }

}

