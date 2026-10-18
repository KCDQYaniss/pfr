namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public sealed class FastAccessGrenadeGridItemView : GridItemView
{
	private int _grenadeCount; //Field offset: 0x2E0

	public FastAccessGrenadeGridItemView() { }

	public static FastAccessGrenadeGridItemView Create(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, int grenadeCount) { }

	private FastAccessGrenadeGridItemView NewFastAccessGrenadeGridItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, int grenadeCount) { }

	protected virtual void SetItemBinding(Nullable slotName) { }

	protected virtual void SetItemValue(EItemValueFormat format, bool display, string color, object arg1, object arg2 = null, string color2 = null) { }

}

