namespace EFT.UI;

public abstract class PreloaderPanelBase : UIElement
{

	protected PreloaderPanelBase() { }

	public abstract void Hide(bool soft) { }

	public abstract void Show(bool soft) { }

}

