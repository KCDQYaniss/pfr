namespace EFT.UI;

public abstract class AnswersContainerView`1 : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public AnswerRawView answerView; //Field offset: 0x0
		public AnswersContainerView <>4__this; //Field offset: 0x0
		public UnityAction <>9__2; //Field offset: 0x0

		public <>c__DisplayClass3_0() { }

		internal void <Show>b__0(bool isOn) { }

		internal void <Show>b__1() { }

		internal void <Show>b__2(bool isOn) { }

	}

	[SerializeField]
	protected AnswerRawView _answerRawTemplate; //Field offset: 0x0
	[SerializeField]
	protected List _answerViews; //Field offset: 0x0
	protected TBaseSurveyQuestion _question; //Field offset: 0x0

	protected AnswersContainerView`1() { }

	public virtual void Close() { }

	protected abstract void CollectAnswer() { }

	private void DisableAnswerRaws() { }

	protected override void OnAnswerToggleValueChanged(AnswerRawView answerView) { }

	public override void Show(TBaseSurveyQuestion question) { }

}

