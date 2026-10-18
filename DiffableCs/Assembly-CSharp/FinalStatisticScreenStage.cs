//Type is in global namespace

public abstract class FinalStatisticScreenStage : EftScreenState
{
	[CompilerGenerated]
	private sealed class <BuildRows>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "name", "value"})]
		public List infos; //Field offset: 0x20
		public FinalStatisticScreenStage <>4__this; //Field offset: 0x28
		private List <views>5__2; //Field offset: 0x30
		private int <index>5__3; //Field offset: 0x38

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
		public <BuildRows>d__8(int <>1__state) { }

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

	[SerializeField]
	protected Transform _container; //Field offset: 0x90
	[SerializeField]
	protected CanvasGroup _nextBackAlphaGroup; //Field offset: 0x98
	protected FinalStatsArgs _args; //Field offset: 0xA0
	protected UIParent _parentUI; //Field offset: 0xA8
	protected MonoBehaviour _monoContext; //Field offset: 0xB0
	protected bool _showDone; //Field offset: 0xB8

	protected FinalStatisticScreenStage() { }

	[IteratorStateMachine(typeof(<BuildRows>d__8))]
	protected IEnumerator BuildRows(List infos) { }

	protected void Clear() { }

	public void Init(FinalStatsArgs args, UIParent parentUI, MonoBehaviour monoContext) { }

}

