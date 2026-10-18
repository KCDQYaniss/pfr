namespace EFT.UI.DragAndDrop;

public abstract class ContainedGridsView : UIElement
{
	[CompilerGenerated]
	private GridView[] <GridViews>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private SlotView[] <SlotViews>k__BackingField; //Field offset: 0x78

	public private GridView[] GridViews
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private SlotView[] SlotViews
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected ContainedGridsView() { }

	[CanBeNull]
	public static ContainedGridsView CreateGrids(Item item, ContainedGridsView containedGridsTemplate) { }

	[CompilerGenerated]
	public GridView[] get_GridViews() { }

	[CompilerGenerated]
	public SlotView[] get_SlotViews() { }

	[CompilerGenerated]
	private void set_GridViews(GridView[] value) { }

	[CompilerGenerated]
	private void set_SlotViews(SlotView[] value) { }

	public abstract void Show(CompoundItem compoundItem, ItemContext itemContext, ItemController itemController, FilterPanel filterPanel, ItemUiContext itemUiContext, bool magnify = false) { }

	protected void Show(CompoundItem compoundItem, ItemContext itemContext, GridView[] gridViews, SlotView[] slotViews, ItemController itemController, FilterPanel filterPanel, ItemUiContext itemUiContext, bool magnify = false) { }

}

