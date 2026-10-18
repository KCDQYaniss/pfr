namespace Vuplex.WebView.Internal;

public class NativeKeyboardListener : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__44_0(string javaScriptKeyName) { }

		internal string[] <.cctor>b__44_1(string javaScriptKeyValue) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0`2
	{
		public Dictionary cache; //Field offset: 0x0
		public Func function; //Field offset: 0x0

		public <>c__DisplayClass32_0`2() { }

		internal TReturn <_memoize>b__0(TArg arg) { }

	}

	private class KeyRepeatState
	{
		public string Key; //Field offset: 0x10
		public bool HasRepeated; //Field offset: 0x18

		public KeyRepeatState() { }

	}

	private static readonly Func _hasValidUnityKeyName; //Field offset: 0x0
	private static readonly string[] _keyValuesUndetectableThroughInputString; //Field offset: 0x8
	private static readonly string[] _keyValues; //Field offset: 0x10
	private static readonly Func _getPotentialUnityKeyNames; //Field offset: 0x18
	[CompilerGenerated]
	private EventHandler ImeCompositionCancelled; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler ImeCompositionChanged; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler ImeCompositionFinished; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler KeyDownReceived; //Field offset: 0x38
	[CompilerGenerated]
	private EventHandler KeyUpReceived; //Field offset: 0x40
	private Regex _alphanumericRegex; //Field offset: 0x48
	private Nullable _imeShouldBeEnabled; //Field offset: 0x50
	private List _keysDown; //Field offset: 0x58
	private KeyRepeatState _keyRepeatState; //Field offset: 0x60
	private bool _legacyInputManagerDisabled; //Field offset: 0x68
	private KeyModifier _modifiersDown; //Field offset: 0x6C
	private string _previousImeCompositionString; //Field offset: 0x70

	public event EventHandler ImeCompositionCancelled
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler ImeCompositionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler ImeCompositionFinished
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler KeyDownReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler KeyUpReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private bool _areKeysUndetectableThroughInputStringPressed() { }

	private bool _determineIfImeShouldBeEnabled() { }

	private void _enableImeIfNeeded() { }

	private KeyModifier _getModifiers() { }

	private static Func _memoize(Func function) { }

	private bool _processIme() { }

	private bool _processInputString() { }

	private void _processKeysPressed() { }

	private void _processKeysReleased() { }

	private bool _processKeysUndetectableThroughInputString() { }

	private void _processModifierKeysOnly() { }

	private void _repeatKey() { }

	private static NativeKeyboardListener() { }

	public NativeKeyboardListener() { }

	[CompilerGenerated]
	public void add_ImeCompositionCancelled(EventHandler value) { }

	[CompilerGenerated]
	public void add_ImeCompositionChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_ImeCompositionFinished(EventHandler value) { }

	[CompilerGenerated]
	public void add_KeyDownReceived(EventHandler value) { }

	[CompilerGenerated]
	public void add_KeyUpReceived(EventHandler value) { }

	private void Awake() { }

	public static NativeKeyboardListener Instantiate() { }

	private void OnGUI() { }

	[CompilerGenerated]
	public void remove_ImeCompositionCancelled(EventHandler value) { }

	[CompilerGenerated]
	public void remove_ImeCompositionChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_ImeCompositionFinished(EventHandler value) { }

	[CompilerGenerated]
	public void remove_KeyDownReceived(EventHandler value) { }

	[CompilerGenerated]
	public void remove_KeyUpReceived(EventHandler value) { }

	private void Update() { }

}

