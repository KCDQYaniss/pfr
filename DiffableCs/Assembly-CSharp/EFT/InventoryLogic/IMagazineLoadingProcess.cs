namespace EFT.InventoryLogic;

internal interface IMagazineLoadingProcess
{

	public void Proceed(bool success = true) { }

	public Task Start() { }

	public void TryProceedForItem(Item magazine) { }

}

