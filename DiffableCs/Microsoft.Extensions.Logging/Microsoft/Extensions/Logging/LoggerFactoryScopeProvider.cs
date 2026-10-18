namespace Microsoft.Extensions.Logging;

internal sealed class LoggerFactoryScopeProvider : IExternalScopeProvider
{
	[CompilerGenerated]
	private struct <>c__DisplayClass3_0`1
	{
		public Action callback; //Field offset: 0x0
		public TState state; //Field offset: 0x0

	}

	private sealed class ActivityBaggageLogScopeWrapper : IEnumerable, IEnumerable
	{
		private struct BaggageEnumerator : IEnumerator, IEnumerator, IDisposable
		{
			private readonly IEnumerator _enumerator; //Field offset: 0x0

			public override KeyValuePair Current
			{
				 get { } //Length: 471
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 89
			}

			public BaggageEnumerator(IEnumerator enumerator) { }

			public override void Dispose() { }

			public override KeyValuePair get_Current() { }

			public override bool MoveNext() { }

			public override void Reset() { }

			private override object System.Collections.IEnumerator.get_Current() { }

		}

		private readonly IEnumerable _items; //Field offset: 0x10
		private StringBuilder _stringBuilder; //Field offset: 0x18

		public ActivityBaggageLogScopeWrapper(IEnumerable items) { }

		public override IEnumerator GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		public virtual string ToString() { }

	}

	[DefaultMember("Item")]
	private sealed class ActivityLogScope : IReadOnlyList, IEnumerable, IEnumerable, IReadOnlyCollection
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__10 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private KeyValuePair <>2__current; //Field offset: 0x18
			public ActivityLogScope <>4__this; //Field offset: 0x28
			private int <i>5__2; //Field offset: 0x30

			private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 74
			}

			[DebuggerHidden]
			public <GetEnumerator>d__10(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private string _cachedToString; //Field offset: 0x10
		private readonly KeyValuePair[] _items; //Field offset: 0x18
		[CompilerGenerated]
		private readonly int <Count>k__BackingField; //Field offset: 0x20

		public override int Count
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public override KeyValuePair Item
		{
			 get { } //Length: 143
		}

		public ActivityLogScope(Activity activity, ActivityTrackingOptions activityTrackingOption) { }

		[CompilerGenerated]
		public override int get_Count() { }

		public override KeyValuePair get_Item(int index) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__10))]
		public override IEnumerator GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		public virtual string ToString() { }

	}

	private sealed class Scope : IDisposable
	{
		private readonly LoggerFactoryScopeProvider _provider; //Field offset: 0x10
		private bool _isDisposed; //Field offset: 0x18
		[CompilerGenerated]
		private readonly Scope <Parent>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private readonly object <State>k__BackingField; //Field offset: 0x28

		public Scope Parent
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public object State
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		internal Scope(LoggerFactoryScopeProvider provider, object state, Scope parent) { }

		public override void Dispose() { }

		[CompilerGenerated]
		public Scope get_Parent() { }

		[CompilerGenerated]
		public object get_State() { }

		public virtual string ToString() { }

	}

	private readonly AsyncLocal _currentScope; //Field offset: 0x10
	private readonly ActivityTrackingOptions _activityTrackingOption; //Field offset: 0x18

	public LoggerFactoryScopeProvider(ActivityTrackingOptions activityTrackingOption) { }

	[CompilerGenerated]
	internal static void <ForEachScope>g__Report|3_0(Scope current, ref <>c__DisplayClass3_0 unnamed_param_1) { }

	public override void ForEachScope(Action callback, TState state) { }

	private static ActivityBaggageLogScopeWrapper GetOrCreateActivityBaggageLogScopeWrapper(Activity activity, IEnumerable items) { }

	public override IDisposable Push(object state) { }

}

