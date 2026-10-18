namespace EFT.Interactive;

public abstract class BorderZone : MonoBehaviour, IPhysicsTrigger
{
	[CompilerGenerated]
	private sealed class <FireCoroutine>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <FireCoroutine>d__20(int <>1__state) { }

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

	protected const float DEEPENING_UPDATE_FREQUENCY = 1; //Field offset: 0x0
	[SerializeField]
	private BoxCollider Collider; //Field offset: 0x20
	[SerializeField]
	protected Vector3 _extents; //Field offset: 0x28
	[SerializeField]
	protected Vector4 _triggerZoneSettings; //Field offset: 0x34
	private float _nextDeepeningUpdate; //Field offset: 0x44
	protected List TargetedPlayers; //Field offset: 0x48
	protected List NotTargetedPlayers; //Field offset: 0x50
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Action PlayerShotEvent; //Field offset: 0x68

	public event Action PlayerShotEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override float Delay
	{
		 get { } //Length: 4
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IPlayer[] GetAllPlayersInArea
	{
		 get { } //Length: 215
	}

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected BorderZone() { }

	[CompilerGenerated]
	public void add_PlayerShotEvent(Action value) { }

	[IteratorStateMachine(typeof(<FireCoroutine>d__20))]
	protected override IEnumerator FireCoroutine(IPlayer player) { }

	public override float get_Delay() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public IPlayer[] get_GetAllPlayersInArea() { }

	[CompilerGenerated]
	public int get_Id() { }

	protected void InvokePlayerShotEvent(IObserverToPlayerBridge player, float delay, bool willHit = true) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	protected override bool IsInTriggerZone(Vector3 global) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	private void OnValidate() { }

	public override void ProcessIncomingPacket(IObserverToPlayerBridge player, bool willHit = true) { }

	[CompilerGenerated]
	public void remove_PlayerShotEvent(Action value) { }

	public void RemoveAuthority() { }

	private void RemoveFromLists(Player player) { }

	private void RemoveFromListsInner(Player player) { }

	[CompilerGenerated]
	public void set_Id(int value) { }

	public override void Update() { }

}

