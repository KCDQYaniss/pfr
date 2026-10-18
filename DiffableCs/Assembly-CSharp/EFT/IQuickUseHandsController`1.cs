namespace EFT;

public interface IQuickUseHandsController`1 : IQuickUseHandsController, IHandsController
{

	public TItem Item
	{
		 get { } //Length: 0
	}

	public TItem get_Item() { }

	public void SetOnUsedCallback(Callback callback) { }

}

