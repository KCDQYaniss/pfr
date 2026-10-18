namespace Diz.Utils;

[Extension]
public static class LinqExtensions
{
	[CompilerGenerated]
	private sealed class <>c__0`1
	{
		public static readonly <>c__0 <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x0

		private static <>c__0`1() { }

		public <>c__0`1() { }

		internal IEnumerable <Flatten>b__0_0(IEnumerable i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0`1
	{
		public Func f; //Field offset: 0x0

		public <>c__DisplayClass1_0`1() { }

		internal IEnumerable <Flatten>b__0(T c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0`1
	{
		public Func f; //Field offset: 0x0

		public <>c__DisplayClass2_0`1() { }

		internal IEnumerable <FlattenWithoutArray>b__0(T c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0`1
	{
		public Func f; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal IEnumerable <FlattenDepthFirst>b__0(T c) { }

	}

	[CompilerGenerated]
	private sealed class <Distinct>d__6`2 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Func keySelector; //Field offset: 0x0
		public Func <>3__keySelector; //Field offset: 0x0
		private HashSet <hashset>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <Distinct>d__6`2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	private sealed class <Recurse>d__5`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private T value; //Field offset: 0x0
		public T <>3__value; //Field offset: 0x0
		private Func recurse; //Field offset: 0x0
		public Func <>3__recurse; //Field offset: 0x0
		private Func condition; //Field offset: 0x0
		public Func <>3__condition; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 172
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 171
		}

		[DebuggerHidden]
		public <Recurse>d__5`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	private sealed class <ToEnumerable>d__4`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private T val; //Field offset: 0x0
		public T <>3__val; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 41
		}

		[DebuggerHidden]
		public <ToEnumerable>d__4`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	[IteratorStateMachine(typeof(<Distinct>d__6`2))]
	public static IEnumerable Distinct(IEnumerable source, Func keySelector) { }

	[Extension]
	public static IEnumerable Flatten(IEnumerable e) { }

	[Extension]
	public static IEnumerable Flatten(IEnumerable e, Func f) { }

	[Extension]
	public static IEnumerable FlattenDepthFirst(IEnumerable e, Func f) { }

	[Extension]
	public static IEnumerable FlattenWithoutArray(IEnumerable e, Func f) { }

	[Extension]
	public static T Random(IEnumerable source) { }

	[Extension]
	[IteratorStateMachine(typeof(<Recurse>d__5`1))]
	public static IEnumerable Recurse(T value, Func recurse, Func condition) { }

	[Extension]
	[IteratorStateMachine(typeof(<ToEnumerable>d__4`1))]
	public static IEnumerable ToEnumerable(T val) { }

}

