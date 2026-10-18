//Type is in global namespace

public class PartisanFightManyLayer : PartisanFightBaseLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Vector3 enemy; //Field offset: 0x10
		public PartisanFightManyLayer <>4__this; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal bool <TryFindNextCover>b__0(GroupPoint x) { }

	}

	private const float SHOOT_FROM_PLACE_PERIOD = 5; //Field offset: 0x0
	private const float MID_DIST = 60; //Field offset: 0x0
	private const float MAX_DIST = 70; //Field offset: 0x0
	private const float SMIN_DIST = 2500; //Field offset: 0x0
	public const float IF_SEEN_ENEMY_TOO_LATE_NO_MINES = 40; //Field offset: 0x0
	private const float MIN_DIST = 50; //Field offset: 0x0
	private const float PERIOD_MINES_PLANT = 5; //Field offset: 0x0
	private const float TRIGGER_TIME = 4; //Field offset: 0x0
	private float _lastTimeChoose; //Field offset: 0x98
	private float _fightUntil; //Field offset: 0x9C
	private bool _lastCalcMany; //Field offset: 0xA0
	private float _nextRecalcMany; //Field offset: 0xA4
	private float AUTO_PLANT_SDIST; //Field offset: 0xA8
	private float SDITS_CLOSE_MANY; //Field offset: 0xAC
	private float SDITS_CLOSE_MANY_TO_ME; //Field offset: 0xB0
	private AIPeriodAction _periodMines; //Field offset: 0xB8
	private CustomNavigationPoint _lastChoose; //Field offset: 0xC0

	public PartisanFightManyLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	private void PlantMineNear() { }

	public virtual bool ShallUseNow() { }

	protected AICoreActionResult ShootOrDogFight(string info) { }

	private void TryFindNextCover() { }

	private void TryPlantMineNear() { }

	private void TryRecalcMany() { }

}

