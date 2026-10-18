namespace EFT.UI;

public static class ScrollInput
{

	private static bool IsScrollCommand(ECommand command) { }

	private static bool IsTextInputFocused() { }

	public static bool TryApply(ScrollRect scrollRect, ECommand command) { }

	public static bool TryApply(LightScroller scroller, ECommand command) { }

}

