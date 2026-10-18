namespace EFT.UI;

public abstract class HandoverSelectItemsWindow : HandoverItemsWindow, ISelectionContext
{
	[SerializeField]
	private Button _autoSelectButton; //Field offset: 0x120
	protected double CurrentValue; //Field offset: 0x128
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x130

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected HandoverSelectItemsWindow() { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	protected override void AutoSelectButtonPressedHandler() { }

	protected virtual void Awake() { }

	protected virtual void Clear() { }

	protected override void ClearSelectedList() { }

	protected void DeselectView(Item item) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	protected abstract bool IsActive(Item item, out string tooltip) { }

	protected abstract bool IsSelected(Item item) { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	protected void SelectView(Item item) { }

	protected DialogWindowContext Show(string title, string message, Profile profile, ItemController itemController, SelectableItemContext itemContext, bool canShowCloseButton) { }

	protected abstract void TrySelectItemToHandover(Item item) { }

}

