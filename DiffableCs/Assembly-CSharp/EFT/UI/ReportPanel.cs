namespace EFT.UI;

public sealed class ReportPanel : ButtonFeedback
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateCanvasGroupInteraction>b__15_0(KeyValuePair buttonStruct) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public EReportType reportType; //Field offset: 0x10
		public ReportButton buttonStruct; //Field offset: 0x18
		public ReportPanel <>4__this; //Field offset: 0x28

		public <>c__DisplayClass12_0() { }

		internal void <UpdateButtonsView>b__0() { }

		internal void <UpdateButtonsView>b__1() { }

	}

	private struct ReportButton
	{
		public Button Button; //Field offset: 0x0
		public CanvasGroup CanvasGroup; //Field offset: 0x8

	}

	[SerializeField]
	private EReportType _availableReports; //Field offset: 0xA8
	[SerializeField]
	private Dictionary _reportButtons; //Field offset: 0xB0
	[SerializeField]
	private Button _reportDropdownButton; //Field offset: 0xB8
	[SerializeField]
	private GameObject _reportDropdownPanel; //Field offset: 0xC0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xC8
	private bool _isOpen; //Field offset: 0xD0
	private IEftSession _session; //Field offset: 0xD8
	private string _reportAccountId; //Field offset: 0xE0

	public ReportPanel() { }

	[CompilerGenerated]
	private void <SendReport>b__14_0(IResult result) { }

	private void Awake() { }

	private void ChangeReportButtonsShowState() { }

	public virtual void Close() { }

	private void SendReport(EReportType reportType, CanvasGroup buttonCanvas) { }

	public void Show(IEftSession session, string reportAccountId) { }

	public void Show(IEftSession session, string reportAccountId, EReportType availableReports) { }

	private void Update() { }

	private void UpdateButtonsView(EReportType availableReports) { }

	private void UpdateCanvasGroupInteraction() { }

}

