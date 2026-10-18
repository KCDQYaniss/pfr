namespace EFT.GameTriggers;

public class TriggerRallyZone : MonoBehaviour, ITriggerEntity, IPhysicsTrigger
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__24 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

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
		public <get_InputTriggerIds>d__24(int <>1__state) { }

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
	private sealed class <get_OutputTriggerIds>d__26 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TriggerRallyZone <>4__this; //Field offset: 0x28

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
		public <get_OutputTriggerIds>d__26(int <>1__state) { }

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
	private string _triggerId; //Field offset: 0x20
	[SerializeField]
	private string _objectivePanelText; //Field offset: 0x28
	private readonly Dictionary _playerInCollidersCount; //Field offset: 0x30
	private readonly HashSet _playersInside; //Field offset: 0x38
	private bool _wasTriggered; //Field offset: 0x40
	private int _zoneIdHash; //Field offset: 0x44
	private bool _localPlayerInZone; //Field offset: 0x48
	private Action _eventUnsubscribe; //Field offset: 0x50

	public override string Description
	{
		 get { } //Length: 98
	}

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__24))]
		 get { } //Length: 80
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__26))]
		 get { } //Length: 175
	}

	public TriggerRallyZone() { }

	private void CheckAllPlayersInZone(int originPlayerRaidId) { }

	private void EmitTrigger(int originPlayerRaidId) { }

	private void EmitZoneUpdateEvent() { }

	public override string get_Description() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__24))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__26))]
	public override IEnumerable get_OutputTriggerIds() { }

	private int GetAliveHumanPlayerCount() { }

	private bool HasAuthority() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private void OnDestroy() { }

	private void OnEnterAuthority(Player player) { }

	private void OnExitAuthority(Player player) { }

	private void OnPlayerDead(Player deadPlayer, IPlayer aggressor, DamageInfo damageInfo, EBodyPart part) { }

	public override void OnTriggerEnter(Collider other) { }

	public override void OnTriggerExit(Collider other) { }

	private void OnZoneUpdate(RallyZoneUpdateEvent data) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

