namespace EFT.UI;

public sealed class MultiOptionAnswersContainerView : AnswersContainerView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_1; //Field offset: 0x10
		public static Func <>9__2_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <OnAnswerToggleValueChanged>b__2_0(AnswerRawView v) { }

		internal bool <OnAnswerToggleValueChanged>b__2_1(AnswerRawView a) { }

		internal bool <OnAnswerToggleValueChanged>b__2_2(AnswerRawView answerRawView) { }

	}

	private List _answers; //Field offset: 0x88

	public MultiOptionAnswersContainerView() { }

	protected virtual void CollectAnswer() { }

	protected virtual void OnAnswerToggleValueChanged(AnswerRawView answerView) { }

	public virtual void Show(MultiOptionQuestion question) { }

}

