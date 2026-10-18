namespace EFT.UI;

[ExecuteAlways]
public sealed class PrestigeAnimationPlayer : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public int level; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <Show>b__0(PrestigeAnimationData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <PlayVideoAndAnimation>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <SoftHide>b__0() { }

	}

	[CompilerGenerated]
	private struct <PlayVideoAndAnimation>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeAnimationPlayer <>4__this; //Field offset: 0x20
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SoftHide>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeAnimationPlayer <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <WaitForVideoNearEnd>d__12 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PrestigeAnimationPlayer <>4__this; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		private float <targetTime>5__2; //Field offset: 0x30

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
		public <WaitForVideoNearEnd>d__12(int <>1__state) { }

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

	private const float FADE_DURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	private VideoPlayer _videoPlayer; //Field offset: 0x70
	[SerializeField]
	private RawImage _sourceImage; //Field offset: 0x78
	[SerializeField]
	private PrestigeAnimationData[] _animationData; //Field offset: 0x80
	[Header("PVE")]
	[SerializeField]
	private PrestigeAnimationData[] _pveAnimationData; //Field offset: 0x88
	private Vector2 _startPosition; //Field offset: 0x90
	private Sequence _hideSequence; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnAnimationComplete; //Field offset: 0xA0

	public event Action OnAnimationComplete
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public PrestigeAnimationPlayer() { }

	[CompilerGenerated]
	public void add_OnAnimationComplete(Action value) { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<PlayVideoAndAnimation>d__11))]
	private Task PlayVideoAndAnimation() { }

	[CompilerGenerated]
	public void remove_OnAnimationComplete(Action value) { }

	public void Show(int level, EGameMode gameMode = 0) { }

	[AsyncStateMachine(typeof(<SoftHide>d__13))]
	private Task SoftHide() { }

	[IteratorStateMachine(typeof(<WaitForVideoNearEnd>d__12))]
	private IEnumerator WaitForVideoNearEnd(Action callback) { }

}

