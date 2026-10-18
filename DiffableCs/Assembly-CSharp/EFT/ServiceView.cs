namespace EFT;

public abstract class ServiceView : UIElement
{

	protected ServiceView() { }

	public abstract bool CheckAvailable(Trader trader) { }

	public void Hide() { }

	public abstract void Show(Trader trader, Profile profile, InventoryController controller, OfflineHealthController healthController, QuestBook quests, AchievementsBook achievements, ItemUiContext context, IEftSession session) { }

}

