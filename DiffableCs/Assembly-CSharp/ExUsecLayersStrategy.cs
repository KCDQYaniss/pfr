//Type is in global namespace

public class ExUsecLayersStrategy : ExUsecAbstractStrategy
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public EnemyInfo enemy; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal Vector3 <FindToSuppressForMG>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public KeyValuePair enemyInfo; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal Vector3 <FindToSuppressForGrenade>b__0() { }

	}

	private const float AGGRESSION_TO_ASSAULTS_SDIST = 2500; //Field offset: 0x0
	private const int FORCE_ATTACK_LAYER = 17; //Field offset: 0x0
	private const int EXUSEC_REQUEST = 15; //Field offset: 0x0
	private const int KHOROVOD_CHRISTMAS_EVENT_LAYER = 13; //Field offset: 0x0
	private const int WARNS_LAYER = 12; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 11; //Field offset: 0x0
	private const int FIGHT_REQUEST = 9; //Field offset: 0x0
	private const int PATROL_UTILITY = 8; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 7; //Field offset: 0x0
	private const int ENEMY_LOGIC2 = 6; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int STATIONARY_LAYER = 10; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const float MAX_DIST_TO_SUPPRESS = 250; //Field offset: 0x0
	private const int PATROL_REQUEST = 4; //Field offset: 0x0
	private const float DIST_TO_DROP_STATIONARY_BY_SOUND = 10; //Field offset: 0x0
	private const float CANT_SHOOT_TO_LEAVE_PERIOD = 3; //Field offset: 0x0
	private const float CANT_SHOOT_TO_LEAVE_DIST = 50; //Field offset: 0x0
	private const float ACTIVATE_STATIONARY_NOVISIBLE_ENEMY_SEC = 60; //Field offset: 0x0
	private const float ACTIVATE_STATIONARY_IFNO_ENEMY_SEC = 45; //Field offset: 0x0
	private float _canFightNoStationary; //Field offset: 0x60
	private float _nextCheckForSupperss; //Field offset: 0x64
	private readonly bool _canUseStationary; //Field offset: 0x68
	private bool _isStationaryActivated; //Field offset: 0x69
	private readonly bool _isGrenade; //Field offset: 0x6A
	private readonly bool _tryFindForSuppress; //Field offset: 0x6B
	private readonly StationaryWeaponLink _stationaryClose; //Field offset: 0x70
	private readonly HashSet _insidePlayers; //Field offset: 0x78
	private bool _doOffKilla; //Field offset: 0x80
	private bool _isKillaActive; //Field offset: 0x81
	private float _killaTimeOff; //Field offset: 0x84

	private AbstractSuppressStationary _suppressLogic
	{
		private get { } //Length: 39
	}

	public ExUsecLayersStrategy(BotOwner owner) { }

	private void ActivateAttackZone() { }

	public virtual void Dispose() { }

	private void DisposeAttackZone() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void FindToSuppressForGrenade() { }

	private void FindToSuppressForMG() { }

	private AbstractSuppressStationary get__suppressLogic() { }

	public virtual void ManualUpdate() { }

	private void OnEnemyRemove(IPlayer obj) { }

	private void OnPlayerEnter(Player obj) { }

	private void OnPlayerExit(Player obj) { }

	private void OnSomeBodyBeingHit(DamageInfo damageinfo, Player victim) { }

	private void PeriodCheckSomeBodyToSuppress() { }

	private void RemovePlayer(IPlayer person) { }

	public virtual string ShortName() { }

	private void TryOffAttackMode() { }

}

