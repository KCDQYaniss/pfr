namespace EFT;

public interface IRefreshHandler : IItemRelatedView
{

	public void OnRefreshItem(RefreshItemEventArgs args) { }

}

