namespace EFT.NextObservedPlayer;

public class CommandMessageAutoSender
{
	[CompilerGenerated]
	private struct <StartCommandChecker>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CommandMessageAutoSender <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <StartCommandCheckerCoroutine>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CommandMessageAutoSender <>4__this; //Field offset: 0x20

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
		public <StartCommandCheckerCoroutine>d__23(int <>1__state) { }

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

	internal class BoolChecker : IChecker
	{
		private bool _lastValue; //Field offset: 0x10
		private bool _currentValue; //Field offset: 0x11
		private Func _originValueGetter; //Field offset: 0x18

		public BoolChecker(Func valueGetter) { }

		public override bool IsChanged() { }

	}

	internal class Checker`1 : IChecker
	{
		private T _lastValue; //Field offset: 0x0
		private T _currentValue; //Field offset: 0x0
		private Func _originValueGetter; //Field offset: 0x0

		public Checker`1(Func valueGetter) { }

		protected override bool CompareValues() { }

		public override bool IsChanged() { }

	}

	internal class EnumChecker`1 : IChecker
	{
		private T _lastValue; //Field offset: 0x0
		private T _currentValue; //Field offset: 0x0
		private Func _originValueGetter; //Field offset: 0x0

		public EnumChecker`1(Func valueGetter) { }

		protected override bool CompareValues() { }

		public override bool IsChanged() { }

	}

	internal class FloatChecker : IChecker
	{
		private float _lastValue; //Field offset: 0x10
		private float _currentValue; //Field offset: 0x14
		private Func _originValueGetter; //Field offset: 0x18

		public FloatChecker(Func valueGetter) { }

		public override bool IsChanged() { }

	}

	internal interface IChecker
	{

		public bool IsChanged() { }

	}

	[CompilerGenerated]
	private Func _checkCreateCommand; //Field offset: 0x10
	[CompilerGenerated]
	private Action _createCommandAction; //Field offset: 0x18
	private CancellationTokenSource _cancellationToken; //Field offset: 0x20
	private List _checkers; //Field offset: 0x28

	private event Func _checkCreateCommand
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	private event Action _createCommandAction
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public CommandMessageAutoSender(Action createCommandAction) { }

	[CompilerGenerated]
	private void add__checkCreateCommand(Func value) { }

	[CompilerGenerated]
	private void add__createCommandAction(Action value) { }

	public void AddBoolChecker(Func boolGetter) { }

	public void AddChecker(Func floatGetter) { }

	public void AddEnumChecker(Func boolGetter) { }

	public void AddFloatChecker(Func floatGetter) { }

	public void Dispose() { }

	public void ForceCreateCommand() { }

	public void ManualCheck() { }

	private bool NeedToCreateCommand() { }

	[CompilerGenerated]
	private void remove__checkCreateCommand(Func value) { }

	[CompilerGenerated]
	private void remove__createCommandAction(Action value) { }

	public void RunTaskChecker() { }

	[AsyncStateMachine(typeof(<StartCommandChecker>d__22))]
	private Task StartCommandChecker() { }

	[IteratorStateMachine(typeof(<StartCommandCheckerCoroutine>d__23))]
	public IEnumerator StartCommandCheckerCoroutine() { }

}

