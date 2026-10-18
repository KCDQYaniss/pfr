namespace EFT.Dialogs;

public abstract class BaseTraderDialogController : IDialogContext, ISaveStateStorage, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__57_3; //Field offset: 0x8
		public static Func <>9__57_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <ProgressDialog>b__57_2(DialogAction action) { }

		internal MongoID <ProgressDialog>b__57_3(BaseTraderDialogLine dialogLine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public BaseTraderDialog dialog; //Field offset: 0x10
		public BaseTraderDialogController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal void <SetCurrentDialog>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public MongoID lineId; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal bool <ProgressDialog>b__0(BaseTraderDialogLine line) { }

		internal bool <ProgressDialog>b__1(BaseTraderDialogLine line) { }

	}

	[IsReadOnly]
	private struct VariableGroupKey : IEquatable
	{
		private readonly MongoID _variable; //Field offset: 0x0
		private readonly int _groupId; //Field offset: 0x18

		public VariableGroupKey(MongoID variable, int groupId) { }

		public override bool Equals(VariableGroupKey other) { }

		public virtual bool Equals(object otherObject) { }

		public virtual int GetHashCode() { }

	}

	[CompilerGenerated]
	private Action OnDialogChanged; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnActionFinished; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnBlockDialog; //Field offset: 0x20
	private readonly Profile _profile; //Field offset: 0x28
	protected readonly QuestController questController; //Field offset: 0x30
	protected readonly InventoryController InventoryController; //Field offset: 0x38
	protected readonly Dictionary _globalSaveStates; //Field offset: 0x40
	private readonly Dictionary _localSaveStates; //Field offset: 0x48
	private readonly CompositeDisposable _dialogDisposable; //Field offset: 0x50
	protected readonly CompositeDisposable controllerDisposable; //Field offset: 0x58
	private Nullable _lastDialogId; //Field offset: 0x60
	private TraderInfo _trader; //Field offset: 0x80
	public readonly TraderDialogHistory History; //Field offset: 0x88
	[CompilerGenerated]
	private BaseTraderDialog <CurrentDialog>k__BackingField; //Field offset: 0x90
	private readonly Dictionary _randomByVariableGroup; //Field offset: 0x98
	private ETraderServiceType _selectedServiceType; //Field offset: 0xA0
	private string _selectedSubServiceId; //Field offset: 0xA8
	[CompilerGenerated]
	private BaseTraderDialogLine <LastNpcLine>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private int <SelectedRandomGroup>k__BackingField; //Field offset: 0xB8

	public event Action OnActionFinished
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnBlockDialog
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnDialogChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private override BaseTraderDialog CurrentDialog
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private override InventoryController EFT.Dialogs.IDialogContext.InventoryController
	{
		private get { } //Length: 5
	}

	private override Profile EFT.Dialogs.IDialogContext.Profile
	{
		private get { } //Length: 5
	}

	private override QuestController EFT.Dialogs.IDialogContext.QuestController
	{
		private get { } //Length: 76
	}

	private override IEnumerable EFT.Dialogs.IDialogContext.QuestsData
	{
		private get { } //Length: 30
	}

	private override ETraderServiceType EFT.Dialogs.IDialogContext.SelectedServiceType
	{
		private get { } //Length: 7
	}

	private override string EFT.Dialogs.IDialogContext.SelectedSubServiceId
	{
		private get { } //Length: 8
	}

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.ServicesData
	{
		private get { } //Length: 61
	}

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.TaskConditionCounters
	{
		private get { } //Length: 30
	}

	private override TraderInfo EFT.Dialogs.IDialogContext.Trader
	{
		private get { } //Length: 8
	}

	private override Dictionary EFT.Dialogs.IDialogContext.TradersInfo
	{
		private get { } //Length: 30
	}

	public IReadOnlyDictionary GlobalSaveStates
	{
		 get { } //Length: 5
	}

	public BaseTraderDialogLine LastNpcLine
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override int SelectedRandomGroup
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private Dictionary ServicesData
	{
		private get { } //Length: 61
	}

	public TraderInfo Trader
	{
		 get { } //Length: 8
		 set { } //Length: 724
	}

	protected BaseTraderDialogController(Profile profile, QuestController questController, InventoryController inventoryController) { }

	[CompilerGenerated]
	private void <.ctor>b__0_0() { }

	[CompilerGenerated]
	public void add_OnActionFinished(Action value) { }

	[CompilerGenerated]
	public override void add_OnBlockDialog(Action value) { }

	[CompilerGenerated]
	public void add_OnDialogChanged(Action value) { }

	protected static BaseTraderDialog AssembleDialog(IDialogContext context, MongoID dialogId, Nullable startingPoint = null) { }

	private static Option CheckDialogTransition(MongoID traderId, MongoID dialogId, IDialogContext context) { }

	private void ClearPerDialogState() { }

	protected override void ClearTempData() { }

	public override void Dispose() { }

	private override void EFT.Dialogs.IDialogContext.ClearTempData() { }

	private override InventoryController EFT.Dialogs.IDialogContext.get_InventoryController() { }

	private override Profile EFT.Dialogs.IDialogContext.get_Profile() { }

	private override QuestController EFT.Dialogs.IDialogContext.get_QuestController() { }

	private override IEnumerable EFT.Dialogs.IDialogContext.get_QuestsData() { }

	private override ETraderServiceType EFT.Dialogs.IDialogContext.get_SelectedServiceType() { }

	private override string EFT.Dialogs.IDialogContext.get_SelectedSubServiceId() { }

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.get_ServicesData() { }

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.get_TaskConditionCounters() { }

	private override TraderInfo EFT.Dialogs.IDialogContext.get_Trader() { }

	private override Dictionary EFT.Dialogs.IDialogContext.get_TradersInfo() { }

	private override int EFT.Dialogs.IDialogContext.GetRandomValue(RandomLineCondition condition) { }

	private override void EFT.Dialogs.IDialogContext.SelectSubService(DialogSelectSubServiceAction selectSubServiceAction) { }

	private static OperationResult ExecuteDialogAction(IDialogContext context, ProgressDialogData dialogData, DialogAction dialogAction, bool simulate) { }

	protected void ForceQuitDialog() { }

	[CompilerGenerated]
	public override BaseTraderDialog get_CurrentDialog() { }

	public IReadOnlyDictionary get_GlobalSaveStates() { }

	[CompilerGenerated]
	public BaseTraderDialogLine get_LastNpcLine() { }

	[CompilerGenerated]
	public override int get_SelectedRandomGroup() { }

	private Dictionary get_ServicesData() { }

	public TraderInfo get_Trader() { }

	public OperationResult GetDialogProgressResult(ProgressDialogData progressDialogData) { }

	public override int GetVariableValue(MongoID variableId) { }

	private static OperationResult HandoverItem(IDialogContext context, ProgressDialogData dialogData, DialogHandoverItemAction handoverAction, bool simulate) { }

	protected Option InitNewDialog(MongoID traderId, MongoID dialogId) { }

	protected void InvokeActionFinished(DialogAction dialogAction) { }

	protected void InvokeDialogBlock(bool isBlocked) { }

	protected override void OnExecuteLineHandler(BaseTraderDialogLine line) { }

	private void OnProfileVariableChanged(MongoID variableId, int value) { }

	public OperationResult ProgressDialog(ProgressDialogData dialogData, bool simulate) { }

	private static OperationResult PurchaseService(IDialogContext context, DialogPurchaseServiceAction dialogPurchaseServiceAction, bool simulate) { }

	public void RedrawDialog(bool forced = false) { }

	[CompilerGenerated]
	public void remove_OnActionFinished(Action value) { }

	[CompilerGenerated]
	public override void remove_OnBlockDialog(Action value) { }

	[CompilerGenerated]
	public void remove_OnDialogChanged(Action value) { }

	protected override void ServiceUpdateHandler() { }

	[CompilerGenerated]
	private void set_CurrentDialog(BaseTraderDialog value) { }

	[CompilerGenerated]
	protected void set_LastNpcLine(BaseTraderDialogLine value) { }

	[CompilerGenerated]
	public override void set_SelectedRandomGroup(int value) { }

	protected void set_Trader(TraderInfo value) { }

	protected override void SetCurrentDialog(BaseTraderDialog dialog) { }

	public override void SetVariableValue(SaveStateData saveData) { }

}

