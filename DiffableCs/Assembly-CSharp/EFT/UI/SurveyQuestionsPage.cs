namespace EFT.UI;

public sealed class SurveyQuestionsPage : SurveyPage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetSendButtonBlocker>b__9_0(BaseSurveyQuestion q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BaseSurveyQuestion question; //Field offset: 0x10
		public SurveyQuestionsPage <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__1() { }

	}

	[SerializeField]
	private QuestionView _questionViewTemplate; //Field offset: 0x90
	[SerializeField]
	private Transform _questionsRoot; //Field offset: 0x98
	[SerializeField]
	private RectTransform _questionsViewport; //Field offset: 0xA0
	[SerializeField]
	private LayoutElement _questionsContent; //Field offset: 0xA8
	[SerializeField]
	private Scrollbar _scrollbar; //Field offset: 0xB0
	[SerializeField]
	private UiElementBlocker _sendButtonBlocker; //Field offset: 0xB8
	private readonly List _questionViews; //Field offset: 0xC0
	private List _questions; //Field offset: 0xC8

	public SurveyQuestionsPage() { }

	[CompilerGenerated]
	private void <Show>b__8_0() { }

	public virtual void Close() { }

	private void ScreenSizeUpdateHandler() { }

	private void SetSendButtonBlocker() { }

	public virtual void Show(QuestionsPageData data) { }

}

