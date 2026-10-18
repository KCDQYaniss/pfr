namespace EFT.UI.DragAndDrop;

public abstract class BaseSelectableItemView : StaticGridItemView
{
	[SerializeField]
	private GameObject _selectedMark; //Field offset: 0x2E0
	[SerializeField]
	private GameObject _selectedBackground; //Field offset: 0x2E8
	[CompilerGenerated]
	private SelectableItemContext <SelectableContext>k__BackingField; //Field offset: 0x2F0

	protected private SelectableItemContext SelectableContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BaseSelectableItemView() { }

	[CompilerGenerated]
	private void <NewBaseSelectableItemView>b__6_0() { }

	[CompilerGenerated]
	protected SelectableItemContext get_SelectableContext() { }

	public virtual void Kill() { }

	protected void NewBaseSelectableItemView(Item item, SelectableItemContext sourceItemContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	protected virtual void OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	[CompilerGenerated]
	private void set_SelectableContext(SelectableItemContext value) { }

	protected abstract void SetAvailability(bool available, string tooltip) { }

	protected override void SetItemSelected(bool selected) { }

	public virtual void UpdateRemoveError(bool ignoreMalfunctions = true) { }

}

