namespace EFT.UI;

public sealed class SplashScreenPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <Co_FadeIn>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CanvasGroup canvasGroup; //Field offset: 0x20

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
		public <Co_FadeIn>d__15(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Co_FadeOut>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CanvasGroup canvasGroup; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

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
		public <Co_FadeOut>d__16(int <>1__state) { }

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

	private const float PauseBetweenScreenFade = 0.3; //Field offset: 0x0
	private const float MinimumDisplayDuration = 3; //Field offset: 0x0
	[SerializeField]
	private bool _useEventSplashes; //Field offset: 0x70
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x78
	[SerializeField]
	private Sprite[] _sprites; //Field offset: 0x80
	[SerializeField]
	private Sprite[] _eventSprites; //Field offset: 0x88
	[SerializeField]
	private CanvasGroup _textCanvasGroup; //Field offset: 0x90
	[SerializeField]
	private CanvasGroup _imageCanvasGroup; //Field offset: 0x98
	[SerializeField]
	private Image[] _images; //Field offset: 0xA0
	private DateTime _startTime; //Field offset: 0xA8
	private bool _closeScreen; //Field offset: 0xB0

	private Sprite RandomSprite
	{
		private get { } //Length: 256
	}

	public SplashScreenPanel() { }

	[CompilerGenerated]
	private void <Awake>b__13_0() { }

	[CompilerGenerated]
	private void <Update>b__14_0() { }

	private void Awake() { }

	public virtual void Close() { }

	[IteratorStateMachine(typeof(<Co_FadeIn>d__15))]
	private IEnumerator Co_FadeIn(CanvasGroup canvasGroup) { }

	[IteratorStateMachine(typeof(<Co_FadeOut>d__16))]
	private IEnumerator Co_FadeOut(CanvasGroup canvasGroup, Action callback = null) { }

	private Sprite get_RandomSprite() { }

	public void Hide() { }

	private void Update() { }

}

