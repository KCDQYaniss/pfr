namespace EFT.UI;

public sealed class ReferenceItemContext : SelectableItemContext
{
	[CompilerGenerated]
	private bool <IsPlayerStashView>k__BackingField; //Field offset: 0x88
	private bool _clickOnly; //Field offset: 0x89

	public virtual bool DragAvailable
	{
		 get { } //Length: 43
	}

	public private bool IsPlayerStashView
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual bool MergeAvailable
	{
		 get { } //Length: 43
	}

	public virtual bool SplitAvailable
	{
		 get { } //Length: 43
	}

	public ReferenceItemContext(EItemViewType viewType, ISelectionContext selectionContext) { }

	private ReferenceItemContext(Item item, SelectableItemContext sourceContext) { }

	public virtual void CheckAccept(DragItemContext itemContext) { }

	public ReferenceItemContext CreatePlayerSideChild(Item item, bool clickOnly = false) { }

	public virtual SelectableItemContext CreateSelectableChild(Item item) { }

	public virtual bool get_DragAvailable() { }

	[CompilerGenerated]
	public bool get_IsPlayerStashView() { }

	public virtual bool get_MergeAvailable() { }

	public virtual bool get_SplitAvailable() { }

	public virtual ContextInteractions GetItemContextInteractions(Action closeAction) { }

	public virtual bool IsDropAvailable(DragItemContext itemContext) { }

	[CompilerGenerated]
	private void set_IsPlayerStashView(bool value) { }

}

