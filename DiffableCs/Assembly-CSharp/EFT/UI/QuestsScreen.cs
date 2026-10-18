namespace EFT.UI;

public sealed class QuestsScreen : UIElement
{
	[SerializeField]
	private QuestView _questView; //Field offset: 0x70
	[SerializeField]
	private QuestsListView _questsListView; //Field offset: 0x78

	public QuestsScreen() { }

	public virtual void Close() { }

	public void Show(IEftSession backendSession, InventoryController inventoryController, QuestController questController, Trader trader) { }

}

