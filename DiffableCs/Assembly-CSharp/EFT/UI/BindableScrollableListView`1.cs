namespace EFT.UI;

public class BindableScrollableListView`1 : IDisposable
{
	private readonly IBindableList _list; //Field offset: 0x0
	private readonly Action _showAction; //Field offset: 0x0
	private readonly Action _removeAction; //Field offset: 0x0
	private readonly Action _removeAllAction; //Field offset: 0x0

	public BindableScrollableListView`1(IBindableList list, Action showAction, Action removeAction, Action removeAllAction) { }

	public override void Dispose() { }

	private void OnItemAdded(TItem item) { }

	private void OnItemRemoved(TItem item) { }

	private void OnItemsAdded(IEnumerable items) { }

	private void OnItemsRemoved() { }

}

