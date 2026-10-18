namespace EFT.UI;

public sealed class AssembleModPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_1; //Field offset: 0x8
		public static Func <>9__10_0; //Field offset: 0x10
		public static Func <>9__10_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal float <SetItemName>b__10_0(RepairableComponent x) { }

		internal float <SetItemName>b__10_1(RepairableComponent x) { }

		internal string <Show>b__8_1(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ItemController itemController; //Field offset: 0x10
		public AssembleModPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__0() { }

	}

	private const int SUBSTRING_COUNT = 50; //Field offset: 0x0
	private const int DURABILITY_THRESHOLD = 10; //Field offset: 0x0
	[SerializeField]
	private AssembleBuildItemView _itemView; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _itemName; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _itemCategory; //Field offset: 0x80
	private HandbookNode _node; //Field offset: 0x88
	private Item _item; //Field offset: 0x90
	private ItemController _itemController; //Field offset: 0x98

	public AssembleModPanel() { }

	public virtual void Close() { }

	private void ExamineEventHandler(ExamineItemEventArgs args) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetItemName() { }

	public void Show(HandbookNode node, Item item, ItemController itemController, ItemUiContext itemUiContext, InsuranceCompany insuranceCompany) { }

}

