namespace EFT.UI;

[UsedImplicitly]
public class TraderDialogWindowOptionRow : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <CheckSelectedStateCoroutine>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TraderDialogWindowOptionRow <>4__this; //Field offset: 0x20

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
		public <CheckSelectedStateCoroutine>d__10(int <>1__state) { }

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

	[SerializeField]
	private TextMeshProUGUI _text; //Field offset: 0x70
	[SerializeField]
	private Image _icon; //Field offset: 0x78
	[SerializeField]
	private Image _background; //Field offset: 0x80
	[SerializeField]
	private Color _defaultTextColor; //Field offset: 0x88
	[SerializeField]
	private Color _selectedTextColor; //Field offset: 0x98
	private BaseTraderDialogLine _dialogLine; //Field offset: 0xA8
	private CanvasGroup _canvasGroup; //Field offset: 0xB0

	private CanvasGroup CanvasGroup
	{
		private get { } //Length: 405
	}

	public TraderDialogWindowOptionRow() { }

	private void Block() { }

	[IteratorStateMachine(typeof(<CheckSelectedStateCoroutine>d__10))]
	private IEnumerator CheckSelectedStateCoroutine() { }

	private CanvasGroup get_CanvasGroup() { }

	private void SetSelectedState(bool selected) { }

	public void Show(BaseTraderDialogLine line) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

