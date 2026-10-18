namespace Newtonsoft.Json.Linq.JsonPath;

internal class ArraySliceFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class <ExecuteFilter>d__12 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[Nullable(1)]
		private JToken <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArraySliceFilter <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerable current; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public IEnumerable <>3__current; //Field offset: 0x38
		private JsonSelectSettings settings; //Field offset: 0x40
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator <>7__wrap1; //Field offset: 0x50
		private JArray <a>5__3; //Field offset: 0x58
		private int <stepCount>5__4; //Field offset: 0x60
		private int <stopIndex>5__5; //Field offset: 0x64
		private bool <positiveStep>5__6; //Field offset: 0x68
		private int <i>5__7; //Field offset: 0x6C

		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
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
		public <ExecuteFilter>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[DebuggerHidden]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

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
	private Nullable <Start>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable <End>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable <Step>k__BackingField; //Field offset: 0x20

	public Nullable End
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Nullable Start
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Nullable Step
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ArraySliceFilter() { }

	[IteratorStateMachine(typeof(<ExecuteFilter>d__12))]
	[NullableContext(1)]
	public virtual IEnumerable ExecuteFilter(JToken root, IEnumerable current, JsonSelectSettings settings) { }

	[CompilerGenerated]
	public Nullable get_End() { }

	[CompilerGenerated]
	public Nullable get_Start() { }

	[CompilerGenerated]
	public Nullable get_Step() { }

	private bool IsValid(int index, int stopIndex, bool positiveStep) { }

	[CompilerGenerated]
	public void set_End(Nullable value) { }

	[CompilerGenerated]
	public void set_Start(Nullable value) { }

	[CompilerGenerated]
	public void set_Step(Nullable value) { }

}

