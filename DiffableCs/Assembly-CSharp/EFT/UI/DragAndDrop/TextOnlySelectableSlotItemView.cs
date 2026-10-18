namespace EFT.UI.DragAndDrop;

public sealed class TextOnlySelectableSlotItemView : SelectableSlotItemView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Item <UpdateInfo>b__11_0(Slot x) { }

	}


	public virtual ItemRotation ItemRotation
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	protected virtual string ValueFormat
	{
		 get { } //Length: 49
	}

	public TextOnlySelectableSlotItemView() { }

	public static TextOnlySelectableSlotItemView Create(Item item, ItemContext sourceContext, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance) { }

	public virtual ItemRotation get_ItemRotation() { }

	protected virtual string get_ValueFormat() { }

	private TextOnlySelectableSlotItemView NewTextOnlySelectableSlotItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance) { }

	protected virtual void OnBeingExaminedChanged(bool isBeingExamined) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	protected virtual void RefreshIcon() { }

	protected virtual void set_ItemRotation(ItemRotation value) { }

	public virtual void UpdateInfo() { }

	protected virtual void UpdateScale() { }

	protected virtual void UpdateStaticInfo() { }

}

