namespace EFT.UI.Settings;

public class CommandAxisPair : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ListenForKey>d__21 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CommandAxisPair <>4__this; //Field offset: 0x20
		public CustomTextMeshProUGUI uiText; //Field offset: 0x28
		public int pairIndex; //Field offset: 0x30
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
		public <ListenForKey>d__21(int <>1__state) { }

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

	[SerializeField]
	private LocalizedText _commandName; //Field offset: 0x20
	[SerializeField]
	private Button _keyButton; //Field offset: 0x28
	[SerializeField]
	private CustomTextMeshProUGUI _keyName; //Field offset: 0x30
	[SerializeField]
	private Button _key2Button; //Field offset: 0x38
	[SerializeField]
	private CustomTextMeshProUGUI _key2Name; //Field offset: 0x40
	[SerializeField]
	private Image _commandBackground; //Field offset: 0x48
	[SerializeField]
	private Image _keyBackground; //Field offset: 0x50
	[SerializeField]
	private Image _key2Background; //Field offset: 0x58
	[SerializeField]
	private Color _defaultBackgroundColor; //Field offset: 0x60
	[SerializeField]
	private Color _resetBackgroundColor; //Field offset: 0x70
	[CompilerGenerated]
	private AxisGroup <AxisGroup>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <Positive>k__BackingField; //Field offset: 0x88
	internal Action OnKeyPressedAction; //Field offset: 0x90
	internal Action OnKeyChoosedAction; //Field offset: 0x98

	public private AxisGroup AxisGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool Positive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public CommandAxisPair() { }

	[CompilerGenerated]
	private void <Awake>b__20_0() { }

	[CompilerGenerated]
	private void <Awake>b__20_1() { }

	private void Awake() { }

	private bool CheckEmpty() { }

	public int ConflictIndex(InputSource input) { }

	[CompilerGenerated]
	public AxisGroup get_AxisGroup() { }

	[CompilerGenerated]
	public bool get_Positive() { }

	[IteratorStateMachine(typeof(<ListenForKey>d__21))]
	private IEnumerator ListenForKey(CustomTextMeshProUGUI uiText, int pairIndex) { }

	public void ResetInput(int index) { }

	[CompilerGenerated]
	private void set_AxisGroup(AxisGroup value) { }

	[CompilerGenerated]
	private void set_Positive(bool value) { }

	private void SetColors(Color color) { }

	public void Show(AxisGroup axisGroup, bool positive) { }

	private void UpdateKeyNameText(CustomTextMeshProUGUI uiText, int index) { }

}

