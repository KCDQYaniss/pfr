namespace EFT.UI.Screens;

public class ScreenManager`1 : IScreenManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		private struct <<ToggleScreen>g__TryToggleScreen|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public <>c__DisplayClass29_0 <>4__this; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public ScreenManager <>4__this; //Field offset: 0x0
		public TScreenType screenType; //Field offset: 0x0
		public Action showAction; //Field offset: 0x0

		public <>c__DisplayClass29_0() { }

		[AsyncStateMachine(typeof(<<ToggleScreen>g__TryToggleScreen|0>d))]
		internal Task <ToggleScreen>g__TryToggleScreen|0() { }

	}

	[CompilerGenerated]
	private struct <CloseAllScreens>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ScreenManager <>4__this; //Field offset: 0x0
		public bool forced; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowScreenSequence>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IBaseScreenController[] controllers; //Field offset: 0x0
		public ScreenManager <>4__this; //Field offset: 0x0
		public bool rootFirstScreen; //Field offset: 0x0
		public bool queueLastScreen; //Field offset: 0x0
		private int <lastIndex>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal abstract class ScreenController`2 : IBaseScreenController, IScreenController
	{
		[CompilerGenerated]
		private struct <PrepareShow>d__64 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public ScreenController <>4__this; //Field offset: 0x0
			public EScreenState screenState; //Field offset: 0x0
			public bool forced; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <ShowScreenAsync>d__48 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public ScreenController <>4__this; //Field offset: 0x0
			public EScreenState screenState; //Field offset: 0x0
			public bool forced; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0
			private TaskAwaiter <>u__2; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <TryCloseScreen>d__66 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public EScreenOrder order; //Field offset: 0x0
			public bool forced; //Field offset: 0x0
			public ScreenController <>4__this; //Field offset: 0x0
			private bool <moveForward>5__2; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private Action OnClose; //Field offset: 0x0
		[CompilerGenerated]
		private Action OnCloseAndRelease; //Field offset: 0x0
		[CompilerGenerated]
		private Action OnShow; //Field offset: 0x0
		protected TScreen Screen; //Field offset: 0x0
		private bool _closed; //Field offset: 0x0
		private bool _disabled; //Field offset: 0x0
		private TaskCompletionSource _closeAwaiter; //Field offset: 0x0
		private TaskCompletionSource _screenShownAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		private bool <Queued>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private bool <Root>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private IBaseScreenController <PreviousScreen>k__BackingField; //Field offset: 0x0

		public override event Action OnClose
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnCloseAndRelease
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override event Action OnShow
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		private bool Active
		{
			private get { } //Length: 92
		}

		public private override bool Closed
		{
			 get { } //Length: 5
			private set { } //Length: 43
		}

		protected IBaseScreenController CurrentGlobalScreenController
		{
			 get { } //Length: 80
		}

		private override bool EFT.UI.Screens.IBaseScreenController<TScreenType>.Disabled
		{
			private set { } //Length: 4
		}

		private override IBaseScreenController EFT.UI.Screens.IBaseScreenController<TScreenType>.PreviousScreen
		{
			private get { } //Length: 5
		}

		private override IBaseScreenController EFT.UI.Screens.IBaseScreenController<TScreenType>.RootScreen
		{
			private get { } //Length: 25
		}

		public override bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected private IBaseScreenController PreviousScreen
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override bool Queued
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		protected override bool QueuePreviousScreen
		{
			 get { } //Length: 3
		}

		public private override bool Root
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public Task ScreenShownTask
		{
			 get { } //Length: 67
		}

		public abstract TScreenType ScreenType
		{
			 get { } //Length: 0
		}

		protected ScreenController`2() { }

		[CompilerGenerated]
		public override void add_OnClose(Action value) { }

		[CompilerGenerated]
		public void add_OnCloseAndRelease(Action value) { }

		[CompilerGenerated]
		public override void add_OnShow(Action value) { }

		protected override void CloseAction(bool moveForward) { }

		protected override void CloseAllWindows() { }

		protected override Task CloseCurrentScreen(bool forced) { }

		public override void CloseScreen() { }

		public override void CloseScreenForced() { }

		protected override Task CloseScreenInterruption(bool moveForward) { }

		public override Task CloseSelf(bool forced) { }

		protected override Task DisplayScreen() { }

		private override IBaseScreenController EFT.UI.Screens.IBaseScreenController<TScreenType>.get_PreviousScreen() { }

		private override IBaseScreenController EFT.UI.Screens.IBaseScreenController<TScreenType>.get_RootScreen() { }

		private override void EFT.UI.Screens.IBaseScreenController<TScreenType>.QueueScreen(EScreenState screenState) { }

		private override void EFT.UI.Screens.IBaseScreenController<TScreenType>.RestoreScreen() { }

		private override void EFT.UI.Screens.IBaseScreenController<TScreenType>.set_Disabled(bool value) { }

		private override void EFT.UI.Screens.IBaseScreenController<TScreenType>.ShowScreenAsPrevious() { }

		private bool get_Active() { }

		public override bool get_Closed() { }

		protected IBaseScreenController get_CurrentGlobalScreenController() { }

		public override bool get_KeyScreen() { }

		[CompilerGenerated]
		protected IBaseScreenController get_PreviousScreen() { }

		[CompilerGenerated]
		public override bool get_Queued() { }

		protected override bool get_QueuePreviousScreen() { }

		[CompilerGenerated]
		public override bool get_Root() { }

		public Task get_ScreenShownTask() { }

		public abstract TScreenType get_ScreenType() { }

		private IBaseScreenController GetPreviousScreen(EScreenOrder order) { }

		protected void InitScreen() { }

		private void InvokeCloseAndRelease() { }

		private void OnShowStart() { }

		protected override void PrepareEnvironment() { }

		[AsyncStateMachine(typeof(<PrepareShow>d__64))]
		private Task PrepareShow(EScreenState screenState, bool forced) { }

		private void QueueScreen(EScreenState screenState, bool simulate) { }

		protected void RegisterInput() { }

		[CompilerGenerated]
		public override void remove_OnClose(Action value) { }

		[CompilerGenerated]
		public void remove_OnCloseAndRelease(Action value) { }

		[CompilerGenerated]
		public override void remove_OnShow(Action value) { }

		public override Task ReturnToRootScreen() { }

		private void set_Closed(bool value) { }

		[CompilerGenerated]
		private void set_PreviousScreen(IBaseScreenController value) { }

		[CompilerGenerated]
		private void set_Queued(bool value) { }

		[CompilerGenerated]
		private void set_Root(bool value) { }

		protected override void ShowAction(TScreen screen) { }

		public override Task ShowPreviousKeyScreen() { }

		private void ShowPreviousScreen(EScreenOrder order) { }

		public override void ShowScreen(EScreenState screenState) { }

		protected override bool ShowScreenAsPrevious() { }

		[AsyncStateMachine(typeof(<ShowScreenAsync>d__48))]
		public override Task ShowScreenAsync(EScreenState screenState, bool forced = false) { }

		protected void Switch(EStateSwitcher switcher, Action action) { }

		protected void SwitchTaskBarButtons(EStateSwitcher switcher, Action action, string customTooltip = null) { }

		public override Task TryCloseScreen() { }

		[AsyncStateMachine(typeof(<TryCloseScreen>d__66))]
		private Task TryCloseScreen(bool forced, EScreenOrder order) { }

	}

	private static ScreenManager _privateInstance; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnScreenChanged; //Field offset: 0x0
	private readonly Dictionary _screens; //Field offset: 0x0
	private InputNode _inputNode; //Field offset: 0x0
	private IBaseScreenController _currentScreenController; //Field offset: 0x0

	public event Action OnScreenChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected override IBaseScreenController CurrentBaseScreenController
	{
		 get { } //Length: 5
		 set { } //Length: 203
	}

	public IScreenController CurrentScreenController
	{
		 get { } //Length: 5
	}

	private override Enum EFT.UI.Screens.IScreenManager.CurrentScreenType
	{
		private get { } //Length: 115
	}

	public TScreenType RootScreenType
	{
		 get { } //Length: 170
	}

	protected ScreenManager`1() { }

	[CompilerGenerated]
	public void add_OnScreenChanged(Action value) { }

	public bool CheckCurrentScreen(TScreenType screenType) { }

	[AsyncStateMachine(typeof(<CloseAllScreens>d__33))]
	private Task CloseAllScreens(bool forced) { }

	public override void CloseAllScreensForced() { }

	public void CloseCurrentScreenForced() { }

	private override Task EFT.UI.Screens.IScreenManager.CloseAllScreens(bool forced) { }

	private override Enum EFT.UI.Screens.IScreenManager.get_CurrentScreenType() { }

	protected override IBaseScreenController get_CurrentBaseScreenController() { }

	public IScreenController get_CurrentScreenController() { }

	public TScreenType get_RootScreenType() { }

	private void Init() { }

	private bool RegisterInput(TScreen screen) { }

	public void RegisterScreen(TScreenType screenType, BaseScreen screen) { }

	public void ReleaseScreen(TScreenType screenType, BaseScreen screen) { }

	[CompilerGenerated]
	public void remove_OnScreenChanged(Action value) { }

	protected override void set_CurrentBaseScreenController(IBaseScreenController value) { }

	public void SetInputNode(InputNode inputNode) { }

	[AsyncStateMachine(typeof(<ShowScreenSequence>d__28))]
	public Task ShowScreenSequence(bool rootFirstScreen, bool queueLastScreen, IBaseScreenController[] controllers) { }

	public void ToggleScreen(TScreenType screenType, Action showAction = null) { }

	public Task TryCloseAllScreens() { }

	private bool TryGetScreen(TScreenType screenType, out UIScreen screen) { }

	public Task TryReturnToKeyScreen() { }

	public Task TryReturnToRootScreen() { }

	private bool UnregisterInput(TScreen screen) { }

}

