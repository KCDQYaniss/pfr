namespace EFT.UI.DragAndDrop;

public sealed class RagfairOfferItemView : StaticGridItemView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__18_0(ItemAttribute x) { }

	}

	private const float DURABILITY_THRESHOLD = 10; //Field offset: 0x0
	private const int MAXIMUM_X_VALUE = 330; //Field offset: 0x0
	private const int MAXIMUM_Y_VALUE = 125; //Field offset: 0x0
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x2E0
	[SerializeField]
	private DurabilitySlider _durabilitySlider; //Field offset: 0x2E8
	private ItemAttribute _durabilityItemAttribute; //Field offset: 0x2F0
	private bool _expanded; //Field offset: 0x2F8
	private Offer _offer; //Field offset: 0x300

	public virtual ItemRotation ItemRotation
	{
		 get { } //Length: 7
		 set { } //Length: 781
	}

	protected virtual bool PropagateClicks
	{
		 get { } //Length: 3
	}

	private bool ShowDurabilitySlider
	{
		private get { } //Length: 100
	}

	protected virtual IBindable Transparency
	{
		 get { } //Length: 119
	}

	public RagfairOfferItemView() { }

	public static GridItemView Create(Item item, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	public virtual ItemRotation get_ItemRotation() { }

	protected virtual bool get_PropagateClicks() { }

	private bool get_ShowDurabilitySlider() { }

	protected virtual IBindable get_Transparency() { }

	protected virtual string GetErrorText() { }

	protected virtual void OnBeingExaminedChanged(bool isBeingExamined) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	protected virtual void set_ItemRotation(ItemRotation value) { }

	protected virtual void SetItemValue(EItemValueFormat format, bool display, string color, object arg1, object arg2 = null, string color2 = null) { }

	public void Show(Offer offer, Item item, ItemRotation rotation, bool expanded, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	private void UpdateDurabilitySlider() { }

	public virtual void UpdateInfo() { }

	protected virtual void UpdateScale() { }

}

