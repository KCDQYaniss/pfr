namespace EFT.BackEnd;

internal sealed class ConnectionDiagnostics
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public CancellationTokenSource cancellationSource; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal void <Run>b__0() { }

		internal void <Run>b__1() { }

	}

	[CompilerGenerated]
	private struct <Run>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConnectionDiagnostics <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskCompletionSource <completionSource>5__2; //Field offset: 0x30
		private Stopwatch <stopWatch>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunDiagnostics>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConnectionDiagnostics <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Stop>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConnectionDiagnostics <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private abstract class Diagnostics
	{
		[CompilerGenerated]
		private struct <Run>d__10 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Diagnostics <>4__this; //Field offset: 0x20
			public ConnectionDiagnostics context; //Field offset: 0x28
			public CancellationToken token; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private EDiagnosisSource <Source>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private ConnectionDiagnostics <Context>k__BackingField; //Field offset: 0x18

		protected ConnectionDiagnostics Context
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected AbstractLogger Logger
		{
			 get { } //Length: 27
		}

		protected EDiagnosisSource Source
		{
			[CompilerGenerated]
			 get { } //Length: 164
			[CompilerGenerated]
			 set { } //Length: 4
		}

		protected Diagnostics() { }

		protected abstract Task Execute(CancellationToken token) { }

		[CompilerGenerated]
		protected ConnectionDiagnostics get_Context() { }

		protected AbstractLogger get_Logger() { }

		[CompilerGenerated]
		protected EDiagnosisSource get_Source() { }

		[AsyncStateMachine(typeof(<Run>d__10))]
		internal Task Run(ConnectionDiagnostics context, CancellationToken token) { }

		[CompilerGenerated]
		protected void set_Context(ConnectionDiagnostics value) { }

		[CompilerGenerated]
		protected void set_Source(EDiagnosisSource value) { }

	}

	private sealed class Logger : AbstractLogger
	{

		internal Logger() { }

		internal void LogDiagnosticsResult(Diagnosis[] results, TimeSpan timeSpan, bool isCancellationRequested) { }

	}

	private sealed class PingDiagnostics : Diagnostics
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public PingDiagnostics <>4__this; //Field offset: 0x10
			public Ping ping; //Field offset: 0x18

			public <>c__DisplayClass10_0() { }

			internal void <Execute>b__0() { }

			internal Task <Execute>b__1() { }

		}

		[CompilerGenerated]
		private struct <Execute>d__10 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PingDiagnostics <>4__this; //Field offset: 0x20
			public CancellationToken token; //Field offset: 0x28
			private <>c__DisplayClass10_0 <>8__1; //Field offset: 0x30
			private Stopwatch <stopWatch>5__2; //Field offset: 0x38
			private StringBuilder <stringBuilder>5__3; //Field offset: 0x40
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private string <Address>k__BackingField; //Field offset: 0x20

		private string Address
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		internal static PingDiagnostics Ping8888
		{
			internal get { } //Length: 191
		}

		internal static PingDiagnostics PingProd
		{
			internal get { } //Length: 191
		}

		private static int TimeOut
		{
			private get { } //Length: 6
		}

		public PingDiagnostics() { }

		[AsyncStateMachine(typeof(<Execute>d__10))]
		protected virtual Task Execute(CancellationToken token) { }

		[CompilerGenerated]
		private string get_Address() { }

		internal static PingDiagnostics get_Ping8888() { }

		internal static PingDiagnostics get_PingProd() { }

		private static int get_TimeOut() { }

		[CompilerGenerated]
		private void set_Address(string value) { }

	}

	private sealed class ProcessDiagnostics : Diagnostics
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public Process process; //Field offset: 0x10

			public <>c__DisplayClass12_0() { }

			internal void <Execute>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			public StringBuilder stringBuilder; //Field offset: 0x10
			public Process process; //Field offset: 0x18
			public bool succeed; //Field offset: 0x20
			public TaskCompletionSource completionSource; //Field offset: 0x28

			public <>c__DisplayClass13_0() { }

			internal void <Run>b__0(object sender, DataReceivedEventArgs args) { }

			internal void <Run>b__1(object sender, DataReceivedEventArgs args) { }

			internal void <Run>b__2(object sender, EventArgs args) { }

		}

		[CompilerGenerated]
		private struct <Execute>d__12 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public ProcessDiagnostics <>4__this; //Field offset: 0x20
			public CancellationToken token; //Field offset: 0x28
			private <>c__DisplayClass12_0 <>8__1; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Run>d__13 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Process process; //Field offset: 0x20
			private <>c__DisplayClass13_0 <>8__1; //Field offset: 0x28
			public ProcessDiagnostics <>4__this; //Field offset: 0x30
			private Stopwatch <stopWatch>5__2; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private string <FileName>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <Arguments>k__BackingField; //Field offset: 0x28

		private string Arguments
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		private string FileName
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		internal static ProcessDiagnostics NSLookup
		{
			internal get { } //Length: 348
		}

		internal static ProcessDiagnostics Tracert
		{
			internal get { } //Length: 348
		}

		public ProcessDiagnostics() { }

		[AsyncStateMachine(typeof(<Execute>d__12))]
		protected virtual Task Execute(CancellationToken token) { }

		[CompilerGenerated]
		private string get_Arguments() { }

		[CompilerGenerated]
		private string get_FileName() { }

		internal static ProcessDiagnostics get_NSLookup() { }

		internal static ProcessDiagnostics get_Tracert() { }

		[AsyncStateMachine(typeof(<Run>d__13))]
		private Task Run(Process process) { }

		[CompilerGenerated]
		private void set_Arguments(string value) { }

		[CompilerGenerated]
		private void set_FileName(string value) { }

	}

	private sealed class UnityPingDiagnostics : Diagnostics
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__14_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <Execute>b__14_0(IPAddress ip) { }

		}

		[CompilerGenerated]
		private struct <Execute>d__14 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public UnityPingDiagnostics <>4__this; //Field offset: 0x20
			public CancellationToken token; //Field offset: 0x28
			private Stopwatch <stopWatch>5__2; //Field offset: 0x30
			private StringBuilder <stringBuilder>5__3; //Field offset: 0x38
			private string <address>5__4; //Field offset: 0x40
			private Ping <ping>5__5; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50
			private YieldAwaiter <>u__2; //Field offset: 0x58

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private string <Address>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private bool <ResolveAddress>k__BackingField; //Field offset: 0x28

		private string Address
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		internal static UnityPingDiagnostics Ping8888
		{
			internal get { } //Length: 191
		}

		internal static UnityPingDiagnostics PingProd
		{
			internal get { } //Length: 211
		}

		private bool ResolveAddress
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		private static TimeSpan Timeout
		{
			private get { } //Length: 137
		}

		public UnityPingDiagnostics() { }

		[AsyncStateMachine(typeof(<Execute>d__14))]
		protected virtual Task Execute(CancellationToken token) { }

		[CompilerGenerated]
		private string get_Address() { }

		internal static UnityPingDiagnostics get_Ping8888() { }

		internal static UnityPingDiagnostics get_PingProd() { }

		[CompilerGenerated]
		private bool get_ResolveAddress() { }

		private static TimeSpan get_Timeout() { }

		[CompilerGenerated]
		private void set_Address(string value) { }

		[CompilerGenerated]
		private void set_ResolveAddress(bool value) { }

	}

	private sealed class UnityWebDiagnostics : Diagnostics
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public StringBuilder stringBuilder; //Field offset: 0x10
			public UnityWebRequest request; //Field offset: 0x18

			public <>c__DisplayClass10_0() { }

			internal void <Execute>b__0() { }

		}

		[CompilerGenerated]
		private struct <Execute>d__10 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public UnityWebDiagnostics <>4__this; //Field offset: 0x20
			public CancellationToken token; //Field offset: 0x28
			private <>c__DisplayClass10_0 <>8__1; //Field offset: 0x30
			private Stopwatch <stopWatch>5__2; //Field offset: 0x38
			private UnityWebRequestAsyncOperation <operation>5__3; //Field offset: 0x40
			private YieldAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private string <Url>k__BackingField; //Field offset: 0x20

		internal static UnityWebDiagnostics Http
		{
			internal get { } //Length: 191
		}

		internal static UnityWebDiagnostics Https
		{
			internal get { } //Length: 191
		}

		private static int TimeOut
		{
			private get { } //Length: 6
		}

		private string Url
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public UnityWebDiagnostics() { }

		[AsyncStateMachine(typeof(<Execute>d__10))]
		protected virtual Task Execute(CancellationToken token) { }

		internal static UnityWebDiagnostics get_Http() { }

		internal static UnityWebDiagnostics get_Https() { }

		private static int get_TimeOut() { }

		[CompilerGenerated]
		private string get_Url() { }

		[CompilerGenerated]
		private void set_Url(string value) { }

	}

	private sealed class WebDiagnostics : Diagnostics
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			public StringBuilder stringBuilder; //Field offset: 0x10
			public HttpWebRequest request; //Field offset: 0x18

			public <>c__DisplayClass8_0() { }

			internal void <Execute>b__0() { }

		}

		[CompilerGenerated]
		private struct <Execute>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public WebDiagnostics <>4__this; //Field offset: 0x20
			public CancellationToken token; //Field offset: 0x28
			private <>c__DisplayClass8_0 <>8__1; //Field offset: 0x30
			private Stopwatch <stopWatch>5__2; //Field offset: 0x38
			private bool <succeed>5__3; //Field offset: 0x40
			private HttpWebResponse <response>5__4; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50
			private Stream <stream>5__5; //Field offset: 0x58
			private StreamReader <reader>5__6; //Field offset: 0x60
			private TaskAwaiter <>u__2; //Field offset: 0x68

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private string <Url>k__BackingField; //Field offset: 0x20

		internal static WebDiagnostics Http
		{
			internal get { } //Length: 191
		}

		internal static WebDiagnostics Https
		{
			internal get { } //Length: 191
		}

		private string Url
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public WebDiagnostics() { }

		[AsyncStateMachine(typeof(<Execute>d__8))]
		protected virtual Task Execute(CancellationToken token) { }

		internal static WebDiagnostics get_Http() { }

		internal static WebDiagnostics get_Https() { }

		[CompilerGenerated]
		private string get_Url() { }

		[CompilerGenerated]
		private void set_Url(string value) { }

	}

	private readonly Logger _logger; //Field offset: 0x10
	private CancellationTokenSource _cancellationSource; //Field offset: 0x18
	private TaskCompletionSource _completionSource; //Field offset: 0x20

	private static string Address8888
	{
		private get { } //Length: 49
	}

	private static string AddressProd
	{
		private get { } //Length: 49
	}

	private static string GetMeHttpsUrl
	{
		private get { } //Length: 49
	}

	private static string GetMeHttpUrl
	{
		private get { } //Length: 49
	}

	private static string ProcessNSLookup
	{
		private get { } //Length: 49
	}

	private static string ProcessTracert
	{
		private get { } //Length: 49
	}

	private ConnectionDiagnostics(Logger logger) { }

	internal static ConnectionDiagnostics Create() { }

	private static string get_Address8888() { }

	private static string get_AddressProd() { }

	private static string get_GetMeHttpsUrl() { }

	private static string get_GetMeHttpUrl() { }

	private static string get_ProcessNSLookup() { }

	private static string get_ProcessTracert() { }

	[AsyncStateMachine(typeof(<Run>d__17))]
	internal Task Run(CancellationToken token) { }

	[AsyncStateMachine(typeof(<RunDiagnostics>d__18))]
	private Task RunDiagnostics(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Stop>d__19))]
	internal Task Stop() { }

}

