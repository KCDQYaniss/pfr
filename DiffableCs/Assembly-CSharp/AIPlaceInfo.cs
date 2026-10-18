//Type is in global namespace

[RequireComponent(typeof(BoxCollider))]
public class AIPlaceInfo : MonoBehaviour, IPhysicsTrigger
{
	[CompilerGenerated]
	private sealed class <CheckAllPoints>d__33 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		public AIPlaceInfo <>4__this; //Field offset: 0x18
		public bool shallRepeat; //Field offset: 0x20
		private int <index>5__2; //Field offset: 0x24
		private ThrowGrenadePlace <throwGrenadePlace>5__3; //Field offset: 0x28
		private Nullable <oldDoorState>5__4; //Field offset: 0x30

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <CheckAllPoints>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public int AreaId; //Field offset: 0x20
	public string Id; //Field offset: 0x28
	public ThrowGrenadePlace[] GrenadePlaces; //Field offset: 0x30
	public BoxCollider Collider; //Field offset: 0x38
	public bool IsOnTrigger; //Field offset: 0x40
	public bool BlockGrenade; //Field offset: 0x41
	public bool IsDark; //Field offset: 0x42
	public bool IsMute; //Field offset: 0x43
	public bool IsInside; //Field offset: 0x44
	public bool AtrZone; //Field offset: 0x45
	private bool _isInited; //Field offset: 0x46
	private readonly HashSet _playersInside; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnPlayerEnter; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnPlayerExit; //Field offset: 0x58
	public AIPlaceInfoLogic InfoLogicAllEnemy; //Field offset: 0x60
	public ECoverPointSpecial CoversSpecial; //Field offset: 0x68
	private BotsController _botsController; //Field offset: 0x70
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x78
	public int ConnectionGroupId; //Field offset: 0x80
	public bool UseAsCoverGroupId; //Field offset: 0x84

	public event Action OnPlayerEnter
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPlayerExit
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotsController BotsController
	{
		 get { } //Length: 5
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AIPlaceInfo() { }

	[CompilerGenerated]
	public void add_OnPlayerEnter(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerExit(Action value) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CheckAllPoints>d__33))]
	public IEnumerator CheckAllPoints(bool shallRepeat) { }

	public List CheckAllStart() { }

	public bool ContainsPlayer(IPlayer enemy) { }

	public override void EditorCheck() { }

	public BotsController get_BotsController() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public int GetCount(Func isGood) { }

	public int GetCount() { }

	public void Init(IEnumerable allDoors, BotsController botsController) { }

	protected override void InnerInit() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.OnTriggerEnter(Collider col) { }

	private override void IPhysicsTrigger.OnTriggerExit(Collider col) { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public bool IsPlayerInside(IPlayer player) { }

	private void OnDestroy() { }

	protected override void OnDestroyInner() { }

	public void OnDrawGizmosSelected() { }

	protected override void OnEnterPlace(Player player) { }

	protected override void OnLeavePlace(Player player) { }

	public void Refresh() { }

	[CompilerGenerated]
	public void remove_OnPlayerEnter(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerExit(Action value) { }

}

