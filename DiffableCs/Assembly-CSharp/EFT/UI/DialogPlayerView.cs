namespace EFT.UI;

[UsedImplicitly]
public sealed class DialogPlayerView : UIElement, IDialogContext, ISaveStateStorage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public DialogLineTemplate line; //Field offset: 0x10
		public DialogPlayerView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <Redraw>b__0() { }

	}

	[SerializeField]
	[UsedImplicitly]
	private RectTransform _linesContainer; //Field offset: 0x70
	[SerializeField]
	[UsedImplicitly]
	private DialogPlayerLineView _lineTemplate; //Field offset: 0x78
	[SerializeField]
	[UsedImplicitly]
	private Button _closeButton; //Field offset: 0x80
	[SerializeField]
	[UsedImplicitly]
	private Button _resetTagsButton; //Field offset: 0x88
	[SerializeField]
	[UsedImplicitly]
	private Button _fromStartButton; //Field offset: 0x90
	private TraderDialogTemplate _dialog; //Field offset: 0x98
	private readonly Dictionary _storage; //Field offset: 0xA0
	private readonly Dictionary _lines; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnBlockDialog; //Field offset: 0xB0
	[CompilerGenerated]
	private ETraderServiceType <SelectedServiceType>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private string <SelectedSubServiceId>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private int <SelectedRandomGroup>k__BackingField; //Field offset: 0xC8
	private readonly Dictionary _randomVariables; //Field offset: 0xD0
	private readonly Dictionary _randomGroupValues; //Field offset: 0xD8

	public override event Action OnBlockDialog
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override BaseTraderDialog CurrentDialog
	{
		 get { } //Length: 62
	}

	private override InventoryController EFT.Dialogs.IDialogContext.InventoryController
	{
		private get { } //Length: 3
	}

	private override Profile EFT.Dialogs.IDialogContext.Profile
	{
		private get { } //Length: 3
	}

	private override QuestController EFT.Dialogs.IDialogContext.QuestController
	{
		private get { } //Length: 3
	}

	private override IEnumerable EFT.Dialogs.IDialogContext.QuestsData
	{
		private get { } //Length: 3
	}

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.ServicesData
	{
		private get { } //Length: 95
	}

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.TaskConditionCounters
	{
		private get { } //Length: 3
	}

	private override TraderInfo EFT.Dialogs.IDialogContext.Trader
	{
		private get { } //Length: 3
	}

	private override Dictionary EFT.Dialogs.IDialogContext.TradersInfo
	{
		private get { } //Length: 3
	}

	public override int SelectedRandomGroup
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private override ETraderServiceType SelectedServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override string SelectedSubServiceId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public DialogPlayerView() { }

	[CompilerGenerated]
	public override void add_OnBlockDialog(Action value) { }

	private void Clear() { }

	public override void ClearTempData() { }

	private override InventoryController EFT.Dialogs.IDialogContext.get_InventoryController() { }

	private override Profile EFT.Dialogs.IDialogContext.get_Profile() { }

	private override QuestController EFT.Dialogs.IDialogContext.get_QuestController() { }

	private override IEnumerable EFT.Dialogs.IDialogContext.get_QuestsData() { }

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.get_ServicesData() { }

	private override IReadOnlyDictionary EFT.Dialogs.IDialogContext.get_TaskConditionCounters() { }

	private override TraderInfo EFT.Dialogs.IDialogContext.get_Trader() { }

	private override Dictionary EFT.Dialogs.IDialogContext.get_TradersInfo() { }

	private override int EFT.Dialogs.IDialogContext.GetRandomValue(RandomLineCondition condition) { }

	private override void EFT.Dialogs.IDialogContext.SelectSubService(DialogSelectSubServiceAction selectSubServiceAction) { }

	private override int EFT.Dialogs.ISaveStateStorage.GetVariableValue(MongoID variableId) { }

	private override void EFT.Dialogs.ISaveStateStorage.SetVariableValue(SaveStateData saveData) { }

	public override BaseTraderDialog get_CurrentDialog() { }

	[CompilerGenerated]
	public override int get_SelectedRandomGroup() { }

	[CompilerGenerated]
	public override ETraderServiceType get_SelectedServiceType() { }

	[CompilerGenerated]
	public override string get_SelectedSubServiceId() { }

	private void GoToStartHandler() { }

	private void LineClickHandler(DialogLineTemplate line) { }

	private void Redraw() { }

	[CompilerGenerated]
	public override void remove_OnBlockDialog(Action value) { }

	private void ResetVariablesHandler() { }

	[CompilerGenerated]
	public override void set_SelectedRandomGroup(int value) { }

	[CompilerGenerated]
	private void set_SelectedServiceType(ETraderServiceType value) { }

	[CompilerGenerated]
	private void set_SelectedSubServiceId(string value) { }

	private void SetVariableValue(SaveStateData saveData) { }

	public void Show(TraderDialogTemplate dialog) { }

}

