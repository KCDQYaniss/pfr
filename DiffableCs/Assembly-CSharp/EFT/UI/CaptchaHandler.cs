namespace EFT.UI;

public sealed class CaptchaHandler : UIInputNode, ICaptchaHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Item <ShowCaptchaWindow>b__19_0(string item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public TaskCompletionSource captchaWindowTaskSource; //Field offset: 0x10
		public CancellationTokenSource cancellationSourceCache; //Field offset: 0x18
		public CaptchaHandler <>4__this; //Field offset: 0x20

		public <>c__DisplayClass19_0() { }

		internal void <ShowCaptchaWindow>b__1(List resultItems) { }

		internal void <ShowCaptchaWindow>g__DeclineHandler|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public TaskCompletionSource messageTaskSource; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <ShowMessage>b__0() { }

	}

	[CompilerGenerated]
	private struct <RequestCaptcha>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CaptchaHandler <>4__this; //Field offset: 0x20
		private Result <result>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestCaptchaAndResendCommand>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CaptchaHandler <>4__this; //Field offset: 0x20
		public object operation; //Field offset: 0x28
		public Callback callback; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowCaptchaWindow>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CaptchaHandler <>4__this; //Field offset: 0x20
		public string[] items; //Field offset: 0x28
		public string code; //Field offset: 0x30
		public string title; //Field offset: 0x38
		public string description; //Field offset: 0x40
		private <>c__DisplayClass19_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMessage>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string errorMessage; //Field offset: 0x20
		public CaptchaHandler <>4__this; //Field offset: 0x28
		private DialogWindowContext <messageContext>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryGetCaptcha>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CaptchaHandler <>4__this; //Field offset: 0x20
		private Result <captchaResult>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50
		private TaskAwaiter <>u__4; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateCaptcha>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable items; //Field offset: 0x20
		public CaptchaHandler <>4__this; //Field offset: 0x28
		private int <errorCode>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private string <errorMessage>5__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Wait>d__22`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public CaptchaHandler <>4__this; //Field offset: 0x0
		public Task task; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class TaskResult`1
	{
		private readonly TResult _result; //Field offset: 0x0
		public readonly bool Cancelled; //Field offset: 0x0

		public static TaskResult CancelledResult
		{
			 get { } //Length: 121
		}

		private TaskResult`1() { }

		public TaskResult`1(TResult result) { }

		public static TaskResult get_CancelledResult() { }

		public bool TryGetResult(out TResult result) { }

	}

	private const string CAPTCHA_BRUTE_FORCE_ERROR = "captcha/too frequent attempts"; //Field offset: 0x0
	[SerializeField]
	private CaptchaWindow _captchaWindow; //Field offset: 0x80
	[SerializeField]
	private GameObject _lockScreen; //Field offset: 0x88
	private Profile _profile; //Field offset: 0x90
	private IEftSession _session; //Field offset: 0x98
	private ItemController _itemController; //Field offset: 0xA0
	private bool _isInited; //Field offset: 0xA8
	private bool _readyToUse; //Field offset: 0xA9
	private string _captchaType; //Field offset: 0xB0
	private CancellationTokenSource _cancellationSource; //Field offset: 0xB8
	private DialogWindowContext _captchaWindowContext; //Field offset: 0xC0

	public CaptchaHandler() { }

	public override void Activate() { }

	public virtual void Close() { }

	public override void Deactivate() { }

	private override void EFT.ICaptchaHandler.RequestCaptcha(object operation, Callback callback) { }

	public void Init(IEftSession session) { }

	[AsyncStateMachine(typeof(<RequestCaptcha>d__17))]
	public override Task RequestCaptcha() { }

	[AsyncStateMachine(typeof(<RequestCaptchaAndResendCommand>d__16))]
	private Task RequestCaptchaAndResendCommand(object operation, Callback callback) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	[AsyncStateMachine(typeof(<ShowCaptchaWindow>d__19))]
	private Task ShowCaptchaWindow(string code, string title, string description, string[] items) { }

	[AsyncStateMachine(typeof(<ShowMessage>d__21))]
	private Task ShowMessage(string errorMessage) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryGetCaptcha>d__18))]
	private Task TryGetCaptcha() { }

	[AsyncStateMachine(typeof(<ValidateCaptcha>d__20))]
	private Task ValidateCaptcha(IEnumerable items) { }

	[AsyncStateMachine(typeof(<Wait>d__22`1))]
	private Task Wait(Task task) { }

}

