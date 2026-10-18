namespace EFT.UI;

[UsedImplicitly]
public sealed class TraderDialogHistoryView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public TraderDialogBubble bubble; //Field offset: 0x10
		public Queue pool; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <DrawNewLine>b__0() { }

	}

	[SerializeField]
	private TraderDialogBubble _traderBubbleTemplate; //Field offset: 0x70
	[SerializeField]
	private TraderDialogBubble _playerBubbleTemplate; //Field offset: 0x78
	[SerializeField]
	private RectTransform _container; //Field offset: 0x80
	[SerializeField]
	private Scrollbar _scrollBar; //Field offset: 0x88
	private TraderDialogHistory _history; //Field offset: 0x90
	private readonly Queue _traderBubbles; //Field offset: 0x98
	private readonly Queue _playerBubbles; //Field offset: 0xA0
	private readonly CompositeDisposable _bubblesDisposable; //Field offset: 0xA8

	public TraderDialogHistoryView() { }

	[CompilerGenerated]
	private void <Show>b__8_0() { }

	private void DrawNewLine(DialogHistoryLine line) { }

	private void Redraw() { }

	public void Show(TraderDialogHistory history) { }

}

