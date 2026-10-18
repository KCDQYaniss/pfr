namespace EFT.UI;

public abstract class AccountSideSelectionScreen`2 : BaseScreen
{
	[CompilerGenerated]
	private struct <NextButtonPressedHandlerAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AccountSideSelectionScreen <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AccountSideSelectionScreen <>4__this; //Field offset: 0x0
		public bool canCancel; //Field offset: 0x0
		public PreliminaryProfileData profileData; //Field offset: 0x0
		public IClientSession session; //Field offset: 0x0
		public Profile bearProfile; //Field offset: 0x0
		public Profile usecProfile; //Field offset: 0x0
		public string reservedNickname; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAnotherState>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AccountSideSelectionScreen <>4__this; //Field offset: 0x0
		public int stateIndex; //Field offset: 0x0
		private EftScreenState <newState>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private SideSelectionState _sideSelectionState; //Field offset: 0x0
	private bool _isNicknameForceSubmitted; //Field offset: 0x0
	private bool _isNicknameCheckAwaiting; //Field offset: 0x0
	private bool _isNicknameValid; //Field offset: 0x0
	private PlayerIconCreatorMaterialChanger _materialChanger; //Field offset: 0x0
	private bool _canCancel; //Field offset: 0x0
	private bool _interactive; //Field offset: 0x0
	private int _currentSelectedStateIndex; //Field offset: 0x0
	private List _registeredStates; //Field offset: 0x0
	[SerializeField]
	private PlayerIconCreatorSettings _materialSettings; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0x0
	[SerializeField]
	private SeasonalPersonalPerksState _seasonalPersonalPerksState; //Field offset: 0x0
	[SerializeField]
	private SeasonalCommonPerksState _seasonalCommonPerksState; //Field offset: 0x0
	[SerializeField]
	private HeadSelectionState _headSelectionState; //Field offset: 0x0
	private PreliminaryProfileData _profileData; //Field offset: 0x0
	private bool _seasonalPerksEnabled; //Field offset: 0x0

	protected AccountSideSelectionScreen`2() { }

	[CompilerGenerated]
	private void <ShowPreviousScreen>b__25_0() { }

	private void Awake() { }

	private void BackButtonPressedHandler() { }

	public virtual void Close() { }

	private bool IsSeasonalPerksEnabled(IClientSession session) { }

	private bool IsSeasonalPersonalState() { }

	private void NextButtonPressedHandler() { }

	[AsyncStateMachine(typeof(<NextButtonPressedHandlerAsync>d__27))]
	private Task NextButtonPressedHandlerAsync() { }

	public void NicknameError(ENicknameError error) { }

	private void SetScreenInteractionLocked(bool locked) { }

	public virtual void Show(TController controller) { }

	[AsyncStateMachine(typeof(<Show>d__20))]
	private Task Show(Profile bearProfile, Profile usecProfile, PreliminaryProfileData profileData, IClientSession session, bool canCancel, string reservedNickname) { }

	[AsyncStateMachine(typeof(<ShowAnotherState>d__21))]
	private Task ShowAnotherState(int stateIndex) { }

	private void ShowNextScreen() { }

	private void ShowPreviousScreen() { }

	private void StateReadyHandler(bool ready) { }

	private void SubmitNicknameHandler(string nickname) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateNextButtonState(EftScreenState state) { }

}

