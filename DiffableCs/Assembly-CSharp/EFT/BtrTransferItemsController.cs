namespace EFT;

public sealed class BtrTransferItemsController : TransferItemsController
{
	private readonly BTRGlobalSettings _settings; //Field offset: 0x50

	public BtrTransferItemsController(GameWorld gameWorld, BTRGlobalSettings settings, bool isOfflineGame) { }

	public virtual int CalculateServicePrice(string profileId, ETraderServiceType serviceType, int basePrice) { }

	public virtual double GetDeliveryPriceForProfile(string profileId) { }

	public virtual int GetGridItemsPrice(Stash stashContainer) { }

	protected virtual Vector3 GetGridSize(Profile profile) { }

}

