//Type is in global namespace

public class MineDirectionalManager
{
	[CompilerGenerated]
	private sealed class <GetAffectedMines>d__7 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MineDirectional <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private string tag; //Field offset: 0x28
		public string <>3__tag; //Field offset: 0x30
		public MineDirectionalManager <>4__this; //Field offset: 0x38
		private Enumerator <>7__wrap1; //Field offset: 0x40

		private override MineDirectional System.Collections.Generic.IEnumerator<MineDirectional>.Current
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
		public <GetAffectedMines>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<MineDirectional>.GetEnumerator() { }

		[DebuggerHidden]
		private override MineDirectional System.Collections.Generic.IEnumerator<MineDirectional>.get_Current() { }

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
	private Action OnExplosion; //Field offset: 0x10

	public event Action OnExplosion
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public List Mines
	{
		 get { } //Length: 84
	}

	public MineDirectionalManager() { }

	[CompilerGenerated]
	public void add_OnExplosion(Action value) { }

	public List get_Mines() { }

	[IteratorStateMachine(typeof(<GetAffectedMines>d__7))]
	private IEnumerable GetAffectedMines(string tag) { }

	public void OnMineExplosion(MineDirectional mineDirectional) { }

	[CompilerGenerated]
	public void remove_OnExplosion(Action value) { }

	public void SetArmedState(string tag, bool state) { }

}

