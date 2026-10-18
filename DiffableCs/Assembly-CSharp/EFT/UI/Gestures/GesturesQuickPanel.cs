namespace EFT.UI.Gestures;

public sealed class GesturesQuickPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Func <>9__16_1; //Field offset: 0x10
		public static Comparison <>9__29_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <get_PrioritizedCommand>b__16_0(KeyValuePair x) { }

		internal string <get_PrioritizedCommand>b__16_1(KeyValuePair x) { }

		internal int <PlayerPhraseSituation>b__29_0(SituationPhrase p1, SituationPhrase p2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public GesturesQuickPanel <>4__this; //Field offset: 0x10
		public GamePlayerOwner owner; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <Show>b__0(ValueTuple x) { }

		internal void <Show>b__1(ValueTuple x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public GesturesQuickPanel <>4__this; //Field offset: 0x10
		public EPhraseTrigger trigger; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal Nullable <TryNotifyPhrasePlayed>b__0(Task _) { }

		internal bool <TryNotifyPhrasePlayed>b__1(SituationPhrase x) { }

		internal bool <TryNotifyPhrasePlayed>b__2(SituationPhrase x) { }

	}

	[CompilerGenerated]
	private struct <TryNotifyPhrasePlayed>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GesturesQuickPanel <>4__this; //Field offset: 0x20
		public EPhraseTrigger trigger; //Field offset: 0x28
		public float time; //Field offset: 0x2C
		private <>c__DisplayClass47_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class SituationPhrase
	{
		public EPhraseTrigger Phrase; //Field offset: 0x10
		public float Expires; //Field offset: 0x14

		public SituationPhrase() { }

	}

	public static readonly Dictionary PhrasePriorities; //Field offset: 0x0
	[SerializeField]
	private ActionPanel _actionPanel; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _textField; //Field offset: 0x78
	[SerializeField]
	private GameObject _quickCommandObject; //Field offset: 0x80
	[SerializeField]
	private GesturesMenu _gesturesMenu; //Field offset: 0x88
	[SerializeField]
	private GesturesVoipPanel _gesturesVoipPanel; //Field offset: 0x90
	[SerializeField]
	private GesturesDropdownPanel _dropdownPanel; //Field offset: 0x98
	[SerializeField]
	private Animation _animation; //Field offset: 0xA0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI Hotkey; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI DropdownHotkey; //Field offset: 0xB8
	private EPhraseTrigger _lastCommand; //Field offset: 0xC0
	private readonly Dictionary _activeCommandsList; //Field offset: 0xC8
	private IHealthController _healthController; //Field offset: 0xD0
	private Player _player; //Field offset: 0xD8
	private readonly List _phraseEvents; //Field offset: 0xE0
	private HashSet _availablePhrases; //Field offset: 0xE8
	private TaskCompletionSource _phraseTask; //Field offset: 0xF0
	private bool _phrasePlaying; //Field offset: 0xF8

	public GesturesDropdownPanel DropdownPanel
	{
		 get { } //Length: 8
	}

	public bool DropdownPanelActive
	{
		 get { } //Length: 105
	}

	public GesturesMenu GesturesMenu
	{
		 get { } //Length: 8
	}

	private EPhraseTrigger PrioritizedCommand
	{
		private get { } //Length: 1244
	}

	private static GesturesQuickPanel() { }

	public GesturesQuickPanel() { }

	[CompilerGenerated]
	private bool <IsActiveEffect>b__40_0(EBodyPart bp) { }

	public EPhraseTrigger ActivateCommand() { }

	public void AddQuickCommand(EPhraseTrigger trigger) { }

	public virtual void Close() { }

	public void CloseBindPanel() { }

	public void CloseDropdown(Action onPhraseSelected) { }

	private void EffectChangedHandler(IHealthEffect effect = null) { }

	private void GestureMenuCloseHandler() { }

	private void GesturesMenuShowHandler() { }

	public GesturesDropdownPanel get_DropdownPanel() { }

	public bool get_DropdownPanelActive() { }

	public GesturesMenu get_GesturesMenu() { }

	private EPhraseTrigger get_PrioritizedCommand() { }

	private bool IsActiveEffect(EBodyPart[] bodyParts) { }

	private bool IsActiveEffect() { }

	public bool IsPhraseAvailable(EPhraseTrigger phrase) { }

	public static bool IsSituationalPhrase(EPhraseTrigger phrase) { }

	private void OnDestroy() { }

	private void OnExitTriggerInteraction() { }

	private void OnHealthChangedHandler(EBodyPart bodyPart = 1, float diff = 0, DamageInfo damageStats = null) { }

	private void OnPossibleInteractionChangedHandler() { }

	private void PlayerPhraseSituation(EPhraseTrigger ePhraseTrigger, int delay) { }

	private void RefreshHealthHandlers() { }

	private void RemoveListeners() { }

	public void RemoveQuickCommand(EPhraseTrigger trigger) { }

	private void SetPhraseActive(EPhraseTrigger phrase, bool active) { }

	public void Show(GamePlayerOwner owner) { }

	public void ShowDropdown() { }

	public void ToggleBindPanel(Player player) { }

	[AsyncStateMachine(typeof(<TryNotifyPhrasePlayed>d__47))]
	public Task TryNotifyPhrasePlayed(EPhraseTrigger trigger, float time) { }

	private void Update() { }

	private void UpdateQuickPanelLabel() { }

}

