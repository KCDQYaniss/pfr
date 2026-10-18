namespace EFT.GameTriggers;

public sealed class HandlerContinuousGroupRequirement : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__14 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerContinuousGroupRequirement <>4__this; //Field offset: 0x28

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
		public <get_InputTriggerIds>d__14(int <>1__state) { }

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
	private sealed class <get_OutputTriggerIds>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerContinuousGroupRequirement <>4__this; //Field offset: 0x28

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
		public <get_OutputTriggerIds>d__16(int <>1__state) { }

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
	private sealed class <TimeoutCoroutine>d__25 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HandlerContinuousGroupRequirement <>4__this; //Field offset: 0x20

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
		public <TimeoutCoroutine>d__25(int <>1__state) { }

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
	private string _triggerIdRegisterPlayer; //Field offset: 0x20
	[SerializeField]
	private string _triggerIdUnregisterPlayer; //Field offset: 0x28
	[SerializeField]
	private string _triggerIdPlayersReady; //Field offset: 0x30
	[SerializeField]
	private string _triggerIdReset; //Field offset: 0x38
	[SerializeField]
	private string _triggerIdTimeout; //Field offset: 0x40
	[SerializeField]
	private int _requiredPlayersCount; //Field offset: 0x48
	[SerializeField]
	private bool _needTimeout; //Field offset: 0x4C
	[SerializeField]
	private bool _autoResetOnTimeout; //Field offset: 0x4D
	[SerializeField]
	private float _timeoutSeconds; //Field offset: 0x50
	[SerializeField]
	private bool _allowRepeatedRegistration; //Field offset: 0x54
	[SerializeField]
	private bool _emitPlayerProfileId; //Field offset: 0x55
	private readonly HashSet _registeredPlayers; //Field offset: 0x58
	private Coroutine _timeoutCoroutine; //Field offset: 0x60

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__14))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__16))]
		 get { } //Length: 175
	}

	public HandlerContinuousGroupRequirement() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__14))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__16))]
	public override IEnumerable get_OutputTriggerIds() { }

	public IReadOnlyCollection GetRegisteredPlayers() { }

	public int GetRegisteredPlayersCount() { }

	public bool IsPlayerRegistered(int playerRaidId) { }

	private void OnDestroy() { }

	private void OnRegisterPlayer(TriggerEvent triggerEvent) { }

	private void OnReset(TriggerEvent triggerEvent) { }

	private void OnUnregisterPlayer(TriggerEvent triggerEvent) { }

	private void ResetStorage() { }

	private void Start() { }

	private void StartTimeoutCoroutine() { }

	private void StopTimeoutCoroutine() { }

	[IteratorStateMachine(typeof(<TimeoutCoroutine>d__25))]
	private IEnumerator TimeoutCoroutine() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

