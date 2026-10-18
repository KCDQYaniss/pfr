namespace EFT.UI;

public sealed class MessageWindow : BaseMessageWindow
{
	private ECursorResult _shouldShowCursor; //Field offset: 0xF0

	public MessageWindow() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public DialogWindowContext Show(string title, string message, bool canShowCloseButton, float time = 0, bool showCursor = false, bool exitActsAsAccept = false) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

}

