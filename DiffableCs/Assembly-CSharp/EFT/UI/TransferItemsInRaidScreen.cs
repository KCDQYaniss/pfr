namespace EFT.UI;

[UsedImplicitly]
public sealed class TransferItemsInRaidScreen : EftScreen
{
	[CompilerGenerated]
	private struct <ApplyTransferHandler>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TransferItemsInRaidScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class TransferItemsInRaidScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <CloseForcedAndReturnToRoot>d__27 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TransferItemsInRaidScreenController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__26 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TransferItemsInRaidScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <TryToRemoveAllFromCurrentItem>d__28 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TransferItemsInRaidScreenController <>4__this; //Field offset: 0x20
			public bool forced; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private readonly InsuranceCompany <Insurance>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private readonly Profile <Profile>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private readonly InventoryController <InventoryController>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private readonly QuestController <QuestController>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private readonly TransferItemsController <TransferController>k__BackingField; //Field offset: 0x78

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public InsuranceCompany Insurance
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public InventoryController InventoryController
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public Profile Profile
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public QuestController QuestController
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public TransferItemsController TransferController
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public TransferItemsInRaidScreenController(Profile profile, InventoryController inventoryController, QuestController questController, InsuranceCompany insurance, TransferItemsController transferController) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseForcedAndReturnToRoot>d__27))]
		public Task CloseForcedAndReturnToRoot() { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__26))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		[CompilerGenerated]
		public InsuranceCompany get_Insurance() { }

		[CompilerGenerated]
		public InventoryController get_InventoryController() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public Profile get_Profile() { }

		[CompilerGenerated]
		public QuestController get_QuestController() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		public TransferItemsController get_TransferController() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

		[AsyncStateMachine(typeof(<TryToRemoveAllFromCurrentItem>d__28))]
		private Task TryToRemoveAllFromCurrentItem(bool forced) { }

	}

	private const string TRANSFER_SCREEN_TRANSFER_SUCCESS = "TransferScreen/TransferSuccess"; //Field offset: 0x0
	private const string TRANSFER_SCREEN_TRANSFER_FAILED = "TransferScreen/TransferFailed"; //Field offset: 0x0
	private const string BTR_CAUTION = "TransferScreen/BtrCaution"; //Field offset: 0x0
	[SerializeField]
	private EquipmentTab _equipmentPanel; //Field offset: 0xA0
	[SerializeField]
	private ContainersPanel _containersPanel; //Field offset: 0xA8
	[SerializeField]
	private TransferItemsPanel _transferItemsPanel; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _closeScreenButton; //Field offset: 0xB8
	private InventoryController _inventoryController; //Field offset: 0xC0
	private Profile _profile; //Field offset: 0xC8
	private SkillManager _skills; //Field offset: 0xD0
	private InsuranceCompany _insurance; //Field offset: 0xD8
	private ItemUiContext _itemUiContext; //Field offset: 0xE0
	private Inventory _inventory; //Field offset: 0xE8
	private bool _purchased; //Field offset: 0xF0
	private QuestController _questController; //Field offset: 0xF8
	private Stash _transferStash; //Field offset: 0x100
	private TransferItemsController _transferController; //Field offset: 0x108

	public TransferItemsInRaidScreen() { }

	[CompilerGenerated]
	private void <Show>b__19_0() { }

	[AsyncStateMachine(typeof(<ApplyTransferHandler>d__21))]
	private void ApplyTransferHandler() { }

	public virtual void Close() { }

	private void CloseScreen() { }

	private void OnCautionStateHandler() { }

	public virtual void Show(TransferItemsInRaidScreenController controller) { }

	private void Show(InventoryController inventoryController, QuestController questController, Profile profile, InsuranceCompany insurance, TransferItemsController transferController) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

