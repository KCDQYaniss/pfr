//Type is in global namespace

public class TransferItemView : GridItemView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <get_Transparency>b__6_0(float baseTransparent, bool isSelectedForTransfer, bool isTransferAllowed) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public TransferItemView <>4__this; //Field offset: 0x10
		public ReferenceItemContext sourceContext; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <NewTransferItemView>b__0(bool x) { }

	}

	[SerializeField]
	private GameObject _stashSelectedImage; //Field offset: 0x2E0
	[SerializeField]
	private GameObject _transferSelectedImage; //Field offset: 0x2E8
	private readonly BindableState _isSelectedForTransfer; //Field offset: 0x2F0
	private readonly BindableState _isTransferAllowed; //Field offset: 0x2F8
	private SelectableItemContext _selectableItemContext; //Field offset: 0x300

	protected virtual IBindable Transparency
	{
		 get { } //Length: 413
	}

	public TransferItemView() { }

	protected virtual void ChangeSelectedStatus(bool selected) { }

	public static TransferItemView Create(Item item, ReferenceItemContext sourceContext, ItemRotation rotation, ItemController inventoryController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual ItemContext CreateNewItemContext(ItemContext sourceContext) { }

	protected virtual IBindable get_Transparency() { }

	private void ItemChanged(ItemEventArgs eventArgs) { }

	public virtual void Kill() { }

	private TransferItemView NewTransferItemView(Item item, ReferenceItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	protected virtual void OnItemAdded(AddItemEventArgs eventArgs) { }

	protected virtual void OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	protected virtual void ShowTooltip() { }

	private void UpdateItemTransferAvailability() { }

	protected virtual void UpdateStaticInfo() { }

}

