namespace EFT.InventoryLogic;

public sealed class OfflineInventoryController : BackEndInventoryController
{

	public virtual bool InboundTransfer
	{
		 get { } //Length: 11
	}

	public OfflineInventoryController(IClientSession backendSession, Profile profile, string mainProfileId) { }

	public OfflineInventoryController(IClientSession backendSession) { }

	public virtual bool get_InboundTransfer() { }

}

