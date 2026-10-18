namespace EFT;

public interface IQuickUseItem : IHandsController
{

	public Callback GetOnUsedCallback() { }

	public void SetOnUsedCallback(Callback callback) { }

}

