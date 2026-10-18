namespace EFT.UI;

public class OverallStatsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8
		public static Func <>9__21_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__21_0(Profile p) { }

		internal bool <Show>b__21_1(Profile p) { }

	}

	internal enum EStatType
	{
		Overall = 0,
		Pmc = 1,
		Scav = 2,
		Arena = 3,
	}

	[SerializeField]
	private CustomTextMeshProUGUI _raidsLabel; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _runsLabel; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _survivedLabel; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _survivalRate; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _kiaLabel; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _averageLifetimeLabel; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _miaLabel; //Field offset: 0xA0
	[SerializeField]
	private CustomTextMeshProUGUI _rowSLabel; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI _awolLabel; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _leaveRateLabel; //Field offset: 0xB8
	[SerializeField]
	private CustomTextMeshProUGUI _killsLabel; //Field offset: 0xC0
	[SerializeField]
	private CustomTextMeshProUGUI _kdRatioLabel; //Field offset: 0xC8
	[SerializeField]
	private LocalizedText _onlineTimeLabel; //Field offset: 0xD0
	[SerializeField]
	private LocalizedText _overallLifetimeLabel; //Field offset: 0xD8
	private CountersCollection _pmcStats; //Field offset: 0xE0
	private CountersCollection _scavStats; //Field offset: 0xE8
	private CountersCollection _overallStats; //Field offset: 0xF0
	private int _registrationDate; //Field offset: 0xF8
	private long _totalInGameTime; //Field offset: 0x100
	private bool _selfStats; //Field offset: 0x108

	public OverallStatsPanel() { }

	private static string AvgLifeTimeText(long seconds) { }

	private void FillStats(CountersCollection counters) { }

	private void SetOverallLifetime() { }

	public void Show(IEftSession session) { }

	public void Show(CountersCollection pmcStats, CountersCollection scavStats, CountersCollection overallStats, int regDate, long totalTime, bool selfStats) { }

	public void ToggleChangedHandler(EStatType statType, bool value) { }

}

