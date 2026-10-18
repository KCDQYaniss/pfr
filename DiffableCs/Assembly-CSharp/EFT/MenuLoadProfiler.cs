namespace EFT;

public static class MenuLoadProfiler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_1; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_2; //Field offset: 0x18
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_3; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_4; //Field offset: 0x28
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_5; //Field offset: 0x30
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"r", "i"})]
		public static Func <>9__21_6; //Field offset: 0x38
		public static Func <>9__21_7; //Field offset: 0x40
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Name", "Duration", "Unfinished"})]
		public static Func <>9__21_9; //Field offset: 0x48
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Name", "Duration", "Unfinished"})]
		public static Func <>9__21_10; //Field offset: 0x50
		public static Func <>9__21_11; //Field offset: 0x58
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Name", "Overlap"})]
		public static Func <>9__21_13; //Field offset: 0x60
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Name", "Overlap"})]
		public static Func <>9__21_14; //Field offset: 0x68

		private static <>c() { }

		public <>c() { }

		internal ValueTuple <BuildReport>b__21_0(Record r, int i) { }

		internal double <BuildReport>b__21_1(ValueTuple x) { }

		internal double <BuildReport>b__21_10(ValueTuple x) { }

		internal bool <BuildReport>b__21_11(Record r) { }

		internal bool <BuildReport>b__21_13(ValueTuple x) { }

		internal double <BuildReport>b__21_14(ValueTuple x) { }

		internal bool <BuildReport>b__21_2(ValueTuple x) { }

		internal bool <BuildReport>b__21_3(ValueTuple x) { }

		internal bool <BuildReport>b__21_4(ValueTuple x) { }

		internal bool <BuildReport>b__21_5(ValueTuple x) { }

		internal bool <BuildReport>b__21_6(ValueTuple x) { }

		internal bool <BuildReport>b__21_7(Record r) { }

		internal bool <BuildReport>b__21_9(ValueTuple x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public double nowMs; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal ValueTuple <BuildReport>b__8(Record r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_1
	{
		public double interactiveMs; //Field offset: 0x10
		public <>c__DisplayClass21_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass21_1() { }

		internal ValueTuple <BuildReport>b__12(Record r) { }

	}

	[CompilerGenerated]
	private sealed class <Co_MarkEndOfFrame>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string name; //Field offset: 0x20

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
		public <Co_MarkEndOfFrame>d__23(int <>1__state) { }

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
	private sealed class <Co_MarkNextFrame>d__22 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string name; //Field offset: 0x20

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
		public <Co_MarkNextFrame>d__22(int <>1__state) { }

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

	private struct Record
	{
		public string Name; //Field offset: 0x0
		public double StartMs; //Field offset: 0x8
		public double EndMs; //Field offset: 0x10
		public bool IsMark; //Field offset: 0x18

	}

	private sealed class ScopeToken : IDisposable
	{
		private readonly int _index; //Field offset: 0x10
		private bool _disposed; //Field offset: 0x14

		public ScopeToken(int index) { }

		public override void Dispose() { }

	}

	private const double MIN_REPORTED_INTERVAL_MS = 100; //Field offset: 0x0
	private static readonly object Sync; //Field offset: 0x0
	private static Stopwatch _sw; //Field offset: 0x8
	private static List _entries; //Field offset: 0x10
	private static bool _reportRequested; //Field offset: 0x18
	private static bool _reportPrinted; //Field offset: 0x19

	private static MenuLoadProfiler() { }

	private static void AddMarkNoLock(string name) { }

	public static IDisposable Begin(string name) { }

	private static string BuildReport(List snapshot, double totalMs) { }

	[IteratorStateMachine(typeof(<Co_MarkEndOfFrame>d__23))]
	private static IEnumerator Co_MarkEndOfFrame(string name) { }

	[IteratorStateMachine(typeof(<Co_MarkNextFrame>d__22))]
	private static IEnumerator Co_MarkNextFrame(string name) { }

	private static void EnsureInitializedNoLock() { }

	private static bool HasMarkNoLock(string name) { }

	private static bool HasUnfinishedIntervalsNoLock() { }

	public static void Mark(string name) { }

	public static void MarkEndOfFrame(string name) { }

	public static void MarkNextFrame(string name) { }

	public static void PrintReport() { }

	public static void RequestReport(string milestoneName = null) { }

	public static void Reset() { }

	public static void StartFlow(string startMarkName) { }

	private static string TryBuildRequestedReportNoLock() { }

}

