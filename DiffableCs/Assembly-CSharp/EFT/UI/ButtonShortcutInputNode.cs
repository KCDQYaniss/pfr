namespace EFT.UI;

public sealed class ButtonShortcutInputNode : UIInputNode
{
	[CompilerGenerated]
	private sealed class <ActivateAfterFeedback>d__12 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ButtonShortcutInputNode <>4__this; //Field offset: 0x20
		public PointerEventData eventData; //Field offset: 0x28

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
		public <ActivateAfterFeedback>d__12(int <>1__state) { }

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
	private Button _button; //Field offset: 0x80
	[SerializeField]
	private ECommand _command; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _keyLabel; //Field offset: 0x90
	[SerializeField]
	private EGameKey _key; //Field offset: 0x98
	private readonly BindableEvent _onActivated; //Field offset: 0xA0
	private bool _activationScheduled; //Field offset: 0xA8
	private ButtonFeedback _buttonFeedback; //Field offset: 0xB0

	public IBindableEvent OnActivated
	{
		 get { } //Length: 8
	}

	public ButtonShortcutInputNode() { }

	[CompilerGenerated]
	private bool <OnEnable>b__13_0(KeyGroup x) { }

	private void Activate() { }

	[IteratorStateMachine(typeof(<ActivateAfterFeedback>d__12))]
	private IEnumerator ActivateAfterFeedback(PointerEventData eventData) { }

	private void Awake() { }

	public IBindableEvent get_OnActivated() { }

	private void OnEnable() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

