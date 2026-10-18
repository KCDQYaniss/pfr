namespace EFT.UI;

public sealed class SingleOptionAnswersContainerView : AnswersContainerView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnAnswerToggleValueChanged>b__1_0(AnswerRawView a) { }

	}


	public SingleOptionAnswersContainerView() { }

	protected virtual void CollectAnswer() { }

	protected virtual void OnAnswerToggleValueChanged(AnswerRawView answerView) { }

	public virtual void Show(SingleOptionQuestion question) { }

}

