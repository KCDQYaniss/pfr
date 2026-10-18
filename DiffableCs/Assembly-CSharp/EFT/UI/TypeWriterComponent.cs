namespace EFT.UI;

public sealed class TypeWriterComponent : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <Co_TypeText>d__22 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TypeWriterComponent <>4__this; //Field offset: 0x20
		public string text; //Field offset: 0x28
		private List <parsedText>5__2; //Field offset: 0x30
		private int <i>5__3; //Field offset: 0x38

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
		public <Co_TypeText>d__22(int <>1__state) { }

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

	private struct RichTextChar
	{
		public readonly char character; //Field offset: 0x0
		public readonly bool isTag; //Field offset: 0x2

		public RichTextChar(char character, bool isTag) { }

	}

	[SerializeField]
	private TMP_Text _textComponent; //Field offset: 0x20
	[SerializeField]
	[Space]
	private float charTypeDelay; //Field offset: 0x28
	[SerializeField]
	private float punctuationDelay; //Field offset: 0x2C
	[SerializeField]
	private bool playOnEnable; //Field offset: 0x30
	[SerializeField]
	private bool skipOnClick; //Field offset: 0x31
	[SerializeField]
	private float minSkipTime; //Field offset: 0x34
	private string _fullText; //Field offset: 0x38
	private Coroutine _typeCoroutine; //Field offset: 0x40
	private bool _isTyping; //Field offset: 0x48
	private DateTime _typingStartTime; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnTypeComplete; //Field offset: 0x58

	public event Action OnTypeComplete
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool IsTyping
	{
		 get { } //Length: 5
	}

	public TypeWriterComponent() { }

	[CompilerGenerated]
	public void add_OnTypeComplete(Action value) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<Co_TypeText>d__22))]
	private IEnumerator Co_TypeText(string text) { }

	public void CompleteTyping() { }

	public bool get_IsTyping() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private static List ParseRichText(string text) { }

	[CompilerGenerated]
	public void remove_OnTypeComplete(Action value) { }

	public void StartTypingText(string text) { }

	private void StopTyping() { }

}

