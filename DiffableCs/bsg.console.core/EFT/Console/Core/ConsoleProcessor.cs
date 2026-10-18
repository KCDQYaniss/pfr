namespace EFT.Console.Core;

public class ConsoleProcessor
{
	[CompilerGenerated]
	private sealed class <<CalculateAutoCompleteVariants>g__EnumerateChildren|0_5>d : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CommandItemBase <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private CommandItemGroup group; //Field offset: 0x28
		public CommandItemGroup <>3__group; //Field offset: 0x30
		private Enumerator <>7__wrap1; //Field offset: 0x38
		private CommandItemBase <child>5__3; //Field offset: 0x50
		private IEnumerator <>7__wrap3; //Field offset: 0x58

		private override CommandItemBase System.Collections.Generic.IEnumerator<EFT.Console.Core.CommandItemBase>.Current
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
		public <<CalculateAutoCompleteVariants>g__EnumerateChildren|0_5>d(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Console.Core.CommandItemBase>.GetEnumerator() { }

		[DebuggerHidden]
		private override CommandItemBase System.Collections.Generic.IEnumerator<EFT.Console.Core.CommandItemBase>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_7; //Field offset: 0x8
		public static Func <>9__0_8; //Field offset: 0x10
		public static Func <>9__0_13; //Field offset: 0x18
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"context", "reg"})]
		public static Func <>9__30_1; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"context", "reg"})]
		public static Func <>9__30_2; //Field offset: 0x28
		public static Func <>9__44_0; //Field offset: 0x30
		public static Comparison <>9__46_1; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal string <CalculateAutoCompleteVariants>b__0_13(CommandItemBase el) { }

		internal string <CalculateAutoCompleteVariants>b__0_7(CommandArgument a) { }

		internal string <CalculateAutoCompleteVariants>b__0_8(CommandArgument a) { }

		internal int <FindCommandGroup>b__46_1(CommandItemBase a, CommandItemBase b) { }

		internal CommandArgument <RegisterAnonymousCommand>b__44_0(Type a, int i) { }

		internal string <Schedule>b__30_1(ValueTuple el) { }

		internal CommandRegisterData <Schedule>b__30_2(ValueTuple el) { }

	}

	[CompilerGenerated]
	private sealed class <>c__37`1
	{
		public static readonly <>c__37 <>9; //Field offset: 0x0
		public static Func <>9__37_1; //Field offset: 0x0

		private static <>c__37`1() { }

		public <>c__37`1() { }

		internal int <RegisterCommand>b__37_1(CommandFactory a) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass0_0
	{
		public ConsoleProcessor <>4__this; //Field offset: 0x0
		public HashSet result; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_1
	{
		public SearchQuery query; //Field offset: 0x10

		public <>c__DisplayClass0_1() { }

		internal int <CalculateAutoCompleteVariants>b__10(CommandItemBase el) { }

		internal bool <CalculateAutoCompleteVariants>b__9(CommandItemBase el) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_2
	{
		public SearchQuery query; //Field offset: 0x10

		public <>c__DisplayClass0_2() { }

		internal bool <CalculateAutoCompleteVariants>b__11(CommandItemBase el) { }

		internal int <CalculateAutoCompleteVariants>b__12(CommandItemBase el) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public TaskCompletionSource complete; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal void <ExecuteAsync>g__OnComplete|0(Exception e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string uniqueKey; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal string <TempContextSwitcher>b__0(string ctx) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public CompleteCallback onCompleteEachCommand; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal CommandRegisterData <Schedule>b__0(IConsoleCommand cmd) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public CommandRegisterData reg; //Field offset: 0x10
		public ConsoleProcessor <>4__this; //Field offset: 0x20

		public <>c__DisplayClass34_0() { }

		internal string <MapSourceCommand>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public string context; //Field offset: 0x10
		public <>c__DisplayClass34_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass34_1() { }

		internal void <MapSourceCommand>b__1(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0`1
	{
		public ConstructorInfo ci; //Field offset: 0x0

		public <>c__DisplayClass37_0`1() { }

		internal IConsoleCommand <RegisterCommand>b__2(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0`1
	{
		public MethodInfo method; //Field offset: 0x0
		public ConsoleProcessor <>4__this; //Field offset: 0x0
		public Func <>9__3; //Field offset: 0x0
		public Action <>9__5; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal Task <RegisterCommandGroup>b__3(object[] a) { }

		internal void <RegisterCommandGroup>b__5(object[] a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_1`1
	{
		public string commandFullName; //Field offset: 0x0
		public <>c__DisplayClass38_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass38_1`1() { }

		internal IConsoleCommand <RegisterCommandGroup>b__0(object[] args) { }

		internal IConsoleCommand <RegisterCommandGroup>b__1(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_2`1
	{
		public object[] args; //Field offset: 0x0
		public <>c__DisplayClass38_1 CS$<>8__locals2; //Field offset: 0x0

		public <>c__DisplayClass38_2`1() { }

		internal string <RegisterCommandGroup>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_3`1
	{
		public object[] args; //Field offset: 0x0
		public <>c__DisplayClass38_1 CS$<>8__locals3; //Field offset: 0x0

		public <>c__DisplayClass38_3`1() { }

		internal string <RegisterCommandGroup>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public Action method; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal void <RegisterCommand>b__0(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0`1
	{
		public Action method; //Field offset: 0x0

		public <>c__DisplayClass40_0`1() { }

		internal void <RegisterCommand>b__0(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0`2
	{
		public Action method; //Field offset: 0x0

		public <>c__DisplayClass41_0`2() { }

		internal void <RegisterCommand>b__0(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0`3
	{
		public Action method; //Field offset: 0x0

		public <>c__DisplayClass42_0`3() { }

		internal void <RegisterCommand>b__0(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0`4
	{
		public Action method; //Field offset: 0x0

		public <>c__DisplayClass43_0`4() { }

		internal void <RegisterCommand>b__0(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public ConsoleProcessor <>4__this; //Field offset: 0x10
		public string commandFullName; //Field offset: 0x18
		public Action call; //Field offset: 0x20

		public <>c__DisplayClass44_0() { }

		internal IConsoleCommand <RegisterAnonymousCommand>b__1(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_1
	{
		public object[] args; //Field offset: 0x10
		public <>c__DisplayClass44_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass44_1() { }

		internal string <RegisterAnonymousCommand>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public string s; //Field offset: 0x10

		public <>c__DisplayClass46_0() { }

		internal bool <FindCommandGroup>b__0(CommandItemGroup el) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public Type commandType; //Field offset: 0x10
		public ConsoleProcessor <>4__this; //Field offset: 0x18
		public CommandItemGroup group; //Field offset: 0x20
		public CommandItemInfo command; //Field offset: 0x28

		public <>c__DisplayClass47_0() { }

		internal void <AddCommand>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public ConsoleProcessor <>4__this; //Field offset: 0x10
		public ExecutionContext ec; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <CreateExecutionContext>b__0(IConsoleCommand command) { }

		internal void <CreateExecutionContext>b__1(IConsoleCommand command) { }

		internal void <CreateExecutionContext>b__2(IConsoleCommand command) { }

		internal void <CreateExecutionContext>b__3(IConsoleCommand command, Exception err) { }

	}

	[CompilerGenerated]
	private struct <ExecuteAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConsoleProcessor <>4__this; //Field offset: 0x20
		public IConsoleCommand command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <MapSourceCommand>d__34 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"context", "reg"})]
		private ValueTuple <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x30
		private CommandRegisterData[] data; //Field offset: 0x38
		public CommandRegisterData[] <>3__data; //Field offset: 0x40
		public ConsoleProcessor <>4__this; //Field offset: 0x48
		private CommandRegisterData[] <>7__wrap1; //Field offset: 0x50
		private int <>7__wrap2; //Field offset: 0x58

		private override ValueTuple System.Collections.Generic.IEnumerator<(System.Stringcontext,EFT.Console.Core.CommandRegisterDatareg)>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 85
		}

		[DebuggerHidden]
		public <MapSourceCommand>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<(System.Stringcontext,EFT.Console.Core.CommandRegisterDatareg)>.GetEnumerator() { }

		[DebuggerHidden]
		private override ValueTuple System.Collections.Generic.IEnumerator<(System.Stringcontext,EFT.Console.Core.CommandRegisterDatareg)>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class ArgumentDeserializer : MulticastDelegate
	{

		public ArgumentDeserializer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string argument, AsyncCallback callback, object object) { }

		public override object EndInvoke(IAsyncResult result) { }

		public override object Invoke(string argument) { }

	}

	internal sealed class ArgumentSerializer : MulticastDelegate
	{

		public ArgumentSerializer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object argument, AsyncCallback callback, object object) { }

		public override string EndInvoke(IAsyncResult result) { }

		public override string Invoke(object argument) { }

	}

	internal sealed class AsyncCommandFactory : MulticastDelegate
	{

		public AsyncCommandFactory(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object[] arguments, AsyncCallback callback, object object) { }

		public override IConsoleCommand EndInvoke(IAsyncResult result) { }

		public override IConsoleCommand Invoke(object[] arguments) { }

	}

	private static readonly Type TASK_TYPE; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSchedule; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnExecuteStart; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnExecuteSuccess; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnExecuteFailed; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ConsoleSerializer <Serializer>k__BackingField; //Field offset: 0x30
	private readonly CommandItemGroup _root; //Field offset: 0x38
	private readonly Dictionary _executionContexts; //Field offset: 0x40
	private readonly Dictionary _commands; //Field offset: 0x48

	public event Action OnExecuteFailed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnExecuteStart
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnExecuteSuccess
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSchedule
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IEnumerable ExecutionContexts
	{
		 get { } //Length: 223
	}

	public ConsoleSerializer Serializer
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	private static ConsoleProcessor() { }

	public ConsoleProcessor() { }

	[CompilerGenerated]
	private void <CalculateAutoCompleteVariants>g__AddResult|0_0(CommandItemBase anyItem, CommandFactory foundFactory, ref <>c__DisplayClass0_0 unnamed_param_2) { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<CalculateAutoCompleteVariants>g__EnumerateChildren|0_5>d))]
	internal static IEnumerable <CalculateAutoCompleteVariants>g__EnumerateChildren|0_5(CommandItemGroup group) { }

	[CompilerGenerated]
	internal static int <CalculateAutoCompleteVariants>g__GetBestCommandScore|0_3(CommandItemBase item, SearchQuery query) { }

	[CompilerGenerated]
	internal static int <CalculateAutoCompleteVariants>g__GetBestNameScore|0_4(CommandItemBase item, SearchQuery query) { }

	[CompilerGenerated]
	internal static string <CalculateAutoCompleteVariants>g__GetLastCommandInput|0_6(string rawInput) { }

	[CompilerGenerated]
	private void <CalculateAutoCompleteVariants>g__ProcessGlobalSearch|0_2(SearchQuery query, int limit, ref <>c__DisplayClass0_0 unnamed_param_2) { }

	[CompilerGenerated]
	private int <CalculateAutoCompleteVariants>g__ProcessGroup|0_1(CommandItemGroup cg, SearchQuery query, int limit, ref <>c__DisplayClass0_0 unnamed_param_3) { }

	[CompilerGenerated]
	private string <GenerateOriginalInput>b__49_0(object arg) { }

	[CompilerGenerated]
	private CommandArgument <ParseMethodArguments>b__45_0(ParameterInfo pi) { }

	[CompilerGenerated]
	private CommandFactory <RegisterCommand>b__37_0(ConstructorInfo ci) { }

	[CompilerGenerated]
	public void add_OnExecuteFailed(Action value) { }

	[CompilerGenerated]
	public void add_OnExecuteStart(Action value) { }

	[CompilerGenerated]
	public void add_OnExecuteSuccess(Action value) { }

	[CompilerGenerated]
	public void add_OnSchedule(Action value) { }

	private Action AddCommand(CommandItemGroup group, CommandItemInfo command, Type commandType = null) { }

	public AutoCompleteItem[] CalculateAutoCompleteVariants(string input, int countLimit = 15) { }

	private void CreateExecutionContext(string name) { }

	public void Execute(IConsoleCommand command, CompleteCallback onComplete = null) { }

	[AsyncStateMachine(typeof(<ExecuteAsync>d__27))]
	public Task ExecuteAsync(IConsoleCommand command) { }

	public void ExecuteImmediately(IEnumerable commands) { }

	private ValueTuple FindCommandGroup(string fullName) { }

	private CommandItemInfo FindCommandInfo(IConsoleCommand cmd) { }

	private string GenerateFullCommandDoc(CommandItemBase command, CommandArgument[] factoryArgumentList) { }

	private string GenerateOriginalInput(string commandFullName, IEnumerable args) { }

	public IEnumerable get_ExecutionContexts() { }

	[CompilerGenerated]
	public ConsoleSerializer get_Serializer() { }

	[IteratorStateMachine(typeof(<MapSourceCommand>d__34))]
	private IEnumerable MapSourceCommand(CommandRegisterData[] data) { }

	public ValueTuple[] Parse(string command) { }

	private CommandArgument[] ParseMethodArguments(ParameterInfo[] parameters) { }

	private ConstructorFindResult[] ParseRaw(string command) { }

	public string PrintCommand(IConsoleCommand cmd) { }

	private Action RegisterAnonymousCommand(string commandFullName, Type[] inputArguments, Action call, string description = null) { }

	public Action RegisterCommand(string commandFullName, Action method) { }

	public Action RegisterCommand(string commandFullName, Action method) { }

	public Action RegisterCommand(string commandFullName, Action method) { }

	public Action RegisterCommand(string commandFullName, Action method, string description = null) { }

	public Action RegisterCommand(string commandFullName, Action method, string description = null) { }

	public Action RegisterCommand() { }

	public Action RegisterCommandGroup() { }

	[CompilerGenerated]
	public void remove_OnExecuteFailed(Action value) { }

	[CompilerGenerated]
	public void remove_OnExecuteStart(Action value) { }

	[CompilerGenerated]
	public void remove_OnExecuteSuccess(Action value) { }

	[CompilerGenerated]
	public void remove_OnSchedule(Action value) { }

	public void RemoveExecutionContext(string name) { }

	public void Schedule(ERegisterMode registerMode, IEnumerable commands, CompleteCallback onCompleteEachCommand = null, Func contextSwitcher = null) { }

	public Func TempContextSwitcher() { }

}

