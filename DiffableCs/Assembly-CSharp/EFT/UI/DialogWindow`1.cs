namespace EFT.UI;

public abstract class DialogWindow`1 : Window
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public TContext windowContext; //Field offset: 0x0
		public DialogWindow <>4__this; //Field offset: 0x0

		public <>c__DisplayClass18_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	private const int OK_BUTTON_TEXT_SIZE = 24; //Field offset: 0x0
	private const string OK_BUTTON_TEXT = "OK"; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _acceptButton; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0x0
	private string _defaultOkText; //Field offset: 0x0
	private int _defaultOkSize; //Field offset: 0x0
	private bool _availableToAccept; //Field offset: 0x0
	private bool _exitActsAsAccept; //Field offset: 0x0

	protected DefaultUIButton AcceptButton
	{
		 get { } //Length: 8
	}

	protected DefaultUIButton CancelButton
	{
		 get { } //Length: 8
	}

	protected override bool CloseOnAccept
	{
		 get { } //Length: 3
	}

	protected override bool ShowInCenter
	{
		 get { } //Length: 3
	}

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	protected DialogWindow`1() { }

	protected override void Accept() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void Close(ECloseState state) { }

	protected void CloseSilent() { }

	public override void Decline() { }

	protected DefaultUIButton get_AcceptButton() { }

	protected DefaultUIButton get_CancelButton() { }

	protected override bool get_CloseOnAccept() { }

	protected override bool get_ShowInCenter() { }

	protected virtual bool get_ShowOnTop() { }

	protected override void SetAcceptActive(bool value) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected TContext Show(string title, bool showCloseButton, bool exitActsAsAccept = false) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected override void Update() { }

}

