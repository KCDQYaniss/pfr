//Type is in global namespace

public class RunAndHideFightLayer : AbstractSectantLayerFight
{
	private const float COVER_TO_RUN_BIG = 25; //Field offset: 0x0
	private const float DIST_TO_RUN_INSIDE = 10; //Field offset: 0x0
	private const float DIST_TO_RUN_OUTSIDE = 20; //Field offset: 0x0
	private const float INSIDE_DIT_BAD_COVER = 8; //Field offset: 0x0
	public const float UNDER_FIRE_DELTA = 30; //Field offset: 0x0
	public const float SDIST_TREE_CLOSE = 900; //Field offset: 0x0
	private const string NAME_INSIDE = "R&H_IN"; //Field offset: 0x0
	private const string NAME_OUTSIDE = "R&H_OUT"; //Field offset: 0x0
	private const float Y_DIFF_NO_GOOD_COVER = 1.5; //Field offset: 0x0
	private CustomNavigationPoint _pointForHide; //Field offset: 0x90
	private float _nextCheck; //Field offset: 0x98
	private float _distToRun; //Field offset: 0x9C
	private string _name; //Field offset: 0xA0
	private bool _isInside; //Field offset: 0xA8
	private float _nextTraectoryInsideTest; //Field offset: 0xAC
	private float _lastTraectoryResult; //Field offset: 0xB0

	public RunAndHideFightLayer(BotOwner bot, int priority) { }

	private AICoreActionEnd EndHoldOutside() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public CustomNavigationPoint FindPointForHide(CoverSearchData data, CustomNavigationPoint prevPoint) { }

	private Vector3 FindPosToStart(EnemyInfo enemy) { }

	public virtual AICoreActionResult GetDecision() { }

	private float GetLastTrajectoryResult(Vector3 from, Vector3 pos) { }

	private bool IsCurPlaceGoodInside(Vector3 place) { }

	private bool IsPointGood(CustomNavigationPoint point) { }

	public virtual string Name() { }

	private void Recheck(CoverSearchData data) { }

	public void SetBoss(BossSectantPriest sectantPriest) { }

	public void SetCorePosition(Vector3 pointForBoss) { }

	public void SetInside(bool isInside) { }

	public virtual bool ShallUseNow() { }

}

