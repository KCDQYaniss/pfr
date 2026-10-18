namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[Extension]
internal static class EXPRExtensions
{
	[CompilerGenerated]
	private sealed class <ToEnumerable>d__1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private Expr <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Expr expr; //Field offset: 0x28
		public Expr <>3__expr; //Field offset: 0x30
		private ExprList <list>5__2; //Field offset: 0x38

		private override Expr System.Collections.Generic.IEnumerator<Microsoft.CSharp.RuntimeBinder.Semantics.Expr>.Current
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
		public <ToEnumerable>d__1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<Microsoft.CSharp.RuntimeBinder.Semantics.Expr>.GetEnumerator() { }

		[DebuggerHidden]
		private override Expr System.Collections.Generic.IEnumerator<Microsoft.CSharp.RuntimeBinder.Semantics.Expr>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	public static Expr GetConst(Expr expr) { }

	[Extension]
	private static Expr GetSeqVal(Expr expr) { }

	[Extension]
	public static bool isChecked(Expr expr) { }

	[Extension]
	public static bool isLvalue(Expr expr) { }

	[Extension]
	public static bool isNull(Expr expr) { }

	[Extension]
	public static bool IsZero(Expr expr) { }

	[Extension]
	public static Expr Map(Expr expr, Func f) { }

	[Extension]
	[IteratorStateMachine(typeof(<ToEnumerable>d__1))]
	public static IEnumerable ToEnumerable(Expr expr) { }

}

