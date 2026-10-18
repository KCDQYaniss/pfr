//Type is in global namespace

public class BotBewareGrenade : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public BotBewareGrenade <>4__this; //Field offset: 0x10
		public Grenade grenade; //Field offset: 0x18
		public Vector3 danger; //Field offset: 0x20

		public <>c__DisplayClass15_0() { }

		internal void <SubAddGrenade>g__RefreshDangerPoint|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Grenade grenade; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal Nullable <TurnAwayFlash>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Grenade grenade; //Field offset: 0x10
		public float distToGrenade; //Field offset: 0x18
		public BotBewareGrenade <>4__this; //Field offset: 0x20
		public Vector3 danger; //Field offset: 0x28
		public bool isMyFlash; //Field offset: 0x34

		public <>c__DisplayClass9_0() { }

		internal void <AddGrenadeDanger>b__0() { }

	}

	public GrenadeDangerPoint GrenadeDangerPoint; //Field offset: 0x18
	public Action OnBewareGrenade; //Field offset: 0x20
	private float _endPeriodOfIgnore; //Field offset: 0x28
	private float _nextPosibleRunTime; //Field offset: 0x2C
	private readonly float DELTA_CALC_TIME; //Field offset: 0x30
	private float deltaGoCheck; //Field offset: 0x34
	private bool _doExtraSearch; //Field offset: 0x38

	public BotBewareGrenade(BotOwner owner) { }

	public void AddGrenadeDanger(Vector3 danger, Grenade grenade) { }

	private Vector3 CalcPossibleSafeCenter() { }

	private void CalcToCoverGrenade() { }

	private CustomNavigationPoint DoExtraSearch() { }

	public void DrawGizmosSelected() { }

	private bool IgnoreGrenade(Grenade grenade) { }

	public void IgnoreGrenadesForSec(float sec) { }

	private bool IsIgnoreByPeriod() { }

	public bool SawGrenadeSoFar(float period) { }

	private void SetGrenadeDangerPoint(GrenadeDangerPoint gdp) { }

	public bool ShallRunAway() { }

	private void SpottedAllPointNearPos(Vector3 pos) { }

	private void SubAddGrenade(Grenade grenade, Vector3 danger, bool isMyFlash) { }

	public void TurnAwayFlash(Grenade grenade) { }

	public void UpdateByNode() { }

}

