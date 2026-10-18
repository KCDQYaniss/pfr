namespace EFT.HandBook;

public sealed class HandbookScreen : EftScreen
{
	[CompilerGenerated]
	private struct <Show>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HandbookScreen <>4__this; //Field offset: 0x20
		public InventoryController inventoryController; //Field offset: 0x28
		public IEftSession session; //Field offset: 0x30
		public IHealthController healthController; //Field offset: 0x38
		public Handbook handbook; //Field offset: 0x40
		public string showAtCategory; //Field offset: 0x48
		public string showAtItem; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class HandbookScreenController : EftScreenController
	{
		public readonly InventoryController InventoryController; //Field offset: 0x58
		public readonly IEftSession Session; //Field offset: 0x60
		public readonly Handbook Handbook; //Field offset: 0x68
		public readonly IHealthController HealthController; //Field offset: 0x70
		[CompilerGenerated]
		private string <ShowAtCategory>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private string <ShowAtItem>k__BackingField; //Field offset: 0x80

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public string ShowAtCategory
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public string ShowAtItem
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public HandbookScreenController(InventoryController inventoryController, IEftSession session, Handbook handbook, IHealthController healthController) { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public string get_ShowAtCategory() { }

		[CompilerGenerated]
		public string get_ShowAtItem() { }

		[CompilerGenerated]
		public void set_ShowAtCategory(string value) { }

		[CompilerGenerated]
		public void set_ShowAtItem(string value) { }

	}

	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xA0
	[SerializeField]
	private HandbookCategoriesPanel _categoriesPanel; //Field offset: 0xA8
	private ItemUiContext _itemUiContext; //Field offset: 0xB0
	private NodeBaseView _selectedItemPanel; //Field offset: 0xB8

	public HandbookScreen() { }

	[CompilerGenerated]
	private void <Awake>b__5_0() { }

	[CompilerGenerated]
	private void <Show>b__7_0(NodeBaseView view, string id) { }

	private void Awake() { }

	public virtual void Close() { }

	public void SelectCategory(string categoryId) { }

	public void SelectItem(string itemId) { }

	public virtual void Show(HandbookScreenController controller) { }

	[AsyncStateMachine(typeof(<Show>d__7))]
	private Task Show(InventoryController inventoryController, IEftSession session, Handbook handbook, IHealthController healthController, string showAtCategory, string showAtItem) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

