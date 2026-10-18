namespace EFT.UI;

public sealed class HandoverItemView : BaseSelectableItemView
{

	public HandoverItemView() { }

	public static HandoverItemView Create(Item item, SelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	private HandoverItemView NewHandoverItemView(Item item, SelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void SetAvailability(bool available, string tooltip) { }

}

