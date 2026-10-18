namespace EFT.GameTriggers;

public class HandlerAnd : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string triggerId; //Field offset: 0x10
		public HandlerAnd <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Start>b__0(TriggerEvent triggerEvent) { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerAnd <>4__this; //Field offset: 0x28

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_OutputTriggerIds>d__8(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private string[] _inputTriggerIds; //Field offset: 0x20
	[SerializeField]
	private string _outputTriggerId; //Field offset: 0x28
	private HashSet _completeIds; //Field offset: 0x30

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		 get { } //Length: 5
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__8))]
		 get { } //Length: 175
	}

	public HandlerAnd() { }

	public override GameObject get_GameObject() { }

	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__8))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void OnTriggerEvent(string triggerId, int playerRaidId) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

