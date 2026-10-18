namespace EFT.GameTriggers;

public sealed class HandlerPlantAction : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public HandlerPlantAction <>4__this; //Field offset: 0x10
		public TriggerEvent triggerEvent; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <OnTriggerEvent>b__0(bool successful) { }

	}

	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__10 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerPlantAction <>4__this; //Field offset: 0x28

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
		public <get_InputTriggerIds>d__10(int <>1__state) { }

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
	private sealed class <get_OutputTriggerIds>d__12 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerPlantAction <>4__this; //Field offset: 0x28

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
		public <get_OutputTriggerIds>d__12(int <>1__state) { }

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

	private const int SECONDS_TIMEOUT_ADDITIONAL = 4; //Field offset: 0x0
	[SerializeField]
	private string _triggerId; //Field offset: 0x20
	[SerializeField]
	private string _onFailedTriggerId; //Field offset: 0x28
	[SerializeField]
	private string _onSuccessTriggerId; //Field offset: 0x30
	[SerializeField]
	private bool _showPlantingTime; //Field offset: 0x38
	[SerializeField]
	private float _plantingTime; //Field offset: 0x3C
	[SerializeField]
	private string _objectivePanelText; //Field offset: 0x40
	[SerializeField]
	private string _failedToStartText; //Field offset: 0x48
	private Coroutine _plantingTimeoutCoroutine; //Field offset: 0x50

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__10))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__12))]
		 get { } //Length: 175
	}

	public HandlerPlantAction() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__10))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__12))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void OnTriggerEvent(TriggerEvent triggerEvent) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

