namespace UnityEngine.UIElements;

internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController, IReorderable
{
	protected readonly BaseVerticalCollectionView m_View; //Field offset: 0x10
	protected List m_SortedSelectedIds; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <enableReordering>k__BackingField; //Field offset: 0x20

	public override bool enableReordering
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected BaseReorderableDragAndDropController(BaseVerticalCollectionView view) { }

	public override bool CanStartDrag(IEnumerable itemIds) { }

	protected override int CompareId(int id1, int id2) { }

	public override void DragCleanup() { }

	[CompilerGenerated]
	public override bool get_enableReordering() { }

	public override IEnumerable GetSortedSelectedIds() { }

	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	public abstract void OnDrop(IListDragAndDropArgs args) { }

	[CompilerGenerated]
	public override void set_enableReordering(bool value) { }

	public override StartDragArgs SetupDragAndDrop(IEnumerable itemIds, bool skipText = false) { }

}

