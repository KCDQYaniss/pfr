namespace EFT.UI.Settings;

public class ControlSettingsTab : SettingsTab
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__43_1; //Field offset: 0x8
		public static Func <>9__43_2; //Field offset: 0x10
		public static Func <>9__43_3; //Field offset: 0x18
		public static Func <>9__43_4; //Field offset: 0x20
		public static Func <>9__43_5; //Field offset: 0x28
		public static Func <>9__48_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <KeyChosen>b__48_0(InputSource variant) { }

		internal string <ShowBindings>b__43_1(EPressType pressType) { }

		internal EPressType <ShowBindings>b__43_2(EPressType pressType) { }

		internal bool <ShowBindings>b__43_3(EPressType x) { }

		internal string <ShowBindings>b__43_4(EPressType pressType) { }

		internal EPressType <ShowBindings>b__43_5(EPressType pressType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Token token; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal void <InitSpeaker>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnPhraseToldHandler; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <InitGestures>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ControlSettingsTab <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitSpeaker>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string voice; //Field offset: 0x20
		public ControlSettingsTab <>4__this; //Field offset: 0x28
		private <>c__DisplayClass53_0 <>8__1; //Field offset: 0x30
		public BaseSpeaker speaker; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private CommandKeyPair _commandKeyPairTemplate; //Field offset: 0x98
	[SerializeField]
	private CommandAxisPair _commandAxisPairTemplate; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _commandsContainer; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _sensitivityRoot; //Field offset: 0xB0
	[SerializeField]
	private RectTransform _invertAxisRoot; //Field offset: 0xB8
	[SerializeField]
	private SettingToggle _toggleTemplate; //Field offset: 0xC0
	[SerializeField]
	private SettingFloatSlider _selectFloatSliderTemplate; //Field offset: 0xC8
	[SerializeField]
	private SettingsTooltip _tooltip; //Field offset: 0xD0
	[SerializeField]
	[Space]
	private UIAnimatedToggleSpawner _controlButton; //Field offset: 0xD8
	[SerializeField]
	private UIAnimatedToggleSpawner _gesturesButton; //Field offset: 0xE0
	[SerializeField]
	[Space]
	private GameObject _controlPanel; //Field offset: 0xE8
	[SerializeField]
	private GameObject _gesturesPanel; //Field offset: 0xF0
	[SerializeField]
	private GesturesMenu _gesturesMenu; //Field offset: 0xF8
	private readonly List _bindingGameObjects; //Field offset: 0x100
	protected List _keyControls; //Field offset: 0x108
	protected List _axisControls; //Field offset: 0x110
	private ControlSettingsGroup _controlSettings; //Field offset: 0x118
	private SoundSettingsGroup _soundSettings; //Field offset: 0x120
	private readonly EGameKey[] _forbiddenKeys; //Field offset: 0x128
	private readonly EGameKey[] _notInteractableKeys; //Field offset: 0x130
	private readonly EAxis[] _forbiddenAxis; //Field offset: 0x138
	private GesturesCommandsStorage _gesturesStorage; //Field offset: 0x140
	private BaseSpeaker _speaker; //Field offset: 0x148
	private bool _gesturesReady; //Field offset: 0x150
	private ProfileInfo _profileInfo; //Field offset: 0x158
	private BodyCustomization _customization; //Field offset: 0x160
	private bool _isUiBlockersActive; //Field offset: 0x168
	private int _currentControlIndex; //Field offset: 0x16C
	[CompilerGenerated]
	private bool <CanPressEscape>k__BackingField; //Field offset: 0x170

	public private bool CanPressEscape
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ControlSettingsTab() { }

	[CompilerGenerated]
	private void <Awake>b__32_0(bool isOn) { }

	[CompilerGenerated]
	private void <CreateAxisBinding>b__47_0() { }

	[CompilerGenerated]
	private void <InitGestures>b__52_0(ValueTuple x) { }

	[CompilerGenerated]
	private bool <ShowBindings>b__43_0(AxisGroup x) { }

	[CompilerGenerated]
	private bool <ShowBindings>b__43_6(KeyGroup x) { }

	[CompilerGenerated]
	private void <ShowBindings>b__43_7() { }

	private void Awake() { }

	private void AxisChosen(AxisGroup axisGroup, InputSource input, bool positive) { }

	private void CleanUpBindingObjects() { }

	public virtual void Close() { }

	private void CreateAxisBinding(AxisGroup axis, bool positive) { }

	private void CreateControls() { }

	[CompilerGenerated]
	public bool get_CanPressEscape() { }

	private void HandleGesturesToggle(bool isOn) { }

	[AsyncStateMachine(typeof(<InitGestures>d__52))]
	private Task InitGestures() { }

	[AsyncStateMachine(typeof(<InitSpeaker>d__53))]
	private Task InitSpeaker(BaseSpeaker speaker, string voice) { }

	private bool KeyChosen(KeyGroup keyGroup, InputSource input, bool full) { }

	protected virtual void OnFirstSelect() { }

	private static void OnPhraseToldHandler(EPhraseTrigger arg1, TaggedClip clip, TagBank arg3, BaseSpeaker arg4) { }

	protected virtual void OnSelect() { }

	private void PlayPhrase(int item) { }

	private void RefreshBindingsOnLocaleUpdate() { }

	[CompilerGenerated]
	private void set_CanPressEscape(bool value) { }

	private static void SetLockGameObject(GameObject objectToLock, bool locked, string reason) { }

	public override void Show(ControlSettingsGroup controlSettings, SoundSettingsGroup soundSettings, GesturesCommandsStorage gesturesStorage, ProfileInfo profileInfo, BodyCustomization customization, bool isUiBlockersActive) { }

	protected override void ShowBindings() { }

	private void ShowDoubleClickTimeout() { }

	private void ShowInvertedX() { }

	private void ShowInvertedY() { }

	private void ShowMouseSensitivity() { }

	private void ShowMouseSensitivityAiming() { }

	private void ShowOpticSensitivity() { }

	public virtual Task TakeSettingsFrom(SettingsManager settingsManager) { }

}

