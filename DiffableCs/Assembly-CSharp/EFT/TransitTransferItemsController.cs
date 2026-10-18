namespace EFT;

public sealed class TransitTransferItemsController : TransferItemsController
{
	private readonly TransitGlobalSettings _settings; //Field offset: 0x50

	public TransitTransferItemsController(GameWorld gameWorld, TransitGlobalSettings settings, bool isOfflineGame) { }

	public virtual int CalculateServicePrice(string profileId, ETraderServiceType serviceType, int basePrice) { }

	public virtual double GetDeliveryPriceForProfile(string profileId) { }

	public virtual int GetGridItemsPrice(Stash stashContainer) { }

	protected virtual Vector3 GetGridSize(Profile profile) { }

}

