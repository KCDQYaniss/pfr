namespace EFT.UI;

public sealed class ItemsListWindow : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ItemsListWindow <>4__this; //Field offset: 0x10
		public Handbook handbook; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20
		public ItemUiContext itemUiContext; //Field offset: 0x28
		public InsuranceCompany insuranceCompany; //Field offset: 0x30

		public <>c__DisplayClass9_0() { }

		internal AssembleModPanel <Show>b__0(Item arg) { }

		internal Transform <Show>b__1(Item arg) { }

		internal void <Show>b__2(Item item, AssembleModPanel panel) { }

	}

	private const string CAPTION_LABEL = "LOOT FROM SCAVS"; //Field offset: 0x0
	private const string MESSAGE_LABEL = "Scavs has brought you:"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _captionLabel; //Field offset: 0x70
	[SerializeField]
	private Button _closeButton; //Field offset: 0x78
	[SerializeField]
	private AssembleModPanel _assemblePanelTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _assemblePanelContainer; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _messageLabel; //Field offset: 0x90
	[SerializeField]
	private DefaultUIButton _receiveButtonSpawner; //Field offset: 0x98

	public ItemsListWindow() { }

	private void Awake() { }

	public void Show(IEnumerable newItems, Handbook handbook, InventoryController inventoryController, ItemUiContext itemUiContext, InsuranceCompany insuranceCompany) { }

}

