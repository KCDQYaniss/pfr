namespace EFT.UI.Chat;

public class GlobalChatButton : UIElement
{
	[CompilerGenerated]
	private sealed class <Co_ButtonPressed>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GlobalChatButton <>4__this; //Field offset: 0x20

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
		public <Co_ButtonPressed>d__11(int <>1__state) { }

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

	private const int UpdateCooldown = 5; //Field offset: 0x0
	[SerializeField]
	private Button _runChatClientButton; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _runChatClientLabel; //Field offset: 0x78
	[SerializeField]
	private Image _runChatClientImage; //Field offset: 0x80
	[SerializeField]
	private Color _connectColor; //Field offset: 0x88
	[SerializeField]
	private Color _disconnectColor; //Field offset: 0x98
	private bool _globalChatConnected; //Field offset: 0xA8
	private SocialNetwork _social; //Field offset: 0xB0
	private Coroutine _buttonPressedCoroutine; //Field offset: 0xB8

	public GlobalChatButton() { }

	[CompilerGenerated]
	private void <Awake>b__9_0() { }

	private void Awake() { }

	public virtual void Close() { }

	[IteratorStateMachine(typeof(<Co_ButtonPressed>d__11))]
	private IEnumerator Co_ButtonPressed() { }

	private void Connect() { }

	private void Disconnect() { }

	public void Show(SocialNetwork social) { }

}

