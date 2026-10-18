namespace System.Linq;

[Extension]
public static class Enumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0`1
	{
		public Func predicate1; //Field offset: 0x0
		public Func predicate2; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		internal bool <CombinePredicates>b__0(TSource x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0`3
	{
		public Func selector2; //Field offset: 0x0
		public Func selector1; //Field offset: 0x0

		public <>c__DisplayClass7_0`3() { }

		internal TResult <CombineSelectors>b__0(TSource x) { }

	}

	[CompilerGenerated]
	private sealed class <AppendIterator>d__61`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private TSource element; //Field offset: 0x0
		public TSource <>3__element; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 42
		}

		[DebuggerHidden]
		public <AppendIterator>d__61`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <CastIterator>d__99`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 42
		}

		[DebuggerHidden]
		public <CastIterator>d__99`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[DebuggerHidden]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

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
	private sealed class <ConcatIterator>d__59`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable first; //Field offset: 0x0
		public IEnumerable <>3__first; //Field offset: 0x0
		private IEnumerable second; //Field offset: 0x0
		public IEnumerable <>3__second; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 43
		}

		[DebuggerHidden]
		public <ConcatIterator>d__59`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <DistinctIterator>d__68`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer comparer; //Field offset: 0x0
		public IEqualityComparer <>3__comparer; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Set <set>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 43
		}

		[DebuggerHidden]
		public <DistinctIterator>d__68`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <ExceptIterator>d__77`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer comparer; //Field offset: 0x0
		public IEqualityComparer <>3__comparer; //Field offset: 0x0
		private IEnumerable second; //Field offset: 0x0
		public IEnumerable <>3__second; //Field offset: 0x0
		private IEnumerable first; //Field offset: 0x0
		public IEnumerable <>3__first; //Field offset: 0x0
		private Set <set>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <ExceptIterator>d__77`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <IntersectIterator>d__74`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer comparer; //Field offset: 0x0
		public IEqualityComparer <>3__comparer; //Field offset: 0x0
		private IEnumerable second; //Field offset: 0x0
		public IEnumerable <>3__second; //Field offset: 0x0
		private IEnumerable first; //Field offset: 0x0
		public IEnumerable <>3__first; //Field offset: 0x0
		private Set <set>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <IntersectIterator>d__74`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <OfTypeIterator>d__97`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
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
		public <OfTypeIterator>d__97`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[DebuggerHidden]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

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
	private sealed class <PrependIterator>d__63`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private TSource element; //Field offset: 0x0
		public TSource <>3__element; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <PrependIterator>d__63`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <RangeIterator>d__115 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private int start; //Field offset: 0x1C
		public int <>3__start; //Field offset: 0x20
		private int count; //Field offset: 0x24
		public int <>3__count; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x2C

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <RangeIterator>d__115(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

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
	private sealed class <RepeatIterator>d__117`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private TResult element; //Field offset: 0x0
		public TResult <>3__element; //Field offset: 0x0
		private int count; //Field offset: 0x0
		public int <>3__count; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 42
		}

		[DebuggerHidden]
		public <RepeatIterator>d__117`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[DebuggerHidden]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

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
	private sealed class <ReverseIterator>d__79`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Buffer <buffer>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <ReverseIterator>d__79`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <SelectIterator>d__5`2 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Func selector; //Field offset: 0x0
		public Func <>3__selector; //Field offset: 0x0
		private int <index>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
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
		public <SelectIterator>d__5`2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[DebuggerHidden]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

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
	private sealed class <SelectManyIterator>d__17`2 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Func selector; //Field offset: 0x0
		public Func <>3__selector; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
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
		public <SelectManyIterator>d__17`2(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[DebuggerHidden]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

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
	private sealed class <SkipIterator>d__31`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private int count; //Field offset: 0x0
		public int <>3__count; //Field offset: 0x0
		private IEnumerator <e>5__2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <SkipIterator>d__31`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <TakeIterator>d__25`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private int count; //Field offset: 0x0
		public int <>3__count; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 43
		}

		[DebuggerHidden]
		public <TakeIterator>d__25`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <UnionIterator>d__71`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer comparer; //Field offset: 0x0
		public IEqualityComparer <>3__comparer; //Field offset: 0x0
		private IEnumerable first; //Field offset: 0x0
		public IEnumerable <>3__first; //Field offset: 0x0
		private IEnumerable second; //Field offset: 0x0
		public IEnumerable <>3__second; //Field offset: 0x0
		private Set <set>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 43
		}

		[DebuggerHidden]
		public <UnionIterator>d__71`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <WhereIterator>d__2`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		public Func <>3__predicate; //Field offset: 0x0
		private int <index>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <WhereIterator>d__2`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

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
	private sealed class <ZipIterator>d__65`3 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable first; //Field offset: 0x0
		public IEnumerable <>3__first; //Field offset: 0x0
		private IEnumerable second; //Field offset: 0x0
		public IEnumerable <>3__second; //Field offset: 0x0
		private Func resultSelector; //Field offset: 0x0
		public Func <>3__resultSelector; //Field offset: 0x0
		private IEnumerator <e1>5__2; //Field offset: 0x0
		private IEnumerator <e2>5__3; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 42
		}

		[DebuggerHidden]
		public <ZipIterator>d__65`3(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[DebuggerHidden]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private abstract class Iterator`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int threadId; //Field offset: 0x0
		internal int state; //Field offset: 0x0
		internal TSource current; //Field offset: 0x0

		public override TSource Current
		{
			 get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 54
		}

		public Iterator`1() { }

		public abstract Iterator Clone() { }

		public override void Dispose() { }

		public override TSource get_Current() { }

		public override IEnumerator GetEnumerator() { }

		public abstract bool MoveNext() { }

		public abstract IEnumerable Select(Func selector) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		public abstract IEnumerable Where(Func predicate) { }

	}

	private class WhereArrayIterator`1 : Iterator
	{
		private TSource[] source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		private int index; //Field offset: 0x0

		public WhereArrayIterator`1(TSource[] source, Func predicate) { }

		public virtual Iterator Clone() { }

		public virtual bool MoveNext() { }

		public virtual IEnumerable Select(Func selector) { }

		public virtual IEnumerable Where(Func predicate) { }

	}

	private class WhereEnumerableIterator`1 : Iterator
	{
		private IEnumerable source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		private IEnumerator enumerator; //Field offset: 0x0

		public WhereEnumerableIterator`1(IEnumerable source, Func predicate) { }

		public virtual Iterator Clone() { }

		public virtual void Dispose() { }

		public virtual bool MoveNext() { }

		public virtual IEnumerable Select(Func selector) { }

		public virtual IEnumerable Where(Func predicate) { }

	}

	private class WhereListIterator`1 : Iterator
	{
		private List source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		private Enumerator enumerator; //Field offset: 0x0

		public WhereListIterator`1(List source, Func predicate) { }

		public virtual Iterator Clone() { }

		public virtual bool MoveNext() { }

		public virtual IEnumerable Select(Func selector) { }

		public virtual IEnumerable Where(Func predicate) { }

	}

	private class WhereSelectArrayIterator`2 : Iterator
	{
		private TSource[] source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		private Func selector; //Field offset: 0x0
		private int index; //Field offset: 0x0

		public WhereSelectArrayIterator`2(TSource[] source, Func predicate, Func selector) { }

		public virtual Iterator Clone() { }

		public virtual bool MoveNext() { }

		public virtual IEnumerable Select(Func selector) { }

		public virtual IEnumerable Where(Func predicate) { }

	}

	private class WhereSelectEnumerableIterator`2 : Iterator
	{
		private IEnumerable source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		private Func selector; //Field offset: 0x0
		private IEnumerator enumerator; //Field offset: 0x0

		public WhereSelectEnumerableIterator`2(IEnumerable source, Func predicate, Func selector) { }

		public virtual Iterator Clone() { }

		public virtual void Dispose() { }

		public virtual bool MoveNext() { }

		public virtual IEnumerable Select(Func selector) { }

		public virtual IEnumerable Where(Func predicate) { }

	}

	private class WhereSelectListIterator`2 : Iterator
	{
		private List source; //Field offset: 0x0
		private Func predicate; //Field offset: 0x0
		private Func selector; //Field offset: 0x0
		private Enumerator enumerator; //Field offset: 0x0

		public WhereSelectListIterator`2(List source, Func predicate, Func selector) { }

		public virtual Iterator Clone() { }

		public virtual bool MoveNext() { }

		public virtual IEnumerable Select(Func selector) { }

		public virtual IEnumerable Where(Func predicate) { }

	}


	[Extension]
	public static TSource Aggregate(IEnumerable source, Func func) { }

	[Extension]
	public static TAccumulate Aggregate(IEnumerable source, TAccumulate seed, Func func) { }

	[Extension]
	public static TResult Aggregate(IEnumerable source, TAccumulate seed, Func func, Func resultSelector) { }

	[Extension]
	public static bool All(IEnumerable source, Func predicate) { }

	[Extension]
	public static bool Any(IEnumerable source, Func predicate) { }

	[Extension]
	public static bool Any(IEnumerable source) { }

	[Extension]
	public static IEnumerable Append(IEnumerable source, TSource element) { }

	[IteratorStateMachine(typeof(<AppendIterator>d__61`1))]
	private static IEnumerable AppendIterator(IEnumerable source, TSource element) { }

	[Extension]
	public static double Average(IEnumerable source) { }

	[Extension]
	public static double Average(IEnumerable source) { }

	[Extension]
	public static double Average(IEnumerable source, Func selector) { }

	[Extension]
	public static double Average(IEnumerable source, Func selector) { }

	[Extension]
	public static float Average(IEnumerable source) { }

	[Extension]
	public static float Average(IEnumerable source, Func selector) { }

	[Extension]
	public static IEnumerable Cast(IEnumerable source) { }

	[IteratorStateMachine(typeof(<CastIterator>d__99`1))]
	private static IEnumerable CastIterator(IEnumerable source) { }

	private static Func CombinePredicates(Func predicate1, Func predicate2) { }

	private static Func CombineSelectors(Func selector1, Func selector2) { }

	[Extension]
	public static IEnumerable Concat(IEnumerable first, IEnumerable second) { }

	[IteratorStateMachine(typeof(<ConcatIterator>d__59`1))]
	private static IEnumerable ConcatIterator(IEnumerable first, IEnumerable second) { }

	[Extension]
	public static bool Contains(IEnumerable source, TSource value) { }

	[Extension]
	public static bool Contains(IEnumerable source, TSource value, IEqualityComparer comparer) { }

	[Extension]
	public static int Count(IEnumerable source, Func predicate) { }

	[Extension]
	public static int Count(IEnumerable source) { }

	[Extension]
	public static IEnumerable Distinct(IEnumerable source, IEqualityComparer comparer) { }

	[Extension]
	public static IEnumerable Distinct(IEnumerable source) { }

	[IteratorStateMachine(typeof(<DistinctIterator>d__68`1))]
	private static IEnumerable DistinctIterator(IEnumerable source, IEqualityComparer comparer) { }

	[Extension]
	public static TSource ElementAt(IEnumerable source, int index) { }

	[Extension]
	public static TSource ElementAtOrDefault(IEnumerable source, int index) { }

	public static IEnumerable Empty() { }

	[Extension]
	public static IEnumerable Except(IEnumerable first, IEnumerable second) { }

	[IteratorStateMachine(typeof(<ExceptIterator>d__77`1))]
	private static IEnumerable ExceptIterator(IEnumerable first, IEnumerable second, IEqualityComparer comparer) { }

	[Extension]
	public static TSource First(IEnumerable source, Func predicate) { }

	[Extension]
	public static TSource First(IEnumerable source) { }

	[Extension]
	public static TSource FirstOrDefault(IEnumerable source, Func predicate) { }

	[Extension]
	public static TSource FirstOrDefault(IEnumerable source) { }

	[Extension]
	public static IEnumerable GroupBy(IEnumerable source, Func keySelector) { }

	[Extension]
	public static IEnumerable Intersect(IEnumerable first, IEnumerable second, IEqualityComparer comparer) { }

	[Extension]
	public static IEnumerable Intersect(IEnumerable first, IEnumerable second) { }

	[IteratorStateMachine(typeof(<IntersectIterator>d__74`1))]
	private static IEnumerable IntersectIterator(IEnumerable first, IEnumerable second, IEqualityComparer comparer) { }

	[Extension]
	public static TSource Last(IEnumerable source) { }

	[Extension]
	public static TSource LastOrDefault(IEnumerable source, Func predicate) { }

	[Extension]
	public static TSource LastOrDefault(IEnumerable source) { }

	[Extension]
	public static int Max(IEnumerable source) { }

	[Extension]
	public static float Max(IEnumerable source, Func selector) { }

	[Extension]
	public static long Max(IEnumerable source) { }

	[Extension]
	public static double Max(IEnumerable source) { }

	[Extension]
	public static float Max(IEnumerable source) { }

	[Extension]
	public static TSource Max(IEnumerable source) { }

	[Extension]
	public static int Max(IEnumerable source, Func selector) { }

	[Extension]
	public static TResult Max(IEnumerable source, Func selector) { }

	[Extension]
	public static TResult Min(IEnumerable source, Func selector) { }

	[Extension]
	public static float Min(IEnumerable source, Func selector) { }

	[Extension]
	public static int Min(IEnumerable source, Func selector) { }

	[Extension]
	public static TSource Min(IEnumerable source) { }

	[Extension]
	public static float Min(IEnumerable source) { }

	[Extension]
	public static long Min(IEnumerable source) { }

	[Extension]
	public static int Min(IEnumerable source) { }

	[Extension]
	public static IEnumerable OfType(IEnumerable source) { }

	[IteratorStateMachine(typeof(<OfTypeIterator>d__97`1))]
	private static IEnumerable OfTypeIterator(IEnumerable source) { }

	[Extension]
	public static IOrderedEnumerable OrderBy(IEnumerable source, Func keySelector, IComparer comparer) { }

	[Extension]
	public static IOrderedEnumerable OrderBy(IEnumerable source, Func keySelector) { }

	[Extension]
	public static IOrderedEnumerable OrderByDescending(IEnumerable source, Func keySelector, IComparer comparer) { }

	[Extension]
	public static IOrderedEnumerable OrderByDescending(IEnumerable source, Func keySelector) { }

	[Extension]
	public static IEnumerable Prepend(IEnumerable source, TSource element) { }

	[IteratorStateMachine(typeof(<PrependIterator>d__63`1))]
	private static IEnumerable PrependIterator(IEnumerable source, TSource element) { }

	public static IEnumerable Range(int start, int count) { }

	[IteratorStateMachine(typeof(<RangeIterator>d__115))]
	private static IEnumerable RangeIterator(int start, int count) { }

	public static IEnumerable Repeat(TResult element, int count) { }

	[IteratorStateMachine(typeof(<RepeatIterator>d__117`1))]
	private static IEnumerable RepeatIterator(TResult element, int count) { }

	[Extension]
	public static IEnumerable Reverse(IEnumerable source) { }

	[IteratorStateMachine(typeof(<ReverseIterator>d__79`1))]
	private static IEnumerable ReverseIterator(IEnumerable source) { }

	[Extension]
	public static IEnumerable Select(IEnumerable source, Func selector) { }

	[Extension]
	public static IEnumerable Select(IEnumerable source, Func selector) { }

	[IteratorStateMachine(typeof(<SelectIterator>d__5`2))]
	private static IEnumerable SelectIterator(IEnumerable source, Func selector) { }

	[Extension]
	public static IEnumerable SelectMany(IEnumerable source, Func selector) { }

	[IteratorStateMachine(typeof(<SelectManyIterator>d__17`2))]
	private static IEnumerable SelectManyIterator(IEnumerable source, Func selector) { }

	[Extension]
	public static bool SequenceEqual(IEnumerable first, IEnumerable second, IEqualityComparer comparer) { }

	[Extension]
	public static bool SequenceEqual(IEnumerable first, IEnumerable second) { }

	[Extension]
	public static TSource Single(IEnumerable source, Func predicate) { }

	[Extension]
	public static TSource Single(IEnumerable source) { }

	[Extension]
	public static TSource SingleOrDefault(IEnumerable source) { }

	[Extension]
	public static TSource SingleOrDefault(IEnumerable source, Func predicate) { }

	[Extension]
	public static IEnumerable Skip(IEnumerable source, int count) { }

	[IteratorStateMachine(typeof(<SkipIterator>d__31`1))]
	private static IEnumerable SkipIterator(IEnumerable source, int count) { }

	[Extension]
	public static double Sum(IEnumerable source, Func selector) { }

	[Extension]
	public static float Sum(IEnumerable source, Func selector) { }

	[Extension]
	public static int Sum(IEnumerable source) { }

	[Extension]
	public static int Sum(IEnumerable source, Func selector) { }

	[Extension]
	public static double Sum(IEnumerable source) { }

	[Extension]
	public static float Sum(IEnumerable source) { }

	[Extension]
	public static long Sum(IEnumerable source) { }

	[Extension]
	public static long Sum(IEnumerable source, Func selector) { }

	[Extension]
	public static IEnumerable Take(IEnumerable source, int count) { }

	[IteratorStateMachine(typeof(<TakeIterator>d__25`1))]
	private static IEnumerable TakeIterator(IEnumerable source, int count) { }

	[Extension]
	public static IOrderedEnumerable ThenBy(IOrderedEnumerable source, Func keySelector) { }

	[Extension]
	public static IOrderedEnumerable ThenBy(IOrderedEnumerable source, Func keySelector, IComparer comparer) { }

	[Extension]
	public static IOrderedEnumerable ThenByDescending(IOrderedEnumerable source, Func keySelector) { }

	[Extension]
	public static TSource[] ToArray(IEnumerable source) { }

	[Extension]
	public static Dictionary ToDictionary(IEnumerable source, Func keySelector) { }

	[Extension]
	public static Dictionary ToDictionary(IEnumerable source, Func keySelector, Func elementSelector) { }

	[Extension]
	public static Dictionary ToDictionary(IEnumerable source, Func keySelector, Func elementSelector, IEqualityComparer comparer) { }

	[Extension]
	public static HashSet ToHashSet(IEnumerable source, IEqualityComparer comparer) { }

	[Extension]
	public static HashSet ToHashSet(IEnumerable source) { }

	[Extension]
	public static List ToList(IEnumerable source) { }

	[Extension]
	public static IEnumerable Union(IEnumerable first, IEnumerable second) { }

	[IteratorStateMachine(typeof(<UnionIterator>d__71`1))]
	private static IEnumerable UnionIterator(IEnumerable first, IEnumerable second, IEqualityComparer comparer) { }

	[Extension]
	public static IEnumerable Where(IEnumerable source, Func predicate) { }

	[Extension]
	public static IEnumerable Where(IEnumerable source, Func predicate) { }

	[IteratorStateMachine(typeof(<WhereIterator>d__2`1))]
	private static IEnumerable WhereIterator(IEnumerable source, Func predicate) { }

	[Extension]
	public static IEnumerable Zip(IEnumerable first, IEnumerable second, Func resultSelector) { }

	[IteratorStateMachine(typeof(<ZipIterator>d__65`3))]
	private static IEnumerable ZipIterator(IEnumerable first, IEnumerable second, Func resultSelector) { }

}

