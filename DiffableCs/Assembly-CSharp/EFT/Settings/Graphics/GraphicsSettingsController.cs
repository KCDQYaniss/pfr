namespace EFT.Settings.Graphics;

public sealed class GraphicsSettingsController : BaseSettingsController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__59_0; //Field offset: 0x8
		public static Action <>9__61_0; //Field offset: 0x10
		public static Action <>9__62_0; //Field offset: 0x18
		public static Action <>9__63_0; //Field offset: 0x20
		public static Action <>9__66_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <CheckAltEnterFromWindow>b__61_0(Task _) { }

		internal void <CheckAltEnterToWindow>b__62_0(Task _) { }

		internal void <CheckAltTab>b__59_0(Task _) { }

		internal void <DisplayOffCoroutine>b__66_0(Task _) { }

		internal void <ValidateWindowMaxSize>b__63_0(Task _) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__ChangedShadowQuality; //Field offset: 0x0
		public static Action <1>__ChangeLodBias; //Field offset: 0x8
		public static Action <2>__ChangeAnisotropicFiltering; //Field offset: 0x10
		public static Action <3>__ChangeHighQualityColor; //Field offset: 0x18
		public static Action <4>__RefreshSdMode; //Field offset: 0x20
		public static Action <5>__HandleFinishedTask; //Field offset: 0x28

	}

	[CompilerGenerated]
	private struct <ApplyDisplaySettings>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftDisplaySettings settings; //Field offset: 0x20
		public GraphicsSettingsController <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeMode>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftDisplaySettings settings; //Field offset: 0x20
		private EftResolution <resolution>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeResolution>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftDisplaySettings settings; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateBindingsAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GraphicsSettingsController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisplayOffCoroutine>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GraphicsSettingsController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SwitchDisplayExclusiveFullScreenMode>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftDisplaySettings settings; //Field offset: 0x20
		public DisplayInfo displayInfo; //Field offset: 0x38
		private FullScreenMode <mode>5__2; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private TaskAwaiter <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SwitchDisplayFullScreenMode>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftDisplaySettings settings; //Field offset: 0x20
		public DisplayInfo displayInfo; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SwitchDisplayWindowMode>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftDisplaySettings settings; //Field offset: 0x20
		public DisplayInfo displayInfo; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float CheckDelay = 1; //Field offset: 0x0
	public static int MinFramerateLimit; //Field offset: 0x0
	public static int MaxFramerateLobbyLimit; //Field offset: 0x4
	public static int MaxFramerateGameLimit; //Field offset: 0x8
	public static float MinSharpening; //Field offset: 0xC
	public static float MaxSharpening; //Field offset: 0x10
	private static float MipStreamingMemoryBudget; //Field offset: 0x14
	private static int StreamingMipmapsMaxLevelReduction; //Field offset: 0x18
	[CompilerGenerated]
	private static int <SDModeLevel>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private static bool <ApplySDModeOnRuntime>k__BackingField; //Field offset: 0x20
	private bool _bindingsCreated; //Field offset: 0x28
	private FullScreenMode _lastMode; //Field offset: 0x2C
	private float _lastCheckTime; //Field offset: 0x30
	private Task _displayOffCheck; //Field offset: 0x38
	private bool _userVSync; //Field offset: 0x40
	private int _userTargetFrameRate; //Field offset: 0x44
	private ENvidiaReflexMode _userReflexMode; //Field offset: 0x48
	private bool _didDisableReflex; //Field offset: 0x4C
	private List _displaysLayout; //Field offset: 0x50
	private List _displaysLayoutA; //Field offset: 0x58
	private List _displaysLayoutB; //Field offset: 0x60

	private static TimeSpan ApplyDelay
	{
		private get { } //Length: 137
	}

	public static bool ApplySDModeOnRuntime
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static bool IsMipStreamingEnabled
	{
		 get { } //Length: 3
	}

	public static int SDModeLevel
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	private static GraphicsSettingsController() { }

	public GraphicsSettingsController() { }

	[CompilerGenerated]
	private void <CreateBindingsAsync>b__28_0(int x) { }

	[AsyncStateMachine(typeof(<ApplyDisplaySettings>d__29))]
	public Task ApplyDisplaySettings(EftDisplaySettings settings) { }

	private void ApplyQualityPreset(Nullable quality) { }

	private static void ChangeAnisotropicFiltering(AnisotropicFiltering value) { }

	private static void ChangedShadowQuality(int value) { }

	public void ChangeFramerate(bool inSession) { }

	public static void ChangeHighQualityColor(bool value) { }

	private static void ChangeLodBias(float bias) { }

	private void ChangeMipStreaming(bool value) { }

	[AsyncStateMachine(typeof(<ChangeMode>d__35))]
	private static Task ChangeMode(EftDisplaySettings settings) { }

	[AsyncStateMachine(typeof(<ChangeResolution>d__36))]
	private static Task ChangeResolution(EftDisplaySettings settings) { }

	private void ChangeTexturesQuality(bool mipStreamingIsOn, int quality) { }

	private void ChangeVSync(bool value) { }

	public void CheckAltEnter() { }

	private void CheckAltEnterFromWindow() { }

	private void CheckAltEnterToWindow() { }

	public void CheckAltTab() { }

	private void CheckDisplayOff() { }

	protected virtual void CreateBindings() { }

	[AsyncStateMachine(typeof(<CreateBindingsAsync>d__28))]
	private Task CreateBindingsAsync() { }

	public void DisableVSyncForced() { }

	[AsyncStateMachine(typeof(<DisplayOffCoroutine>d__66))]
	private Task DisplayOffCoroutine() { }

	public void EnableVSyncForced() { }

	private static TimeSpan get_ApplyDelay() { }

	[CompilerGenerated]
	public static bool get_ApplySDModeOnRuntime() { }

	public static bool get_IsMipStreamingEnabled() { }

	[CompilerGenerated]
	public static int get_SDModeLevel() { }

	public static float IncreaseMemoryBudgetForIcon() { }

	private static void RefreshSdMode(bool isActive) { }

	public void RefreshStreamingMemoryBudget(Vector4 budgets, Nullable quality = null) { }

	public static void RestoreMemoryBudget() { }

	[CompilerGenerated]
	public static void set_ApplySDModeOnRuntime(bool value) { }

	[CompilerGenerated]
	public static void set_SDModeLevel(int value) { }

	public static void SetFramerateLimits(FramerateLimitSettings framerateLimit) { }

	public void SetMipStreaming(bool value) { }

	public virtual GraphicsSettingsGroup SettingsGroupFactory() { }

	private static Task SwitchDisplay(EftDisplaySettings settings, DisplayInfo displayInfo) { }

	private static Task SwitchDisplay(EftDisplaySettings settings) { }

	[AsyncStateMachine(typeof(<SwitchDisplayExclusiveFullScreenMode>d__33))]
	private static Task SwitchDisplayExclusiveFullScreenMode(EftDisplaySettings settings, DisplayInfo displayInfo) { }

	[AsyncStateMachine(typeof(<SwitchDisplayFullScreenMode>d__34))]
	private static Task SwitchDisplayFullScreenMode(EftDisplaySettings settings, DisplayInfo displayInfo) { }

	[AsyncStateMachine(typeof(<SwitchDisplayWindowMode>d__32))]
	private static Task SwitchDisplayWindowMode(EftDisplaySettings settings, DisplayInfo displayInfo) { }

	private static void UpdateWindowMaxSize(ref EftDisplaySettings settings) { }

	private bool ValidateWindowMaxSize() { }

}

