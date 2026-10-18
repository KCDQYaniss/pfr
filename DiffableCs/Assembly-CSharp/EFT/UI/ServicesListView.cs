namespace EFT.UI;

public class ServicesListView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Trader trader; //Field offset: 0x10
		public ServicesListView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <Show>b__0(ServiceInfo info) { }

		internal void <Show>b__1(ServiceInfo service, ServiceListItem serviceView) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Trader trader; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <CheckAvailableServices>b__0(ServiceInfo info) { }

	}

	internal class ServiceInfo
	{
		public string Name; //Field offset: 0x10
		public Sprite IconBackground; //Field offset: 0x18
		public Sprite Icon; //Field offset: 0x20
		public ServiceView ServiceView; //Field offset: 0x28

		public ServiceInfo() { }

	}

	[SerializeField]
	private RectTransform _serviceListContainer; //Field offset: 0x70
	[SerializeField]
	private ServiceListItem _serviceItemTemplate; //Field offset: 0x78
	[SerializeField]
	private ServiceInfo[] _possibleServices; //Field offset: 0x80
	private ServiceListItem _selectedItem; //Field offset: 0x88

	public ServicesListView() { }

	public bool CheckAvailableServices(Trader trader) { }

	private void OnServiceSelected(ServiceListItem serviceItem) { }

	public void Show(Trader trader, Profile profile, InventoryController inventoryController, IHealthController healthController, QuestBook quests, ItemUiContext context, IEftSession session) { }

}

