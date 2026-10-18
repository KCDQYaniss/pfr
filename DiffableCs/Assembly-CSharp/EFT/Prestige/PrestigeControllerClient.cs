namespace EFT.Prestige;

public abstract class PrestigeControllerClient : PrestigeController
{
	protected readonly IQuestSession Session; //Field offset: 0x60

	protected PrestigeControllerClient(Profile profile, InventoryController inventoryController, IQuestSession session) { }

}

