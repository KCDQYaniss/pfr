namespace EFT.UI;

public sealed class OverallScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Func <>9__16_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__16_0(Profile value) { }

		internal bool <Show>b__16_1(Profile value) { }

	}

	internal sealed class OverallTabController : UIElementTabController
	{
		private readonly IEftSession _session; //Field offset: 0x18
		private readonly Profile _currentProfile; //Field offset: 0x20
		private readonly Profile[] _allProfiles; //Field offset: 0x28
		private readonly CountersCollection _overallAccountStats; //Field offset: 0x30
		[CanBeNull]
		private readonly InventoryController _inventoryController; //Field offset: 0x38
		private readonly bool _isInMatching; //Field offset: 0x40
		private readonly bool _canSelectPrestigeDisplay; //Field offset: 0x41

		public OverallTabController(OverallScreen overallTab, IEftSession session, Profile currentProfile, Profile[] allProfiles, CountersCollection overallAccountStats, InventoryController inventoryController, bool isInMatching, bool canSelectPrestigeDisplay) { }

		public virtual void Show() { }

	}

	[CompilerGenerated]
	private Action OnBackButtonClick; //Field offset: 0x70
	private Profile[] _profiles; //Field offset: 0x78
	private Profile _pmcProfile; //Field offset: 0x80
	private Profile _scavProfile; //Field offset: 0x88
	private CountersCollection _overallStats; //Field offset: 0x90
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0x98
	[SerializeField]
	private UIAnimatedToggleSpawner _overallToggle; //Field offset: 0xA0
	[SerializeField]
	private UIAnimatedToggleSpawner _pmcToggle; //Field offset: 0xA8
	[SerializeField]
	private UIAnimatedToggleSpawner _scavToggle; //Field offset: 0xB0
	[SerializeField]
	private StatisticsSpawn _statsSpawn; //Field offset: 0xB8
	public InventoryPlayerModelWithStatsWindow PlayerModelWithStatsWindow; //Field offset: 0xC0
	public OverallStatsPanel OverallStatsPanel; //Field offset: 0xC8

	public event Action OnBackButtonClick
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public OverallScreen() { }

	[CompilerGenerated]
	private void <Awake>b__15_0(bool value) { }

	[CompilerGenerated]
	private void <Awake>b__15_1(bool value) { }

	[CompilerGenerated]
	private void <Awake>b__15_2(bool value) { }

	[CompilerGenerated]
	private void <Awake>b__15_3() { }

	[CompilerGenerated]
	public void add_OnBackButtonClick(Action value) { }

	private void Awake() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public void remove_OnBackButtonClick(Action value) { }

	private void Show(Profile currentProfile, IEftSession session, Profile[] allProfiles, CountersCollection overallAccountStats, InventoryController inventoryController, bool isInMatching, bool canSelectPrestigeDisplay) { }

	private void UpdateStatistics(EStatType statType, bool value) { }

}

