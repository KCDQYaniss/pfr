namespace EFT.UI.Gestures;

public class GesturesMenu : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__42_0; //Field offset: 0x8
		public static Func <>9__42_1; //Field offset: 0x10
		public static Func <>9__48_0; //Field offset: 0x18
		public static Func <>9__51_0; //Field offset: 0x20
		public static Func <>9__51_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <CatchLastOpenGroup>b__48_0(GesturesAudioItem x) { }

		internal bool <CloseWithSelected>b__42_0(GestureBaseItem x) { }

		internal bool <CloseWithSelected>b__42_1(GesturesBindItem x) { }

		internal EInteraction <InitGestures>b__51_0(CustomizationGesture gesture) { }

		internal int <InitGestures>b__51_1(EInteraction gesture) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public bool isSituational; //Field offset: 0x10
		public GesturesMenu <>4__this; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal void <CreatePhraseGroup>b__0(PointerClick x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public GesturesMenu <>4__this; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <ShowContextMenu>b__0(ECommand command) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass50_0() { }

		internal bool <Bind>b__0(KeyValuePair x) { }

	}

	[IsReadOnly]
	internal struct UpdatedGestureBind
	{
		public readonly ECommand Command; //Field offset: 0x0
		public readonly int Index; //Field offset: 0x4
		public readonly string Caption; //Field offset: 0x8

		public UpdatedGestureBind(ECommand command, int index, string caption) { }

	}

	public static readonly BindableEvent OnBindUpdated; //Field offset: 0x0
	[SerializeField]
	[Space]
	private Transform _audioContainer; //Field offset: 0x80
	[SerializeField]
	protected GesturesAudioItem _commonGroupTemplate; //Field offset: 0x88
	[SerializeField]
	protected GesturesAudioItem _situationalGroupTemplate; //Field offset: 0x90
	private readonly List _audioItems; //Field offset: 0x98
	[SerializeField]
	[Space]
	protected BaseTransformSolver _gestureContainer; //Field offset: 0xA0
	[SerializeField]
	private GesturesMenuItem _gestureItemTemplate; //Field offset: 0xA8
	protected readonly List _gestureItems; //Field offset: 0xB0
	[SerializeField]
	[Space]
	private GesturesBindPanel _gesturesBindPanel; //Field offset: 0xB8
	[SerializeField]
	private SimpleContextMenu _gesturesContextMenu; //Field offset: 0xC0
	[SerializeField]
	[Space]
	private Sprite _defaultSubItemBack; //Field offset: 0xC8
	[SerializeField]
	private Sprite _selectedSubItemBack; //Field offset: 0xD0
	[SerializeField]
	private Sprite _defaultGestureBack; //Field offset: 0xD8
	[SerializeField]
	private Sprite _selectedGestureBack; //Field offset: 0xE0
	[SerializeField]
	private ColorMap _colorMap; //Field offset: 0xE8
	public readonly BindableEvent OnShow; //Field offset: 0xF0
	public readonly BindableEvent OnClose; //Field offset: 0xF8
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"actionId", "aggressive"})]
	public readonly BindableEvent OnItemSelected; //Field offset: 0x100
	private readonly List _allItems; //Field offset: 0x108
	private GesturesAudioItem _lastOpenAudioGroup; //Field offset: 0x110
	private GesturesCommandsStorage _gesturesStorage; //Field offset: 0x118
	private HashSet _availablePhrases; //Field offset: 0x120
	private EPlayerSide _side; //Field offset: 0x128
	[CompilerGenerated]
	private GestureCommands <Binds>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private bool <IsShowing>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private bool <HideOnlySituationalGroups>k__BackingField; //Field offset: 0x139

	public private GestureCommands Binds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool HideOnlySituationalGroups
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private bool IsShowing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static GesturesMenu() { }

	public GesturesMenu() { }

	[CompilerGenerated]
	private void <CreateGesture>b__44_0(PointerClick x) { }

	[CompilerGenerated]
	private void <Show>b__37_0(int item) { }

	private void Awake() { }

	private void Bind(ECommand command, int index) { }

	private void CatchLastOpenGroup() { }

	public virtual void Close() { }

	public void CloseWithSelected() { }

	protected override void CreateGesture(EInteraction gesture) { }

	protected GesturesAudioItem CreatePhraseGroup(string localizationKey, GesturesAudioItem groupTemplate, EPhraseTrigger[] phrases) { }

	[CompilerGenerated]
	public GestureCommands get_Binds() { }

	[CompilerGenerated]
	private bool get_HideOnlySituationalGroups() { }

	[CompilerGenerated]
	public bool get_IsShowing() { }

	public void Init(GesturesCommandsStorage gesturesStorage, HashSet availablePhrases, EPlayerSide side) { }

	private void InitGestures() { }

	protected override void InitPhraseGroups() { }

	private void PointerClickedHandler(PointerClick click, bool isSituational) { }

	private void ReleaseLastOpenGroup() { }

	[CompilerGenerated]
	private void set_Binds(GestureCommands value) { }

	[CompilerGenerated]
	public void set_HideOnlySituationalGroups(bool value) { }

	[CompilerGenerated]
	private void set_IsShowing(bool value) { }

	public void SetPhraseActive(EPhraseTrigger phrase, bool active) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show() { }

	private void ShowContextMenu(int index, Vector2 pos) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

