namespace EFT.Hideout;

public sealed class HideoutScreenRear : EftAsyncScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_2; //Field offset: 0x8
		public static Func <>9__24_6; //Field offset: 0x10
		public static Action <>9__28_0; //Field offset: 0x18
		public static Func <>9__32_1; //Field offset: 0x20
		public static Func <>9__32_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <EnterSpecialAreaActionMode>b__28_0() { }

		internal bool <Show>b__24_2(AreaData data) { }

		internal bool <Show>b__24_6(KeyValuePair x) { }

		internal bool <UpdateAreasData>b__32_0(AreaData x) { }

		internal bool <UpdateAreasData>b__32_1(Requirement r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public HideoutScreenRear <>4__this; //Field offset: 0x10
		public HideoutPlayerOwner playerOwner; //Field offset: 0x18
		public Action <>9__7; //Field offset: 0x20

		public <>c__DisplayClass24_0() { }

		internal void <Show>b__0(bool isEnabled) { }

		internal void <Show>b__1() { }

		internal AreaWorldPanel <Show>b__3(AreaData arg) { }

		internal Transform <Show>b__4(AreaData arg) { }

		internal void <Show>b__5(AreaData item, AreaWorldPanel view) { }

		internal void <Show>b__7(AreaPanel arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public HideoutScreenRear <>4__this; //Field offset: 0x10
		public AreaData selectedAreaData; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal void <ExitSpecialAreaActionMode>b__0() { }

	}

	[CompilerGenerated]
	private struct <Show>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutScreenRear <>4__this; //Field offset: 0x20
		public HideoutPlayerOwner playerOwner; //Field offset: 0x28
		public AreaData[] areaDatas; //Field offset: 0x30
		public IEftSession session; //Field offset: 0x38
		public bool firstPerson; //Field offset: 0x40
		public bool resetCameraPosition; //Field offset: 0x41
		public string ownerName; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutScreenRear <>4__this; //Field offset: 0x20
		public HideoutScreenController controller; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class HideoutScreenController : EftAsyncScreenController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			public EAreaType area; //Field offset: 0x10

			public <>c__DisplayClass30_0() { }

			internal bool <SelectArea>b__0(AreaData x) { }

		}

		[CompilerGenerated]
		private struct <SelectArea>d__30 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public EAreaType area; //Field offset: 0x20
			public HideoutScreenController <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal bool FirstPerson; //Field offset: 0x58
		public readonly AreaData[] AreaDatas; //Field offset: 0x60
		public readonly HideoutPlayerOwner PlayerOwner; //Field offset: 0x68
		public readonly IEftSession Session; //Field offset: 0x70
		public readonly bool ResetCameraPosition; //Field offset: 0x78
		public readonly string OwnerName; //Field offset: 0x80

		protected virtual EStateSwitcher CameraBlur
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher IgnorePlayerInput
		{
			 get { } //Length: 3
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public HideoutScreenController(AreaData[] areaDatas, HideoutPlayerOwner playerOwner, IEftSession session, bool resetCameraPosition, string ownerName) { }

		protected virtual EStateSwitcher get_CameraBlur() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		protected virtual EStateSwitcher get_IgnorePlayerInput() { }

		public virtual bool get_KeyScreen() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

		[AsyncStateMachine(typeof(<SelectArea>d__30))]
		public Task SelectArea(EAreaType area, bool wait) { }

		protected virtual void ShowAction(HideoutScreenRear screen) { }

		public void UpdateEnvironmentSettings() { }

	}

	[SerializeField]
	private AreaWorldPanel _areaPanelTemplate; //Field offset: 0xA0
	[SerializeField]
	private Transform _areaIconsContainer; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _areaIconsContainerCanvasGroup; //Field offset: 0xB0
	[SerializeField]
	private HideoutScreenOverlay _hideoutScreenOverlay; //Field offset: 0xB8
	[SerializeField]
	private HideoutAreaQTEOverlay _hideoutAreaQTEScreen; //Field offset: 0xC0
	[SerializeField]
	private Dictionary _specialActionsScreens; //Field offset: 0xC8
	[SerializeField]
	private TMP_Text _hideoutText; //Field offset: 0xD0
	public HideoutCameraController HideoutCameraController; //Field offset: 0xD8
	private readonly List _areaWorldPanels; //Field offset: 0xE0
	private bool _dataSelected; //Field offset: 0xE8
	private BindableAsyncViewList _viewList; //Field offset: 0xF0
	private bool _firstPersonIconsVisibility; //Field offset: 0xF8
	private bool _firstPerson; //Field offset: 0xF9
	private AreaData[] _areaDatas; //Field offset: 0x100
	private HideoutPlayerOwner _playerOwner; //Field offset: 0x108
	private IEftSession _session; //Field offset: 0x110
	private TriggerColliderSearcher _triggerColliderSearcher; //Field offset: 0x118

	public bool Closed
	{
		 get { } //Length: 69
	}

	public bool FirstPerson
	{
		 get { } //Length: 8
		 set { } //Length: 54
	}

	public HideoutScreenRear() { }

	private void AreaSelectedByPlayer(HideoutArea area) { }

	public virtual void Close() { }

	public void CreateFakePlayerCollider(HideoutPlayer player) { }

	public void DestroyFakePlayerCollider() { }

	private void EnterHideoutMode(bool firstPerson, bool returnToFirstPerson, AreaData selectedArea = null) { }

	private void EnterSpecialAreaActionMode(EHideoutAreaSpecialAction specialAction, AreaData selectedAreaData) { }

	private void ExitSpecialAreaActionMode(EHideoutAreaSpecialAction specialAction, AreaData selectedAreaData) { }

	private void FadeAreaIconsContainer(bool selected) { }

	private void FocusSpecialActionCamera(AreaData data, bool selected) { }

	public bool get_Closed() { }

	public bool get_FirstPerson() { }

	private void NightVisionChangeHandler() { }

	public void ReturnToHideoutMode() { }

	public void set_FirstPerson(bool value) { }

	private void SetAreaIconsVisible(bool visible) { }

	public void SetPointOfView(bool firstPerson) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	[AsyncStateMachine(typeof(<Show>d__24))]
	private Task Show(AreaData[] areaDatas, HideoutPlayerOwner playerOwner, IEftSession session, bool firstPerson, bool resetCameraPosition = false, string ownerName = "") { }

	public virtual void Show(HideoutScreenController controller) { }

	[AsyncStateMachine(typeof(<ShowAsync>d__23))]
	public virtual Task ShowAsync(HideoutScreenController controller) { }

	private void ToggleInfoIcons() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

	private void UpdateAreaIconsVisibility() { }

	private void UpdateAreasData(bool _) { }

	public void UpdateFakePlayerCollider(float deltaTime) { }

}

