namespace UI.Hideout;

public sealed class HideoutAreaTransferItemsScreen : AbstractHideoutAreaTransferItemsScreen
{
	internal sealed class HideoutAreaTransferItemsScreenController : BaseHideoutAreaTransferItemsScreenController
	{

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public HideoutAreaTransferItemsScreenController(AreaData areaData, InventoryController inventoryController, IEftSession session) { }

		protected virtual void CloseAction(bool moveForward) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}


	public HideoutAreaTransferItemsScreen() { }

	public virtual void Show(HideoutAreaTransferItemsScreenController controller) { }

}

