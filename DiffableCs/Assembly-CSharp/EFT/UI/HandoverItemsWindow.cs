namespace EFT.UI;

public abstract class HandoverItemsWindow : BaseMessageWindow
{
	[SerializeField]
	protected GridView _itemsToHandover; //Field offset: 0xF0
	protected Stash _stashUpdate; //Field offset: 0xF8
	protected ItemController _itemController; //Field offset: 0x100
	[CompilerGenerated]
	private ItemContext <ItemContext>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private ItemUiContext <ItemUiContext>k__BackingField; //Field offset: 0x110
	protected readonly List ItemsList; //Field offset: 0x118

	protected override bool CanStretchHorizontally
	{
		 get { } //Length: 3
	}

	protected override bool CanStretchVertically
	{
		 get { } //Length: 3
	}

	protected override int GridHeight
	{
		 get { } //Length: 6
	}

	protected GridView GridView
	{
		 get { } //Length: 8
	}

	protected override int GridWidth
	{
		 get { } //Length: 6
	}

	protected private ItemContext ItemContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected Item[] ItemsToHandover
	{
		 get { } //Length: 76
	}

	protected private ItemUiContext ItemUiContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected HandoverItemsWindow() { }

	protected virtual void Awake() { }

	protected override void Clear() { }

	protected override bool get_CanStretchHorizontally() { }

	protected override bool get_CanStretchVertically() { }

	protected override int get_GridHeight() { }

	protected GridView get_GridView() { }

	protected override int get_GridWidth() { }

	[CompilerGenerated]
	protected ItemContext get_ItemContext() { }

	protected Item[] get_ItemsToHandover() { }

	[CompilerGenerated]
	protected ItemUiContext get_ItemUiContext() { }

	[CompilerGenerated]
	private void set_ItemContext(ItemContext value) { }

	[CompilerGenerated]
	private void set_ItemUiContext(ItemUiContext value) { }

	protected DialogWindowContext Show(string title, string message, IInventoryProfileInfo profile, ItemController itemController, ItemContext itemContext, bool canShowCloseButton) { }

	protected override void UpdateItems(IEnumerable items) { }

}

