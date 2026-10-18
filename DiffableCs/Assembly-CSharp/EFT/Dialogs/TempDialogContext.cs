namespace EFT.Dialogs;

public sealed class TempDialogContext : IDialogContext, ISaveStateStorage
{
	private static readonly IReadOnlyDictionary _emptyDict; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnBlockDialog; //Field offset: 0x10
	private readonly IDialogContext _context; //Field offset: 0x18
	private readonly Dictionary _localVariables; //Field offset: 0x20
	private readonly Dictionary _globalVariables; //Field offset: 0x28
	private IReadOnlyDictionary _localSourceVariables; //Field offset: 0x30
	private readonly IReadOnlyDictionary _globalSourceVariables; //Field offset: 0x38
	private readonly TraderInfo _trader; //Field offset: 0x40
	private ETraderServiceType _selectedServiceType; //Field offset: 0x48
	private string _selectedSubServiceId; //Field offset: 0x50
	private int _selectedRandomGroup; //Field offset: 0x58

	public override event Action OnBlockDialog
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private override BaseTraderDialog EFT.Dialogs.IDialogContext.CurrentDialog
	{
		private get { } //Length: 66
	}

	private override InventoryController EFT.Dialogs.IDialogContext.InventoryController
	{
		private get { } //Length: 78
	}

	private override Profile EFT.Dialogs.IDialogContext.Profile
	{
		private get { } //Length: 78
	}

	private override QuestController EFT.Dialogs.IDialogContext.QuestController
	{
		private get { } //Length: 78
	}

	private override IEnumerable EFT.Dialogs.IDialogContext.QuestsData
	{
		private get { } //Length: 78
	}

	private override int EFT.Dialogs.IDialogContext.SelectedRandomGroup
	{
		private get { } //Length: 4
		private set { } //Length: 4
	}

	private override ETraderServiceType EFT.Dialogs.IDialogContext.SelectedServiceType
	{
		private get { } //Length: 4
	}

	private override string EFT.Dialogs.IDialogContext.SelectedSubServiceId
	{
		private get { } //Length: 5
	}

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.ServicesData
	{
		private get { } //Length: 78
	}

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.TaskConditionCounters
	{
		private get { } //Length: 78
	}

	private override TraderInfo EFT.Dialogs.IDialogContext.Trader
	{
		private get { } //Length: 5
	}

	private override Dictionary EFT.Dialogs.IDialogContext.TradersInfo
	{
		private get { } //Length: 78
	}

	private static TempDialogContext() { }

	public TempDialogContext(IDialogContext context, TraderInfo traderInfo, IReadOnlyDictionary localSourceVariables, IReadOnlyDictionary globalSourceVariables) { }

	[CompilerGenerated]
	public override void add_OnBlockDialog(Action value) { }

	private override void EFT.Dialogs.IDialogContext.ClearTempData() { }

	private override BaseTraderDialog EFT.Dialogs.IDialogContext.get_CurrentDialog() { }

	private override InventoryController EFT.Dialogs.IDialogContext.get_InventoryController() { }

	private override Profile EFT.Dialogs.IDialogContext.get_Profile() { }

	private override QuestController EFT.Dialogs.IDialogContext.get_QuestController() { }

	private override IEnumerable EFT.Dialogs.IDialogContext.get_QuestsData() { }

	private override int EFT.Dialogs.IDialogContext.get_SelectedRandomGroup() { }

	private override ETraderServiceType EFT.Dialogs.IDialogContext.get_SelectedServiceType() { }

	private override string EFT.Dialogs.IDialogContext.get_SelectedSubServiceId() { }

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.get_ServicesData() { }

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.get_TaskConditionCounters() { }

	private override TraderInfo EFT.Dialogs.IDialogContext.get_Trader() { }

	private override Dictionary EFT.Dialogs.IDialogContext.get_TradersInfo() { }

	private override int EFT.Dialogs.IDialogContext.GetRandomValue(RandomLineCondition condition) { }

	private override void EFT.Dialogs.IDialogContext.SelectSubService(DialogSelectSubServiceAction selectSubServiceAction) { }

	private override void EFT.Dialogs.IDialogContext.set_SelectedRandomGroup(int value) { }

	private override int EFT.Dialogs.ISaveStateStorage.GetVariableValue(MongoID variableId) { }

	private override void EFT.Dialogs.ISaveStateStorage.SetVariableValue(SaveStateData saveData) { }

	[CompilerGenerated]
	public override void remove_OnBlockDialog(Action value) { }

}

