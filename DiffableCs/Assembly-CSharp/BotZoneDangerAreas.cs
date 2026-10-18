//Type is in global namespace

public class BotZoneDangerAreas
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public BotZoneDangerAreas <>4__this; //Field offset: 0x10
		public AIDangerArea area; //Field offset: 0x18
		public ITimer timer; //Field offset: 0x20

		public <>c__DisplayClass14_0() { }

		internal void <AddDanger>b__0() { }

	}

	private const float DANGER_AREA_RADIUS = 8; //Field offset: 0x0
	private const float SDIST_TO_CREATE_AREA = 400; //Field offset: 0x0
	private const float STANDART_DANGER_AREA_PERIOD_SEC = 600; //Field offset: 0x0
	public BotZone ZoneOwner; //Field offset: 0x10
	public HashSet ActiveAreas; //Field offset: 0x18
	private readonly HashSet _timers; //Field offset: 0x20
	private readonly List _deathPositions; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnDangerAreaCreated; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnDangerAreaRemoved; //Field offset: 0x38

	public event Action OnDangerAreaCreated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnDangerAreaRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotZoneDangerAreas() { }

	[CompilerGenerated]
	public void add_OnDangerAreaCreated(Action value) { }

	[CompilerGenerated]
	public void add_OnDangerAreaRemoved(Action value) { }

	public void AddDanger(Vector3 point, float rad, float period = -1) { }

	public void BotDied(Vector3 position) { }

	public void Complete(AIDangerArea area) { }

	private void CreateDangerArea(Vector3 p1, Vector3 p2) { }

	public void Dispose() { }

	public void Init(BotZone zone) { }

	public void OnDrawGizmosSelected() { }

	[CompilerGenerated]
	public void remove_OnDangerAreaCreated(Action value) { }

	[CompilerGenerated]
	public void remove_OnDangerAreaRemoved(Action value) { }

}

