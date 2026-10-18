namespace EFT.UI;

public sealed class ObtainPrestigeScreen : StatedEftScreen
{
	[CompilerGenerated]
	private struct <HandleNextScreen>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObtainPrestigeScreen <>4__this; //Field offset: 0x20
		public IEftSession session; //Field offset: 0x28
		public InventoryController inventoryController; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAnotherState>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObtainPrestigeScreen <>4__this; //Field offset: 0x20
		public int stateIndex; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ObtainPrestigeScreenController : EftSequenceScreenController
	{
		public readonly InventoryController InventoryController; //Field offset: 0x60
		public readonly IEftSession Session; //Field offset: 0x68

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public ObtainPrestigeScreenController(InventoryController inventoryController, IEftSession session) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	private const float REFERENCE_BACKGROUND_WIDTH = 4280; //Field offset: 0x0
	private const int RECT_WIDTH = 1920; //Field offset: 0x0
	private const int OFFSET = 250; //Field offset: 0x0
	[SerializeField]
	private PrestigeConformationState _confirmationState; //Field offset: 0xC8
	[SerializeField]
	private PrestigeTransferItemsState _transferItemsState; //Field offset: 0xD0
	[SerializeField]
	private PrestigeObtainAnimationState _obtainAnimationState; //Field offset: 0xD8
	[SerializeField]
	private RectTransform _background; //Field offset: 0xE0
	[SerializeField]
	private float _animationDuration; //Field offset: 0xE8
	[SerializeField]
	private Ease _animationEase; //Field offset: 0xEC
	[Range(1, 20)]
	[SerializeField]
	private int _debugPrestigeLevel; //Field offset: 0xF0
	[SerializeField]
	private bool _debugAnimation; //Field offset: 0xF4
	[SerializeField]
	private EGameMode _debugGameMode; //Field offset: 0xF8
	private Tween _backgroundTween; //Field offset: 0x100
	private InventoryController _inventoryController; //Field offset: 0x108
	private IEftSession _session; //Field offset: 0x110
	private int _prestigeToOpen; //Field offset: 0x118

	public ObtainPrestigeScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(int stateIndex) { }

	[CompilerGenerated]
	private void <PrepareRegisteredStatesAsync>b__19_0() { }

	private void AnimateBackground(int stateIndex) { }

	private float CalculateAnimationTime(float backgroundWidth) { }

	private void HandleAnimationComplete() { }

	[AsyncStateMachine(typeof(<HandleNextScreen>d__26))]
	private Task HandleNextScreen() { }

	protected virtual Task PrepareRegisteredStatesAsync() { }

	private void SetScreenInteractable(bool interactable) { }

	public virtual void Show(ObtainPrestigeScreenController controller) { }

	[AsyncStateMachine(typeof(<Show>d__18))]
	private Task Show(InventoryController inventoryController, IEftSession session) { }

	[AsyncStateMachine(typeof(<ShowAnotherState>d__23))]
	protected virtual Task ShowAnotherState(int stateIndex) { }

	protected virtual void ShowNextScreen() { }

}

