namespace EFT.UI;

public class ServicesScreen : UIElement
{
	internal sealed class ServicesDictionary : SerializableEnumDictionary
	{

		public ServicesDictionary() { }

	}

	public ServicesDictionary Services; //Field offset: 0x70
	private ServiceView _currentServiceView; //Field offset: 0x78

	public ServicesScreen() { }

	public bool CheckAvailableServices(Trader trader, EGameMode gameMode) { }

	public virtual void Close() { }

	public void Show(Trader trader, Profile profile, InventoryController inventoryController, IHealthController healthController, QuestBook quests, AchievementsBook achievements, ItemUiContext context, IEftSession session) { }

}

