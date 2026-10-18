namespace EFT.UI;

public sealed class ToggleTab
{
	private readonly IShowable _screen; //Field offset: 0x10
	private readonly AnimatedToggle _toggle; //Field offset: 0x18
	private readonly Action _onShow; //Field offset: 0x20

	public ToggleTab(IShowable screen, AnimatedToggle toggle, Action onShow) { }

	public void Close() { }

	public void Show() { }

}

