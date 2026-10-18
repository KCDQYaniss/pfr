namespace EFT.UI;

public sealed class SelectWeaponBodyWindow : HandoverSelectItemsWindow
{
	private Item _lastSelectedItem; //Field offset: 0x138
	private Action _acceptAction; //Field offset: 0x140

	public SelectWeaponBodyWindow() { }

	protected virtual void Accept() { }

	public virtual void Close() { }

	private void DeselectLastSelected() { }

	protected virtual bool IsActive(Item item, out string tooltip) { }

	protected virtual bool IsSelected(Item item) { }

	public DialogWindowContext Show(Item[] items, Item selectedItem, Profile profile, InventoryController inventoryController, Action acceptAction, bool canShowCloseButton) { }

	protected virtual void TrySelectItemToHandover(Item item) { }

}

