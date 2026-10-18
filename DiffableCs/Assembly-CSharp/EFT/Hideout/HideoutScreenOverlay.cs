namespace EFT.Hideout;

public sealed class HideoutScreenOverlay : UIScreen
{
	[CompilerGenerated]
	private struct <<EnterHideoutMode>g__ChangeView|58_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutScreenOverlay <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__44_0; //Field offset: 0x8
		public static Func <>9__44_2; //Field offset: 0x10
		public static Func <>9__44_3; //Field offset: 0x18
		public static Func <>9__44_5; //Field offset: 0x20
		public static Func <>9__44_6; //Field offset: 0x28
		public static Func <>9__45_1; //Field offset: 0x30
		public static Func <>9__46_1; //Field offset: 0x38
		public static Func <>9__46_2; //Field offset: 0x40
		public static Func <>9__47_1; //Field offset: 0x48
		public static Func <>9__47_2; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal string <EnableCustomizationButton>b__45_1() { }

		internal string <EnableGeneratorButton>b__47_1() { }

		internal string <EnableGeneratorButton>b__47_2() { }

		internal string <EnableNightVisionButton>b__46_1() { }

		internal string <EnableNightVisionButton>b__46_2() { }

		internal bool <Show>b__44_0(AreaData data) { }

		internal string <Show>b__44_2() { }

		internal string <Show>b__44_3() { }

		internal string <Show>b__44_5() { }

		internal string <Show>b__44_6() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__ActionButtonClickedHandler; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <AreaSelected>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutScreenOverlay <>4__this; //Field offset: 0x20
		public bool wait; //Field offset: 0x28
		public AreaData data; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string NIGHT_VISION_TURN_ON = "hideout/Turn night vision on"; //Field offset: 0x0
	private const int GENERATOR_COOLDOWN = 10; //Field offset: 0x0
	private const string CUSTOMIZATION_BUTTON_TITLE = "Hideout/Customization/ScreenOverlayButtonTitle"; //Field offset: 0x0
	private const string HIDEOUT_WELCOME_MESSAGE = "hideout/Welcome"; //Field offset: 0x0
	private const string HIDEOUT_WELCOME_TITLE = "hideout/Welcome title"; //Field offset: 0x0
	private const float ZOOM_SPEED = 4; //Field offset: 0x0
	private const string GENERATOR_TURN_OFF = "hideout/Turn generator off"; //Field offset: 0x0
	private const string GENERATOR_TURN_ON = "hideout/Turn generator on"; //Field offset: 0x0
	private const string NIGHT_VISION_TURN_OFF = "hideout/Turn night vision off"; //Field offset: 0x0
	private const string GENERATOR_NOT_CONSTRUCTED = "hideout/Generator not constructed"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnReturnToHomeScreen; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnLightingLevelChanged; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnCustomizationPanelVisibilityChanged; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _enterHideoutButtonSpawner; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _returnToMenuButtonSpawner; //Field offset: 0xB0
	[SerializeField]
	private ComplementaryButton _nightVisionButton; //Field offset: 0xB8
	[SerializeField]
	private ComplementaryButton _generatorButton; //Field offset: 0xC0
	[SerializeField]
	private ComplementaryButton _customizationButton; //Field offset: 0xC8
	[SerializeField]
	private AreasPanel _areasPanel; //Field offset: 0xD0
	[SerializeField]
	private AreaScreenSubstrate _areaSubstrateTemplate; //Field offset: 0xD8
	[SerializeField]
	private RectTransform _areaScreenContainer; //Field offset: 0xE0
	[SerializeField]
	private ChangeLightButton _changeLightButton; //Field offset: 0xE8
	[SerializeField]
	private ChangeLightPanel _changeLightPanel; //Field offset: 0xF0
	[SerializeField]
	private HideoutCustomizationScreen _hideoutCustomizationPanelPrefab; //Field offset: 0xF8
	private HideoutCameraController _hideoutCameraController; //Field offset: 0x100
	private AreaScreenSubstrate _areaSubstrate; //Field offset: 0x108
	private HideoutPlayer _player; //Field offset: 0x110
	private IEftSession _session; //Field offset: 0x118
	private AreaData _selectedData; //Field offset: 0x120
	private HideoutScreenRear _hideoutRear; //Field offset: 0x128
	private float[] _lastAxes; //Field offset: 0x130
	private bool _canSelectArea; //Field offset: 0x138
	private bool _returnToFirstPerson; //Field offset: 0x139
	private EnergyController _energyController; //Field offset: 0x140
	private AreaData _generatorData; //Field offset: 0x148
	private HideoutCustomizationController _customizationController; //Field offset: 0x150
	private HideoutCustomizationScreen _customizationPanel; //Field offset: 0x158

	public event Action OnCustomizationPanelVisibilityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnLightingLevelChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnReturnToHomeScreen
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public HideoutScreenOverlay() { }

	[CompilerGenerated]
	private void <Awake>b__43_0(ELightingLevel lightingLevel) { }

	[CompilerGenerated]
	private void <EnableCustomizationButton>b__45_0(bool arg) { }

	[CompilerGenerated]
	private void <EnableGeneratorButton>b__47_0(bool arg) { }

	[CompilerGenerated]
	private void <EnableNightVisionButton>b__46_0(bool arg) { }

	[AsyncStateMachine(typeof(<<EnterHideoutMode>g__ChangeView|58_0>d))]
	[CompilerGenerated]
	private Task <EnterHideoutMode>g__ChangeView|58_0() { }

	[CompilerGenerated]
	private void <Show>b__44_1(AreaPanel arg) { }

	[CompilerGenerated]
	private void <Show>b__44_4(bool silent) { }

	[CompilerGenerated]
	private void <ShowCustomizationPanel>b__56_0() { }

	private static void ActionButtonClickedHandler(AreaData areaData) { }

	[CompilerGenerated]
	public void add_OnCustomizationPanelVisibilityChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnLightingLevelChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnReturnToHomeScreen(Action value) { }

	public void AddLightingLevel(ELightingLevel level, bool switchToNewLevel) { }

	[AsyncStateMachine(typeof(<AreaSelected>d__52))]
	public Task AreaSelected(AreaData data, bool wait) { }

	private void Awake() { }

	public void ClearLightLevels() { }

	public void Close() { }

	private void EnableCustomizationButton() { }

	private void EnableGeneratorButton() { }

	private void EnableNightVisionButton() { }

	private void EnterHideoutMode() { }

	private void OnGeneratorSwitched(bool isOn) { }

	[CompilerGenerated]
	public void remove_OnCustomizationPanelVisibilityChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnLightingLevelChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnReturnToHomeScreen(Action value) { }

	private void ReturnToHomeScreen() { }

	public void ReturnToPreviousState() { }

	public void SetCurrentLightingLevel(ELightingLevel level) { }

	private void SetSelectedArea(AreaData area) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(HideoutPlayerOwner player, bool returnToFirstPerson, IEftSession session, AreaData[] areaDatas, HideoutScreenRear hideoutRear) { }

	private void ShowCustomizationPanel() { }

	private void ToggleNightVision() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateNightVisionState() { }

}

