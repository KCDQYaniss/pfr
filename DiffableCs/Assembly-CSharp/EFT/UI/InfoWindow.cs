namespace EFT.UI;

[UsedImplicitly]
public sealed class InfoWindow : Window, IAddHandler, IItemRelatedView, IRemoveHandler, IRefreshHandler
{
	[CompilerGenerated]
	private sealed class <ResizeTag>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InfoWindow <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ResizeTag>d__16(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const float MIN_ALLOWED_TAG_SIZE = 40; //Field offset: 0x0
	private const float TAG_TEXT_SIDE_MARGIN = 12; //Field offset: 0x0
	[SerializeField]
	private ItemSpecificationPanel _itemSpecificationPanel; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _tagName; //Field offset: 0xC0
	[SerializeField]
	private Image _tagColor; //Field offset: 0xC8
	private Item _item; //Field offset: 0xD0
	private ItemContext _itemContext; //Field offset: 0xD8
	private IItemOwner _itemOwner; //Field offset: 0xE0
	private Trader _trader; //Field offset: 0xE8

	public InfoWindow() { }

	public virtual void Close() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs obj) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private void OnAssortmentChanged() { }

	private void OnItemPrepared(Item item) { }

	[IteratorStateMachine(typeof(<ResizeTag>d__16))]
	private IEnumerator ResizeTag() { }

	public WindowContext Show(ItemContext itemContext, IItemOwner itemController, Trader trader, ItemUiContext itemUiContext, ContextInteractions contextInteractions) { }

	private void UpdateTag() { }

}

