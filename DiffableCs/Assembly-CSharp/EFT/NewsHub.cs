namespace EFT;

public sealed class NewsHub
{
	[CompilerGenerated]
	private struct <Init>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NewsHub <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IEftSession _session; //Field offset: 0x10
	private SurveyData _survey; //Field offset: 0x18
	[CompilerGenerated]
	private Action surveyViewed; //Field offset: 0x20

	public event Action surveyViewed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public NewsHub(IEftSession session) { }

	[CompilerGenerated]
	public void add_surveyViewed(Action value) { }

	private void CreateTestSurvey() { }

	public SurveyTemplate GetSurveyTemplate() { }

	[AsyncStateMachine(typeof(<Init>d__6))]
	public Task Init() { }

	public void OnSurveyCompleted() { }

	public void OnSurveyViewed() { }

	[CompilerGenerated]
	public void remove_surveyViewed(Action value) { }

	public void UpdateCurrentLocale() { }

}

