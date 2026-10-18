namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public sealed class HandlerAndExpandable : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public HandlerAndExpandable <>4__this; //Field offset: 0x10
		public string newInputId; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <AddNewInput>b__0(TriggerEvent triggerEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string triggerId; //Field offset: 0x10
		public HandlerAndExpandable <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <Start>b__0(TriggerEvent triggerEvent) { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerAndExpandable <>4__this; //Field offset: 0x28

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
	private List _inputTriggerIds; //Field offset: 0x20
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

	public HandlerAndExpandable() { }

	public void AddNewInput(string newInputId) { }

	public void AddNewInputs(List newInputIds) { }

	public override GameObject get_GameObject() { }

	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__8))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void OnTriggerEvent(string triggerId, int originPlayerRaidId) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

