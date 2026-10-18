namespace EFT.Interactive;

public sealed class GuardedZone : MonoBehaviour, IPhysicsTrigger, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__18 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public GuardedZone <>4__this; //Field offset: 0x28

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
		public <get_OutputTriggerIds>d__18(int <>1__state) { }

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
	private SniperFireTargetManager _targetManager; //Field offset: 0x20
	[SerializeField]
	private string _onGuardedPlayerHitTriggerId; //Field offset: 0x28
	private readonly HashSet _guardedPlayerIds; //Field offset: 0x30
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly IEnumerable <InputTriggerIds>k__BackingField; //Field offset: 0x40

	public override string Description
	{
		 get { } //Length: 49
	}

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override IEnumerable InputTriggerIds
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__18))]
		 get { } //Length: 175
	}

	public GuardedZone() { }

	public override string get_Description() { }

	public override GameObject get_GameObject() { }

	[CompilerGenerated]
	public int get_Id() { }

	[CompilerGenerated]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__18))]
	public override IEnumerable get_OutputTriggerIds() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private void OnAnyPlayerHit(DamageInfo damageInfo, Player victim) { }

	private void OnDestroy() { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	[CompilerGenerated]
	public void set_Id(int value) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

