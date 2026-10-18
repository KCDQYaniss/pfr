namespace EFT.InputSystem;

public sealed class InputManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__18_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Init>b__18_2(InputKeyCombination current, IEnumerable allCombinations) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public InputKeyCombination current; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <Init>b__3(InputKeyCombination groupCombination) { }

	}

	public static readonly EKeyPress[,] UpdateInputMatrix; //Field offset: 0x0
	private static GameObject _mainGameObject; //Field offset: 0x8
	private static InputPreset _currentPreset; //Field offset: 0x10
	[SerializeField]
	public bool SuperSmooth; //Field offset: 0x20
	[SerializeField]
	public bool DeliverInputOnUpdates; //Field offset: 0x21
	public Action CursorVisibilityChanged; //Field offset: 0x28
	private bool _isMain; //Field offset: 0x30
	private bool _haveNewInput; //Field offset: 0x31
	private readonly List _commandsList; //Field offset: 0x38
	private readonly List _emptyCommandsList; //Field offset: 0x40
	private readonly float[] _axesList; //Field offset: 0x48
	[CompilerGenerated]
	private TranslateDelegate <TranslateDelegate>k__BackingField; //Field offset: 0x50
	private ECursorResult _shouldLockCursor; //Field offset: 0x58
	private bool _forceShowCursor; //Field offset: 0x5C
	private Action _unsubscribeOnToggleCursor; //Field offset: 0x60

	public TranslateDelegate TranslateDelegate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static InputManager() { }

	public InputManager() { }

	[CompilerGenerated]
	private void <Awake>b__22_0(ToggleShowInGameCursorEvent raisedEvent) { }

	[CompilerGenerated]
	internal static void <Init>g__PrioritizeContinuous|18_0(InputKeyCombination combination, IEnumerable allCombinations) { }

	[CompilerGenerated]
	internal static void <Init>g__ReleaseTacticalValidation|18_1(InputKeyCombination combination, IEnumerable allCombinations) { }

	private void Awake() { }

	public static InputManager Create(KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTime, bool deliverInputOnUpdates) { }

	private static InputManager Create(GameObject gameObject, KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTime, bool deliverInputOnUpdates) { }

	private void DeliverInput() { }

	private void DispatchInput(List commandsList, float[] axesList) { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public TranslateDelegate get_TranslateDelegate() { }

	private void Init(KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTime) { }

	private void OnDestroy() { }

	private void OnToggleCursorEventRaised(ToggleShowInGameCursorEvent calledEvent) { }

	[CompilerGenerated]
	public void set_TranslateDelegate(TranslateDelegate value) { }

	private void Start() { }

	private void Update() { }

	public static void UpdateBindings(KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTimeout) { }

}

