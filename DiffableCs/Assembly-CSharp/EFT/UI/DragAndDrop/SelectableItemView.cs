namespace EFT.UI.DragAndDrop;

public class SelectableItemView : BaseSelectableItemView
{
	[SerializeField]
	private Image _selectedMarkBack; //Field offset: 0x2F8
	[SerializeField]
	private GameObject _unavailableBorder; //Field offset: 0x300
	private bool _available; //Field offset: 0x308
	private string _tooltipText; //Field offset: 0x310

	protected Image SelectedMarkBack
	{
		 get { } //Length: 8
	}

	public SelectableItemView() { }

	public static SelectableItemView Create(Item item, SelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected Image get_SelectedMarkBack() { }

	protected SelectableItemView NewSelectableItemView(Item item, SelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	protected virtual void SetAvailability(bool available, string tooltip) { }

	protected virtual void SetItemSelected(bool selected) { }

	protected virtual void UpdateScale() { }

}

