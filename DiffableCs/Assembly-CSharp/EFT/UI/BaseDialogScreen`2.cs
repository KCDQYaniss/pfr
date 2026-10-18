namespace EFT.UI;

public abstract class BaseDialogScreen`2 : EftScreen
{
	private readonly Dictionary _hotkeyMapping; //Field offset: 0x0
	protected ClientDialogController dialogController; //Field offset: 0x0
	protected double lastDialogRedrawUnix; //Field offset: 0x0

	protected override bool CanHandleInput
	{
		 get { } //Length: 52
	}

	protected override bool CanSkipAnimation
	{
		 get { } //Length: 3
	}

	protected BaseDialogScreen`2() { }

	[CompilerGenerated]
	private void <Show>b__8_0() { }

	protected override bool get_CanHandleInput() { }

	protected override bool get_CanSkipAnimation() { }

	private void HandleKeyboardInput() { }

	private void OnDialogChangedHandler(BaseTraderDialog newDialog) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void Show(TController controller) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

