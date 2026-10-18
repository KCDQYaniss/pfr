//Type is in global namespace

public class ZryachiyFightLayer : ZryachiyAbstractLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public ZryachiyFightLayer <>4__this; //Field offset: 0x10
		public float sD; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal bool <FindPoint>b__0(GroupPoint x) { }

	}

	private bool _doNoHitTransition; //Field offset: 0xB0
	private bool _doTeleport; //Field offset: 0xB1
	private float _lastTimeHitTarget; //Field offset: 0xB4
	private float _lastKill; //Field offset: 0xB8
	private float _lastPeriodFail; //Field offset: 0xBC
	private readonly float _checkPeriodFail; //Field offset: 0xC0
	private int _checksCount; //Field offset: 0xC4
	private readonly int _maxChecksCount; //Field offset: 0xC8
	private bool _doChangePlace; //Field offset: 0xCC
	private List closePossible; //Field offset: 0xD0

	private float _lastTimeShootTarget
	{
		private get { } //Length: 40
	}

	public float CHANCE_TELEPORT
	{
		 get { } //Length: 58
	}

	public float MIN_DIST_TO_NEXT_COVER
	{
		 get { } //Length: 58
	}

	public float MIN_DIST_TO_TELEPORT
	{
		 get { } //Length: 58
	}

	public ZryachiyFightLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <.ctor>b__18_0(CustomNavigationPoint x) { }

	public virtual void Dispose() { }

	private void DoTransition() { }

	protected virtual AICoreActionEnd EndCrawlNode() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private float get__lastTimeShootTarget() { }

	public float get_CHANCE_TELEPORT() { }

	public float get_MIN_DIST_TO_NEXT_COVER() { }

	public float get_MIN_DIST_TO_TELEPORT() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool KillSoon() { }

	public virtual string Name() { }

	private void OnHitTarget(IPlayer arg1, DamageInfo arg2, EBodyPart arg3) { }

	private void OnKillTarget(string arg1, DamageInfo arg2) { }

	private void OnPlayerEnter(Player obj) { }

	private void OnPlayerExit(Player obj) { }

	public virtual bool ShallUseNow() { }

}

