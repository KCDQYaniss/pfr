namespace EFT.UI;

public sealed class PasscodeInputPanel : UIScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public PasscodeInputPanel <>4__this; //Field offset: 0x10
		public CanvasGroup pulseGroup; //Field offset: 0x18
		public bool successful; //Field offset: 0x20

		public <>c__DisplayClass41_0() { }

		internal void <StartResultSequence>b__0() { }

	}

	private static readonly char[] ERROR_WORD; //Field offset: 0x0
	private const int MAX_INPUT_LENGTH = 7; //Field offset: 0x0
	private static readonly char[] SUCCESS_WORD; //Field offset: 0x8
	private static readonly HashSet PASSCODE_PHYSICAL_KEYS; //Field offset: 0x10
	[SerializeField]
	private PasscodeInputDigitView[] _digitViews; //Field offset: 0x90
	[SerializeField]
	private PasscodeKeyVisualView[] _digitKeyVisuals; //Field offset: 0x98
	[SerializeField]
	private PasscodeKeyVisualView _deleteKeyVisual; //Field offset: 0xA0
	[SerializeField]
	private PasscodeKeyVisualView _submitKeyVisual; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _errorMainGroup; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _successMainGroup; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _errorPulseGroup; //Field offset: 0xC0
	[SerializeField]
	private CanvasGroup _successPulseGroup; //Field offset: 0xC8
	[SerializeField]
	private AnimationCurve _errorPulseCurve; //Field offset: 0xD0
	[SerializeField]
	private AnimationCurve _successPulseCurve; //Field offset: 0xD8
	[SerializeField]
	private TutorialHintData _hintData; //Field offset: 0xE0
	[SerializeField]
	private float _dropScreenDistance; //Field offset: 0xE8
	private bool _screenTutorialShown; //Field offset: 0xEC
	private Player _player; //Field offset: 0xF0
	private PasscodeTerminal _terminal; //Field offset: 0xF8
	private ClientPasscodeController _controller; //Field offset: 0x100
	private string _input; //Field offset: 0x108
	private bool _shown; //Field offset: 0x110
	private bool _awaitingResponse; //Field offset: 0x111
	private bool _isResultAnimationPlaying; //Field offset: 0x112
	private readonly HashSet _commandsBoundToPasscodeKeys; //Field offset: 0x118
	private Sequence _resultSequence; //Field offset: 0x120

	public PasscodeTerminal Terminal
	{
		 get { } //Length: 8
	}

	private static PasscodeInputPanel() { }

	public PasscodeInputPanel() { }

	private void AddMappedCommands(EGameKey gameKey) { }

	private void ApplyWordToSlots(char[] word, EPasscodeSymbolState state) { }

	private Sequence BuildPulseSequence(CanvasGroup pulseGroup, AnimationCurve pulseCurve) { }

	private bool CanAcceptInput() { }

	public virtual void Close() { }

	private void DeleteLastDigit(bool withFeedback) { }

	private void Display(Player player, PasscodeTerminal terminal, ClientPasscodeController controller) { }

	private void FlashDeleteKey() { }

	private void FlashDigitKey(int digit) { }

	private void FlashSubmitKey() { }

	public PasscodeTerminal get_Terminal() { }

	private void HandleDigitPressed(int digit, bool withFeedback) { }

	private void HandleKeyboardInput() { }

	private bool HasPasscodePhysicalKey(KeyGroup keyGroup) { }

	private bool IsOutOfInteractionRange() { }

	protected virtual void OnDestroy() { }

	private void OnPasscodeInteracted(string passcodeId, bool successful) { }

	private void PlayUISound(EUISoundType soundType) { }

	private void RebuildBlockedCommandsFromBindings() { }

	private void RefreshInputVisuals() { }

	private void ResetToIdleVisualState() { }

	private void SetAlpha(CanvasGroup group, float alpha) { }

	private void SetInteractionLocked(bool locked) { }

	private void SetKeyVisualsDisabled(bool disabled) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(Player player, PasscodeTerminal terminal, ClientPasscodeController controller) { }

	private void StartDeleteAnimation(int deleteIndex) { }

	private void StartResultSequence(bool successful) { }

	private void StopVisualAnimations() { }

	private void SubmitCurrentInput(bool withFeedback) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

