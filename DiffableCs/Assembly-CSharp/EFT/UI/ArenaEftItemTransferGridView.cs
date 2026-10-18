namespace EFT.UI;

public class ArenaEftItemTransferGridView : GridView
{
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x108

	public event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public ArenaEftItemTransferGridView() { }

	public virtual Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	[CompilerGenerated]
	public void add_OnItemSelected(Action value) { }

	public virtual bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	[CompilerGenerated]
	public void remove_OnItemSelected(Action value) { }

}

