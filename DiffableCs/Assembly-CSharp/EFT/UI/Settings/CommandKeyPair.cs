namespace EFT.UI.Settings;

public sealed class CommandKeyPair : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__22_0; //Field offset: 0x8
		public static Func <>9__28_0; //Field offset: 0x10
		public static Func <>9__35_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CheckIsEmpty>b__35_0(InputSource keyVariant) { }

		internal bool <get_DropdownAvailable>b__22_0(InputSource variant) { }

		internal bool <ListenForKey>b__28_0(InputSource variant) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <CheckOtherEmpty>b__0(InputSource t, int i) { }

	}

	[CompilerGenerated]
	private sealed class <ListenForKey>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CommandKeyPair <>4__this; //Field offset: 0x20
		public TMP_Text uiText; //Field offset: 0x28
		public int variantIndex; //Field offset: 0x30
		private InputSource <newKey>5__2; //Field offset: 0x38
		private bool <processing>5__3; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ListenForKey>d__28(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const string NOT_SET_KEY = "Settings/NotSet"; //Field offset: 0x0
	[SerializeField]
	private LocalizedText _commandName; //Field offset: 0x70
	[SerializeField]
	private Button _keyButton; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _keyName; //Field offset: 0x80
	[SerializeField]
	private Button _key2Button; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _key2Name; //Field offset: 0x90
	[SerializeField]
	private GameObject _emptyPressTypeCell; //Field offset: 0x98
	[SerializeField]
	private GameObject _unavailableCell; //Field offset: 0xA0
	[SerializeField]
	private DropDownBox _typeDropdown; //Field offset: 0xA8
	[SerializeField]
	private Image _commandBackground; //Field offset: 0xB0
	[SerializeField]
	private Image _keyBackground; //Field offset: 0xB8
	[SerializeField]
	private Image _key2Background; //Field offset: 0xC0
	[SerializeField]
	private Image _pressTypeBackground; //Field offset: 0xC8
	[SerializeField]
	private Image _unavailableBackground; //Field offset: 0xD0
	[SerializeField]
	private Color _defaultBackgroundColor; //Field offset: 0xD8
	[SerializeField]
	private Color _resetBackgroundColor; //Field offset: 0xE8
	[SerializeField]
	private Color _notInteractableTextColor; //Field offset: 0xF8
	[CompilerGenerated]
	private KeyGroup <KeyGroup>k__BackingField; //Field offset: 0x108
	internal Action OnKeyPressedAction; //Field offset: 0x110
	internal Func OnKeyChosenAction; //Field offset: 0x118
	private bool _interactable; //Field offset: 0x120
	private bool _isEmpty; //Field offset: 0x121
	private List _pressTypes; //Field offset: 0x128

	public bool DropdownAvailable
	{
		 get { } //Length: 458
	}

	public private KeyGroup KeyGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CommandKeyPair() { }

	[CompilerGenerated]
	private void <ListenForKey>b__28_1() { }

	[CompilerGenerated]
	private void <ListenForKey>b__28_2() { }

	[CompilerGenerated]
	private void <ListenForKey>b__28_3() { }

	[CompilerGenerated]
	private void <ListenForKey>b__28_4() { }

	[CompilerGenerated]
	private void <Show>b__37_0() { }

	[CompilerGenerated]
	private void <Show>b__37_1() { }

	private bool CheckIsEmpty() { }

	private bool CheckOtherEmpty(int index) { }

	public int ConflictIndex(InputSource input) { }

	private void DropdownClosed(int valueIndex) { }

	public bool get_DropdownAvailable() { }

	[CompilerGenerated]
	public KeyGroup get_KeyGroup() { }

	[IteratorStateMachine(typeof(<ListenForKey>d__28))]
	private IEnumerator ListenForKey(TMP_Text uiText, int variantIndex) { }

	public void ResetInput(int index) { }

	[CompilerGenerated]
	private void set_KeyGroup(KeyGroup value) { }

	private void SetColors(Color color) { }

	public void Show(KeyGroup keyGroup, Dictionary pressTypes, bool interactable = true) { }

	private void UpdateKeyNameText(TMP_Text uiText, int variantIndex) { }

	private void UpdatePressTypeCell() { }

}

