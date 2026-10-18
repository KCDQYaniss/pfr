namespace EFT.UI.DragAndDrop;

public sealed class ModdingSelectableItemView : SelectableItemView
{
	[SerializeField]
	private GameObject _notAvailable; //Field offset: 0x318
	[SerializeField]
	private GameObject _availableFromMerchants; //Field offset: 0x320
	[SerializeField]
	private GameObject _infoIcons; //Field offset: 0x328
	private ModdingSelectableItemContext _moddingContext; //Field offset: 0x330
	[CompilerGenerated]
	private bool <CanSelect>k__BackingField; //Field offset: 0x338

	private bool CanSelect
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual ItemRotation ItemRotation
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public ModdingSelectableItemView() { }

	public static ModdingSelectableItemView Create(Item item, ModdingSelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, bool canSelect) { }

	[CompilerGenerated]
	private bool get_CanSelect() { }

	public virtual ItemRotation get_ItemRotation() { }

	private ModdingSelectableItemView NewModdingSelectableItemView(Item item, ModdingSelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, bool canSelect) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_CanSelect(bool value) { }

	protected virtual void set_ItemRotation(ItemRotation value) { }

}

