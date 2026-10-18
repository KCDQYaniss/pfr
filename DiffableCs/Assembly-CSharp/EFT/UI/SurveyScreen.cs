namespace EFT.UI;

public sealed class SurveyScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ShowQuestionsPage>b__17_1(BaseSurveyQuestion question) { }

	}

	internal sealed class SurveyTabController : UIElementTabController
	{
		private readonly IEftSession _session; //Field offset: 0x18
		private readonly SurveyTemplate _survey; //Field offset: 0x20
		private Action _completeAction; //Field offset: 0x28
		private Action _showAction; //Field offset: 0x30

		public SurveyTabController(SurveyScreen surveyScreen, SurveyTemplate survey, IEftSession session, Action showAction, Action completeAction) { }

		public virtual void Show() { }

	}

	private IEftSession _session; //Field offset: 0x70
	private SurveyTemplate _survey; //Field offset: 0x78
	[SerializeField]
	private UIElement _noAvailableSurveyPage; //Field offset: 0x80
	[SerializeField]
	private SurveyWelcomePage _welcomePage; //Field offset: 0x88
	[SerializeField]
	private SurveyQuestionsPage _questionsPage; //Field offset: 0x90
	[SerializeField]
	private SurveyFarewellPage _farewellPage; //Field offset: 0x98
	private int _currentPageIndex; //Field offset: 0xA0
	private int _pagesCount; //Field offset: 0xA4
	private IPage _currentPage; //Field offset: 0xA8
	private Action _completeAction; //Field offset: 0xB0
	private readonly Dictionary _surveyQuestions; //Field offset: 0xB8

	public SurveyScreen() { }

	[CompilerGenerated]
	private void <ShowFarewellPage>b__16_0() { }

	[CompilerGenerated]
	private BaseSurveyQuestion <ShowQuestionsPage>b__17_0(int questionId) { }

	[CompilerGenerated]
	private void <SubscribeCurrentPage>b__15_0() { }

	private void ClearCurrentPage() { }

	public virtual void Close() { }

	private void CreateQuestions() { }

	private void HideAllPages() { }

	private void OnBackwardPageButtonPressed() { }

	private void OnForwardPageButtonPressed() { }

	private void SendAnswersToBackend() { }

	private void Show(SurveyTemplate surveyTemplate, IEftSession session, Action completeAction, Action showAction) { }

	private void ShowFarewellPage() { }

	private void ShowPage(int pageIndex) { }

	private void ShowQuestionsPage(int pageIndex) { }

	private void ShowWelcomePage() { }

	private void SubscribeCurrentPage() { }

}

