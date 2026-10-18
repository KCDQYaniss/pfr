namespace EFT.InventoryLogic;

public abstract class ItemContext : IDisposable
{
	protected static EItemViewComponent[] _viewComponents; //Field offset: 0x0
	public readonly Item Item; //Field offset: 0x10
	public readonly EItemViewType ViewType; //Field offset: 0x18
	public bool Searched; //Field offset: 0x1C
	[CompilerGenerated]
	private LocalizedError <Error>k__BackingField; //Field offset: 0x20
	private ETargetContainer _availableQuickMoveTargetContainer; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnUpdate; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnCloseDependentWindow; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnDragStateChange; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnInventoryError; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnCheckAccept; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnDisposed; //Field offset: 0x58
	[CanBeNull]
	private ItemContext _source; //Field offset: 0x60

	public event Action OnCheckAccept
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnCloseDependentWindow
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnDisposed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnDragStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnInventoryError
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override bool DragAvailable
	{
		 get { } //Length: 96
	}

	public override LocalizedError Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public InventoryError InventoryError
	{
		 set { } //Length: 64
	}

	public override bool IsPreviewHighlightAvailable
	{
		 get { } //Length: 259
	}

	public override bool MergeAvailable
	{
		 get { } //Length: 64
	}

	public override bool ModificationAvailable
	{
		 get { } //Length: 3
	}

	private ItemContext RootContext
	{
		private get { } //Length: 39
	}

	public override Nullable RotationLock
	{
		 get { } //Length: 3
	}

	[CanBeNull]
	protected private ItemContext Source
	{
		 get { } //Length: 5
		private set { } //Length: 599
	}

	public override bool SplitAvailable
	{
		 get { } //Length: 44
	}

	protected override IEnumerable ViewComponents
	{
		 get { } //Length: 83
	}

	private static ItemContext() { }

	protected ItemContext(Item item, EItemViewType viewType, ItemContext sourceContext = null) { }

	[CompilerGenerated]
	public void add_OnCheckAccept(Action value) { }

	[CompilerGenerated]
	public void add_OnCloseDependentWindow(Action value) { }

	[CompilerGenerated]
	public void add_OnDisposed(Action value) { }

	[CompilerGenerated]
	public void add_OnDragStateChange(Action value) { }

	[CompilerGenerated]
	public void add_OnInventoryError(Action value) { }

	[CompilerGenerated]
	public void add_OnUpdate(Action value) { }

	public override bool CanQuickMoveTo(ETargetContainer targetContainer) { }

	public override void CheckAccept(DragItemContext itemContext) { }

	public override void CloseDependentWindows() { }

	public abstract ItemContext CreateChild(Item item) { }

	public override void Dispose() { }

	public override void DragCancelled() { }

	public override void DragStarted() { }

	public override bool get_DragAvailable() { }

	[CompilerGenerated]
	public override LocalizedError get_Error() { }

	public override bool get_IsPreviewHighlightAvailable() { }

	public override bool get_MergeAvailable() { }

	public override bool get_ModificationAvailable() { }

	private ItemContext get_RootContext() { }

	public override Nullable get_RotationLock() { }

	protected ItemContext get_Source() { }

	public override bool get_SplitAvailable() { }

	protected override IEnumerable get_ViewComponents() { }

	public override ContextInteractions GetItemContextInteractions(Action closeAction) { }

	public bool HasViewComponent(EItemViewComponent viewComponent) { }

	private void InitTargetContainers() { }

	protected override void InventoryErrorHandler(InventoryError error) { }

	public override bool IsDropAvailable(DragItemContext itemContext) { }

	public override bool IsInteractionAllowed(EItemInfoButton button) { }

	public override IResult IsInteractionInteractive(EItemInfoButton button) { }

	public bool IsOperationAllowed(IOperationResult operation) { }

	[CompilerGenerated]
	public void remove_OnCheckAccept(Action value) { }

	[CompilerGenerated]
	public void remove_OnCloseDependentWindow(Action value) { }

	[CompilerGenerated]
	public void remove_OnDisposed(Action value) { }

	[CompilerGenerated]
	public void remove_OnDragStateChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnInventoryError(Action value) { }

	[CompilerGenerated]
	public void remove_OnUpdate(Action value) { }

	[CompilerGenerated]
	protected override void set_Error(LocalizedError value) { }

	public void set_InventoryError(InventoryError value) { }

	private void set_Source(ItemContext value) { }

	protected override void SwitchToParentsSource() { }

	public virtual string ToString() { }

	private void Unsubscribe() { }

	public override void UpdateView() { }

}

