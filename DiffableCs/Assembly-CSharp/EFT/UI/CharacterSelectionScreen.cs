namespace EFT.UI;

public sealed class CharacterSelectionScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public CharacterSelectionSlotViewBase slotView; //Field offset: 0x10
		public CharacterSelectionScreenController controller; //Field offset: 0x18
		public CharacterSelectionSlotViewSeason seasonSlotView; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <ShowSlot>b__0() { }

		internal void <ShowSlot>b__1() { }

		internal void <ShowSlot>b__2() { }

	}

	[IsReadOnly]
	internal struct CharacterSelectionResult
	{
		public readonly EGameMode GameMode; //Field offset: 0x0
		public readonly CharacterSelectionProfileData ProfileData; //Field offset: 0x8
		public readonly bool Cancelled; //Field offset: 0x10

		public CharacterSelectionResult(EGameMode gameMode, CharacterSelectionProfileData profileData, bool cancelled) { }

	}

	internal sealed class CharacterSelectionScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <BackAsync>d__51 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public CharacterSelectionScreenController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <SubmitAsync>d__53 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public CharacterSelectionProfileData profileData; //Field offset: 0x20
			public CharacterSelectionScreenController <>4__this; //Field offset: 0x28
			public EGameMode gameMode; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private readonly bool <StartupFlow>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private readonly bool <CanGoBack>k__BackingField; //Field offset: 0x59
		[CompilerGenerated]
		private readonly string <ProfileId>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private readonly Nullable <CurrentGameMode>k__BackingField; //Field offset: 0x68
		private readonly TaskCompletionSource _completion; //Field offset: 0x70
		[CompilerGenerated]
		private CharacterSelectionDataResponse <Data>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private readonly SeasonalPerksData <SeasonalPerks>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private readonly ExtensionsSettings <ExpansionsSettings>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private bool <Reloading>k__BackingField; //Field offset: 0x90

		public bool AwaitingSelection
		{
			 get { } //Length: 173
		}

		public bool CanGoBack
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Task CompletionTask
		{
			 get { } //Length: 66
		}

		public Nullable CurrentGameMode
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public private CharacterSelectionDataResponse Data
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public ExtensionsSettings ExpansionsSettings
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public string ProfileId
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public private bool Reloading
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public SeasonalPerksData SeasonalPerks
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		protected virtual EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		public bool StartupFlow
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public CharacterSelectionScreenController(CharacterSelectionDataResponse data, bool startupFlow, string profileId, Nullable currentGameMode, SeasonalPerksData seasonalPerks = null, ExtensionsSettings expansionsSettings = null, bool canGoBack = false) { }

		public void Back() { }

		[AsyncStateMachine(typeof(<BackAsync>d__51))]
		private Task BackAsync() { }

		public void CancelForReload() { }

		public bool get_AwaitingSelection() { }

		[CompilerGenerated]
		public bool get_CanGoBack() { }

		public Task get_CompletionTask() { }

		[CompilerGenerated]
		public Nullable get_CurrentGameMode() { }

		[CompilerGenerated]
		public CharacterSelectionDataResponse get_Data() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		[CompilerGenerated]
		public ExtensionsSettings get_ExpansionsSettings() { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public string get_ProfileId() { }

		[CompilerGenerated]
		public bool get_Reloading() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public SeasonalPerksData get_SeasonalPerks() { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		[CompilerGenerated]
		public bool get_StartupFlow() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		private static string GetPurchaseUrl(ExtensionsSettings extensionsSettings, EGameMode gameMode) { }

		public void OpenSeasonIntro() { }

		public void OpenShop(EGameMode gameMode) { }

		public void RefreshData(CharacterSelectionDataResponse data) { }

		[CompilerGenerated]
		private void set_Data(CharacterSelectionDataResponse value) { }

		[CompilerGenerated]
		private void set_Reloading(bool value) { }

		public void SetReloading(bool reloading) { }

		public void Submit(EGameMode gameMode, CharacterSelectionProfileData profileData) { }

		[AsyncStateMachine(typeof(<SubmitAsync>d__53))]
		private Task SubmitAsync(EGameMode gameMode, CharacterSelectionProfileData profileData) { }

	}

	private const string TITLE_KEY = "CharacterSelectionScreen/Title"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _title; //Field offset: 0xA0
	[SerializeField]
	private CharacterSelectionSlotViewBase _pveSlotView; //Field offset: 0xA8
	[SerializeField]
	private CharacterSelectionSlotViewBase _pvpSlotView; //Field offset: 0xB0
	[SerializeField]
	private CharacterSelectionSlotViewBase _seasonSlotView; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xC0

	public CharacterSelectionScreen() { }

	public virtual void Close() { }

	private void CloseSlots() { }

	private static bool IsCurrentProfile(EGameMode gameMode, CharacterSelectionProfileData profileData, CharacterSelectionScreenController controller) { }

	public void Redraw(CharacterSelectionScreenController controller) { }

	public void SetSlotsInteractable(bool interactable) { }

	public virtual void Show(CharacterSelectionScreenController controller) { }

	private void ShowSlot(CharacterSelectionSlotViewBase slotView, EGameMode gameMode, CharacterSelectionProfileData profileData, CharacterSelectionScreenController controller) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

