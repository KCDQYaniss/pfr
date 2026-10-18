namespace EFT.Dialogs;

public interface IDialogContext : ISaveStateStorage
{

	public event Action OnBlockDialog
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public BaseTraderDialog CurrentDialog
	{
		 get { } //Length: 0
	}

	public InventoryController InventoryController
	{
		 get { } //Length: 0
	}

	public Profile Profile
	{
		 get { } //Length: 0
	}

	public QuestController QuestController
	{
		 get { } //Length: 0
	}

	public IEnumerable QuestsData
	{
		 get { } //Length: 0
	}

	public int SelectedRandomGroup
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ETraderServiceType SelectedServiceType
	{
		 get { } //Length: 0
	}

	public string SelectedSubServiceId
	{
		 get { } //Length: 0
	}

	public IReadOnlyDictionary ServicesData
	{
		 get { } //Length: 0
	}

	public IReadOnlyDictionary TaskConditionCounters
	{
		 get { } //Length: 0
	}

	public TraderInfo Trader
	{
		 get { } //Length: 0
	}

	public Dictionary TradersInfo
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnBlockDialog(Action value) { }

	public void ClearTempData() { }

	public BaseTraderDialog get_CurrentDialog() { }

	public InventoryController get_InventoryController() { }

	public Profile get_Profile() { }

	public QuestController get_QuestController() { }

	public IEnumerable get_QuestsData() { }

	public int get_SelectedRandomGroup() { }

	public ETraderServiceType get_SelectedServiceType() { }

	public string get_SelectedSubServiceId() { }

	public IReadOnlyDictionary get_ServicesData() { }

	public IReadOnlyDictionary get_TaskConditionCounters() { }

	public TraderInfo get_Trader() { }

	public Dictionary get_TradersInfo() { }

	public int GetRandomValue(RandomLineCondition condition) { }

	[CompilerGenerated]
	public void remove_OnBlockDialog(Action value) { }

	public void SelectSubService(DialogSelectSubServiceAction selectSubServiceAction) { }

	public void set_SelectedRandomGroup(int value) { }

}

