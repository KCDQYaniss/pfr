namespace EFT;

public interface IInventoryMagazineCheckHandler : IItemRelatedView
{

	public void OnInventoryMagazineCheck(Magazine item, float time, bool status) { }

}

