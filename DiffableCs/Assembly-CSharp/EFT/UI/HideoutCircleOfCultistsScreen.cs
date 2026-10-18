namespace EFT.UI;

[UsedImplicitly]
public sealed class HideoutCircleOfCultistsScreen : AbstractHideoutAreaTransferItemsScreen
{
	[CompilerGenerated]
	private struct <TryDonateItems>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCircleOfCultistsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class HideoutCircleOfCultistsScreenController : BaseHideoutAreaTransferItemsScreenController
	{

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public HideoutCircleOfCultistsScreenController(AreaData areaData, IEftSession session, InventoryController inventoryController) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	[SerializeField]
	private DefaultUIButton _donateButton; //Field offset: 0x160
	private BaseHideoutScheme _productionScheme; //Field offset: 0x168
	private ItemsProducerBase _producer; //Field offset: 0x170
	private bool _canSendFinishCraftRequest; //Field offset: 0x178

	public HideoutCircleOfCultistsScreen() { }

	[CompilerGenerated]
	private void <Show>b__6_0() { }

	[CompilerGenerated]
	private void <Show>b__6_1() { }

	protected virtual void Awake() { }

	private void FinishProduction() { }

	private void OnDonateButtonClick() { }

	private void OnItemAdded(AddItemEventArgs addInfo) { }

	private void OnItemRemoved(RemoveItemEventArgs removeInfo) { }

	private void SetInteractivityAndFinishCraft() { }

	public virtual void Show(HideoutCircleOfCultistsScreenController controller) { }

	[AsyncStateMachine(typeof(<TryDonateItems>d__13))]
	private Task TryDonateItems() { }

	private void UpdateDonateButtonBlock() { }

}

