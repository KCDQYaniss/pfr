namespace EFT.UI;

public sealed class SeasonalPersonalPerksState : EftScreenState
{
	[CompilerGenerated]
	private struct <ShowState>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonalPersonalPerksState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryConfirmSelectionAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonalPersonalPerksState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Color GoodColor; //Field offset: 0x0
	private const string PERSONAL_SCREEN_TITLE = "Perks/Season/Personal/Title"; //Field offset: 0x0
	private const string PERSONAL_SCREEN_DESCRIPTION = "Perks/Season/Personal/Description"; //Field offset: 0x0
	private const string PERSONAL_SCREEN_WARNING = "Perks/Season/Personal/Warning"; //Field offset: 0x0
	private const string PERSONAL_CONFIRM_TITLE = "Perks/Season/Personal/Confirm/Title"; //Field offset: 0x0
	private const string PERSONAL_CONFIRM_DESCRIPTION = "Perks/Season/Personal/Confirm/Description"; //Field offset: 0x0
	private const string PERSONAL_RESET_BUTTON = "Perks/Season/Personal/Reset"; //Field offset: 0x0
	private static readonly Color BadColor; //Field offset: 0x10
	[SerializeField]
	private TextMeshProUGUI _title; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _points; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _resetButton; //Field offset: 0xA8
	[SerializeField]
	private SeasonalPersonalPerkView _perkTemplate; //Field offset: 0xB0
	[SerializeField]
	private Transform _negativePerksContainer; //Field offset: 0xB8
	[SerializeField]
	private Transform _positivePerksContainer; //Field offset: 0xC0
	private readonly List _selectedPerks; //Field offset: 0xC8
	private IEnumerable _allPerks; //Field offset: 0xD0
	private readonly Dictionary _perkViewIndex; //Field offset: 0xD8
	private UiElementPool _positivePerkViews; //Field offset: 0xE0
	private UiElementPool _negativePerkViews; //Field offset: 0xE8
	private IImageLoader _imageLoader; //Field offset: 0xF0
	private PreliminaryProfileData _profileData; //Field offset: 0xF8
	private int _pointsBalance; //Field offset: 0x100

	public virtual string NextButtonDisabledTooltip
	{
		 get { } //Length: 121
	}

	public virtual bool ShowNextButtonWhenNotReady
	{
		 get { } //Length: 3
	}

	private static SeasonalPersonalPerksState() { }

	public SeasonalPersonalPerksState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	public void ApplyToProfileData(PreliminaryProfileData profileData) { }

	public virtual void Close() { }

	public virtual string get_NextButtonDisabledTooltip() { }

	public virtual bool get_ShowNextButtonWhenNotReady() { }

	public void Init(IImageLoader imageLoader, PreliminaryProfileData profileData) { }

	private void RebuildSelectionState() { }

	private void RecalculatePoints() { }

	private void RefreshStaticTexts() { }

	private void RefreshViews() { }

	private void ResetSelection() { }

	private void RestoreProfileSelection() { }

	private void ShowPerk(PersonalPerk perk) { }

	[AsyncStateMachine(typeof(<ShowState>d__28))]
	public virtual Task ShowState() { }

	private void TogglePerkSelection(PersonalPerk perk) { }

	[AsyncStateMachine(typeof(<TryConfirmSelectionAsync>d__29))]
	public Task TryConfirmSelectionAsync() { }

}

