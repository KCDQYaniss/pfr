namespace EFT.UI.Screens;

public abstract class EftAsyncScreen`2 : EftScreen
{

	protected EftAsyncScreen`2() { }

	public virtual void Show(TController controller) { }

	public abstract Task ShowAsync(TController controller) { }

}

