namespace EFT.UI;

public class UITutorialController : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		private struct <<StartNextStep>g__AddCanvasDelayed|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass18_0 <>4__this; //Field offset: 0x20
			private YieldAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public UITutorialStepData step; //Field offset: 0x10
		public UITutorialController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		[AsyncStateMachine(typeof(<<StartNextStep>g__AddCanvasDelayed|0>d))]
		internal Task <StartNextStep>g__AddCanvasDelayed|0() { }

	}

	internal enum EUITutorialInteractionType
	{
		AnyKey = 0,
		AreaClick = 1,
	}

	internal class FinalInfoUITutorialData : UITutorialStepData
	{

		public FinalInfoUITutorialData() { }

		public virtual void ShowHint(UITutorialControllerHint hint, string indexText) { }

	}

	internal class ForceShowTooltipUITutorialStepData : UITutorialStepData
	{
		public Vector2 TooltipPos; //Field offset: 0x40
		public string TooltipText; //Field offset: 0x48
		private Canvas _tooltipCanvas; //Field offset: 0x50

		public ForceShowTooltipUITutorialStepData() { }

		public virtual void OnComplete() { }

		public virtual void OnStart() { }

	}

	internal class UITutorialData
	{
		public List Steps; //Field offset: 0x10
		public string PrefsKey; //Field offset: 0x18

		public UITutorialData() { }

	}

	internal class UITutorialStepData
	{
		public string MainText; //Field offset: 0x10
		public string CompletionText; //Field offset: 0x18
		public RectTransform Target; //Field offset: 0x20
		public EUITutorialInteractionType Interaction; //Field offset: 0x28
		public UITutorialFocusArea FocusArea; //Field offset: 0x30
		public UITutorialHintAnchor HintAnchor; //Field offset: 0x38

		public bool IsWaitingAreaClick
		{
			 get { } //Length: 3
		}

		public bool IsWaitingShadowClick
		{
			 get { } //Length: 8
		}

		public UITutorialStepData() { }

		public bool get_IsWaitingAreaClick() { }

		public bool get_IsWaitingShadowClick() { }

		public bool IsWaitingCommand(ECommand command) { }

		public bool IsWaitingKey(KeyCode key) { }

		public override void OnComplete() { }

		public override void OnStart() { }

		public override void ShowHint(UITutorialControllerHint hint, string indexText) { }

	}

	private const double MIN_DELAY = 500; //Field offset: 0x0
	[SerializeField]
	private UITutorialControllerHint _hintView; //Field offset: 0x80
	[SerializeField]
	private UITutorialFocusArea _commonFocusArea; //Field offset: 0x88
	private UITutorialData _currentData; //Field offset: 0x90
	private int _currentStepId; //Field offset: 0x98
	private TaskCompletionSource _completionSource; //Field offset: 0xA0
	private DateTime _stepStartTime; //Field offset: 0xA8
	private List _stepHighlightCanvas; //Field offset: 0xB0

	private UITutorialStepData CurrentStep
	{
		private get { } //Length: 119
	}

	public UITutorialController() { }

	private void Awake() { }

	private void CompleteStep() { }

	private void CompleteTutorial() { }

	private UITutorialStepData get_CurrentStep() { }

	private void MainClick() { }

	private void OnGUI() { }

	private void ShadowClick() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public Task Show(UITutorialData data) { }

	private void StartNextStep() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryGetCurrentStep(out UITutorialStepData step) { }

}

