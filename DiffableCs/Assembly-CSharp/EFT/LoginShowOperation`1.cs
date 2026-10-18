namespace EFT;

public abstract class LoginShowOperation`1 : Operation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public LoginShowOperation <>4__this; //Field offset: 0x0
		public IValidateDeviceIdScreenController validateDeviceIdScreenController; //Field offset: 0x0
		public Callback <>9__1; //Field offset: 0x0

		public <>c__DisplayClass8_0() { }

		internal void <ValidateDevice>b__0(string activateCode) { }

		internal void <ValidateDevice>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private struct <Login>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public LoginShowOperation <>4__this; //Field offset: 0x0
		public string login; //Field offset: 0x0
		public bool saveToggle; //Field offset: 0x0
		public string password; //Field offset: 0x0
		public Action setError; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected IClientBackEnd _backEnd; //Field offset: 0x0
	protected Login _login; //Field offset: 0x0
	private ILoginScreenController _loginScreenController; //Field offset: 0x0

	protected LoginShowOperation`1() { }

	protected abstract ILoginScreenController GetLoginScreenController(string login, string password, bool savePassword) { }

	protected abstract IValidateDeviceIdScreenController GetLoginScreenController() { }

	[AsyncStateMachine(typeof(<Login>d__6))]
	private Task Login(string login, string password, bool saveToggle, Action setError) { }

	private void LoginResponse(Action setError, Result result) { }

	private void OnLoginHandler(string login, string password, bool saveToggle, Action setError) { }

	protected void ShowLoginScreen() { }

	private void ShowRestorePasswordScreen() { }

	private void ValidateDevice() { }

}

