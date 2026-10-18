namespace EFT.Interactive;

public abstract class DialogEntryPointBase : InteractableObject
{
	[CompilerGenerated]
	private struct <LoadTraderLipSyncSo>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogEntryPointBase <>4__this; //Field offset: 0x20
		private IEasyAssets <easyAssets>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	protected EDialogEntryPoint _entryPoint; //Field offset: 0x48
	[SerializeField]
	protected ETraderType _dialogueOwner; //Field offset: 0x4C
	[SerializeField]
	protected string _actionNameLocaleKey; //Field offset: 0x50
	[SerializeField]
	protected bool _alwaysAvailable; //Field offset: 0x58
	[SerializeField]
	protected DialogEntryPointAttentionGrabbingNoise _attentionGrabbingNoise; //Field offset: 0x60
	[SerializeField]
	protected DialogMediaPresenter _dialogMediaPresenter; //Field offset: 0x68
	[SerializeField]
	protected TraderLipSyncSO _traderLipSyncSo; //Field offset: 0x70
	protected string _traderId; //Field offset: 0x78
	protected TraderInfo _targetTraderInfo; //Field offset: 0x80
	protected bool _isEnabled; //Field offset: 0x88

	public string ActionNameLocaleKey
	{
		 get { } //Length: 5
	}

	public DialogMediaPresenter DialogMediaMediaPresenter
	{
		 get { } //Length: 5
	}

	protected ETraderType DialogueOwner
	{
		 get { } //Length: 4
	}

	public EDialogEntryPoint EntryPoint
	{
		 get { } //Length: 4
	}

	public bool IsEnabled
	{
		 get { } //Length: 41
	}

	public string TraderId
	{
		 get { } //Length: 5
	}

	protected DialogEntryPointBase() { }

	public string get_ActionNameLocaleKey() { }

	public DialogMediaPresenter get_DialogMediaMediaPresenter() { }

	protected ETraderType get_DialogueOwner() { }

	public EDialogEntryPoint get_EntryPoint() { }

	public bool get_IsEnabled() { }

	public string get_TraderId() { }

	public override void Init(IEnumerable traders) { }

	[AsyncStateMachine(typeof(<LoadTraderLipSyncSo>d__23))]
	private Task LoadTraderLipSyncSo() { }

	protected bool TryGetDialogueOwnerTraderMongoId(out MongoID mongoId) { }

	protected abstract void UpdateAvailability() { }

	protected void UpdateMediaEnvironment(bool noiseEnabled) { }

}

