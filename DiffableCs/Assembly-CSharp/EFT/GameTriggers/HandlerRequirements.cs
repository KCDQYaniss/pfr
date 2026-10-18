namespace EFT.GameTriggers;

public class HandlerRequirements : SerializedMonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__9 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerRequirements <>4__this; //Field offset: 0x28

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
		public <get_InputTriggerIds>d__9(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__11 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerRequirements <>4__this; //Field offset: 0x28

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
		public <get_OutputTriggerIds>d__11(int <>1__state) { }

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
	private string _inputTriggerId; //Field offset: 0x60
	[SerializeField]
	private string _outputTriggerId; //Field offset: 0x68
	[SerializeField]
	private ITriggerRequirement[] _triggerRequirement; //Field offset: 0x70

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__9))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__11))]
		 get { } //Length: 175
	}

	private TriggersModule TriggersModule
	{
		private get { } //Length: 64
	}

	public HandlerRequirements() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__9))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__11))]
	public override IEnumerable get_OutputTriggerIds() { }

	private TriggersModule get_TriggersModule() { }

	private void OnInputTrigger(TriggerEvent triggerEvent) { }

	private void OnValidate() { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

