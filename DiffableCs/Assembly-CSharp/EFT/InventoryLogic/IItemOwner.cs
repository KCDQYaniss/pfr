namespace EFT.InventoryLogic;

public interface IItemOwner : IContainer, IItemContainer
{

	public event Action ActiveEventsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action AddItemEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action CreateMapMarkerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action DeleteMapMarkerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EditMapMarkerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerExamineEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action RefreshItemEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action RemoveItemEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string ContainerName
	{
		 get { } //Length: 0
	}

	public bool InboundTransfer
	{
		 get { } //Length: 0
	}

	public bool Locked
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public EOwnerType OwnerType
	{
		 get { } //Length: 0
	}

	public Item RootItem
	{
		 get { } //Length: 0
	}

	public ISearchController SearchController
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ActiveEventsChanged(Action value) { }

	[CompilerGenerated]
	public void add_AddItemEvent(Action value) { }

	[CompilerGenerated]
	public void add_CreateMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void add_DeleteMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void add_EditMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void add_PlayerExamineEvent(Action value) { }

	[CompilerGenerated]
	public void add_RefreshItemEvent(Action value) { }

	[CompilerGenerated]
	public void add_RemoveItemEvent(Action value) { }

	public Option CheckItemAction(Item item, ItemAddress location) { }

	public string get_ContainerName() { }

	public bool get_InboundTransfer() { }

	public bool get_Locked() { }

	public EOwnerType get_OwnerType() { }

	public Item get_RootItem() { }

	public ISearchController get_SearchController() { }

	public bool HasForeignEvents(Item item, ItemController controller) { }

	public void InProcess(Item item, ItemAddress to, bool succeed, IInventoryOperation operation, Callback callback) { }

	public void OutProcess(Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation, Callback callback) { }

	public void RaiseAddEvent(AddItemEventArgs args) { }

	public void RaiseBindItemEvent(BindItemEventArgs args) { }

	public void RaiseCreateMapMarkerEvent(CreateMapMarkerEventArgs args) { }

	public void RaiseDeleteMapMarkerEvent(DeleteMapMarkerEventArgs args) { }

	public void RaiseEditMapMarkerEvent(EditMapMarkerEventArgs args) { }

	public void RaiseEvent(DrainItemEventArgs args) { }

	public void RaiseEvent(RefreshItemEventArgs args) { }

	public void RaiseExamineEvent(ExamineItemEventArgs args) { }

	public void RaiseInventoryCheckMagazine(Magazine item, float time, bool status) { }

	public void RaiseLoadMagazineEvent(LoadMagazineEventArgs args) { }

	public void RaiseRemoveEvent(RemoveItemEventArgs args) { }

	public void RaiseTraderServicePurchaseEvent(ETraderServiceType serviceType, string subServiceId) { }

	public void RaiseUnbindItemEvent(UnbindItemEventArgs args) { }

	public void RaiseUnloadMagazineEvent(UnloadMagazineEventArgs args) { }

	public void RegisterView(IItemRelatedView view) { }

	[CompilerGenerated]
	public void remove_ActiveEventsChanged(Action value) { }

	[CompilerGenerated]
	public void remove_AddItemEvent(Action value) { }

	[CompilerGenerated]
	public void remove_CreateMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void remove_DeleteMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EditMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerExamineEvent(Action value) { }

	[CompilerGenerated]
	public void remove_RefreshItemEvent(Action value) { }

	[CompilerGenerated]
	public void remove_RemoveItemEvent(Action value) { }

	public IEnumerable SelectEvents(Item item = null) { }

	public IEnumerable SelectEvents(Item item) { }

	public void set_Locked(bool value) { }

	[CanBeNull]
	public ItemAddress ToItemAddress(ItemAddressDescriptor descriptor) { }

	public void UnregisterView(IItemRelatedView view) { }

}

