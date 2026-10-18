namespace EFT.UI.DragAndDrop;

public sealed class RagfairNewOfferItemView : GridItemView
{
	[SerializeField]
	private GameObject _selectedMark; //Field offset: 0x2E0
	[SerializeField]
	private GameObject _selectedBackground; //Field offset: 0x2E8
	private bool _selected; //Field offset: 0x2F0
	private bool _canSelect; //Field offset: 0x2F1
	private readonly BindableState _canBeOffered; //Field offset: 0x2F8
	private readonly BindableState _lockedBecauseOfOfferCellsCount; //Field offset: 0x300
	private RagfairNewOfferContext _offerContext; //Field offset: 0x308

	private bool CanSelect
	{
		private get { } //Length: 8
	}

	private bool SuitsAsContainer
	{
		private get { } //Length: 117
	}

	protected virtual IBindable Transparency
	{
		 get { } //Length: 200
	}

	public RagfairNewOfferItemView() { }

	[CompilerGenerated]
	private float <get_Transparency>b__10_0(float baseTransparent, bool canBeOffered, bool maxCountReached) { }

	private void CheckIfOfferTakesMaxCells(bool isMaxCellsCount, Item templateItem) { }

	public static RagfairNewOfferItemView Create(Item item, NewOfferItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, bool canSelect) { }

	private bool get_CanSelect() { }

	private bool get_SuitsAsContainer() { }

	protected virtual IBindable get_Transparency() { }

	public virtual void Kill() { }

	private RagfairNewOfferItemView NewItemView(Item item, NewOfferItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, bool canSelect) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	protected virtual void OnItemAdded(AddItemEventArgs eventArgs) { }

	protected virtual void OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private void OnItemSelectedStatus(Item item, bool selected) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	private void SetEmptyState() { }

	private void SetSelectedStatus(bool selected) { }

}

