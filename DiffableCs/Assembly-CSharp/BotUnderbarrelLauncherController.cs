//Type is in global namespace

public sealed class BotUnderbarrelLauncherController : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__42_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ushort <HasOneMoreEnemyNearCurrent>b__42_0(NavGraphVoxelSimple voxel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public BotUnderbarrelLauncherController <>4__this; //Field offset: 0x10
		public Action finishCallback; //Field offset: 0x18
		public Callback <>9__1; //Field offset: 0x20

		public <>c__DisplayClass30_0() { }

		internal void <TryEnableReloadDisable>b__0() { }

		internal void <TryEnableReloadDisable>b__1(IResult _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public BotUnderbarrelLauncherController <>4__this; //Field offset: 0x10
		public Action operationFinishedCallback; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal void <TryEnable>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public BotUnderbarrelLauncherController <>4__this; //Field offset: 0x10
		public Action operationFinishedCallback; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal void <TryDisable>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public BotUnderbarrelLauncherController <>4__this; //Field offset: 0x10
		public Callback reloadFinishedCallback; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <TryReload>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Launcher launcher; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <AmmoQuery>b__0(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public BotUnderbarrelLauncherController <>4__this; //Field offset: 0x10
		public EnemyInfo goalEnemy; //Field offset: 0x18
		public Func <>9__1; //Field offset: 0x20

		public <>c__DisplayClass42_0() { }

		internal bool <HasOneMoreEnemyNearCurrent>b__1(KeyValuePair enemyInfo) { }

	}

	private enum ELauncherShootAttemptStatus
	{
		Unsuccessful = 0,
		Successful = 1,
		UnsuccessfulWithDisable = 2,
	}

	private struct EnemyHysteresisEvaluation
	{
		public EHysteresisState LastHysteresisState; //Field offset: 0x0
		public bool LastEvaluation; //Field offset: 0x4

		public EnemyHysteresisEvaluation(EHysteresisState lastHysteresisState, bool lastEvaluation) { }

	}

	private enum ESwitchReason
	{
		UseInsteadOfReload = 0,
		ForceSwitchInFight = 1,
		PeaceReload = 2,
	}

	private static readonly EquipmentSlot[] _availableEquipmentSlots; //Field offset: 0x0
	private const int TIME_FOR_UNSUCCESSFUL_ATTEMPTS = 3; //Field offset: 0x0
	private const float SHOOT_ATTEMT_CHECK_COOLDOWN = 0.25; //Field offset: 0x0
	[CompilerGenerated]
	private Action ReloadStausChangedEvent; //Field offset: 0x18
	private readonly IList _foundAmmosBuffer; //Field offset: 0x20
	private readonly Dictionary _goalToOtherEnemiesHysteresisMap; //Field offset: 0x28
	private readonly HashSet _nearGoalEnemyVoxelsIdsSet; //Field offset: 0x30
	private float _lastEnableTime; //Field offset: 0x38
	private int _successShootAttemptsAfterSwitch; //Field offset: 0x3C
	private float _nearTargetDistanceTresholdSqr; //Field offset: 0x40
	private float _deviationSqr; //Field offset: 0x44
	private float _timeToCheckSwitchToGrenadeLauncher; //Field offset: 0x48
	private ESwitchReason _lastSwitchReason; //Field offset: 0x4C
	private bool _toggleOperationFinished; //Field offset: 0x50
	private bool _disableUnderballer; //Field offset: 0x51
	private bool _reloading; //Field offset: 0x52
	private float _lastEnableHandsTime; //Field offset: 0x54
	private float _lastShootAttemptCheckTime; //Field offset: 0x58
	private int _canUseInsteadOfReloadLastFrame; //Field offset: 0x5C
	private bool _canUseInsteadOfReloadLastFrameResult; //Field offset: 0x60

	public event Action ReloadStausChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool IsActive
	{
		 get { } //Length: 54
	}

	private static BotUnderbarrelLauncherController() { }

	public BotUnderbarrelLauncherController(BotOwner owner) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_ReloadStausChangedEvent(Action value) { }

	public IList AmmoQuery(Launcher launcher) { }

	public bool CanSwitchInFight(BotOwner owner) { }

	public bool CanUseInsteadOfReload() { }

	public bool CheckShootAttemptAndDisableIfNeeded() { }

	private ELauncherShootAttemptStatus CheckShootAttemptGdRules() { }

	private static bool EvaluateHysteresisState(EHysteresisState lastState, bool lastEvaluation, EHysteresisState currentState) { }

	public bool get_IsActive() { }

	private static float GetCheckTime(BotOwner owner) { }

	private static float GetLowDistanceToShoot(BotOwner owner, Launcher launcher) { }

	public static bool HasAmmoInChamber(Launcher underbarrelWeapon) { }

	private static bool HasEnemyOnDistance(BotOwner owner, float distanceToEnemy) { }

	private bool HasOneMoreEnemyNearCurrent() { }

	public void ManualUpdate() { }

	public bool NeedToReload() { }

	private void OnEnemyChanged(BotOwner obj) { }

	[CompilerGenerated]
	public void remove_ReloadStausChangedEvent(Action value) { }

	private void ResetEnableKd() { }

	public bool TryDisable(Action operationFinishedCallback = null) { }

	public bool TryEnable(Action operationFinishedCallback = null) { }

	public void TryEnableReloadDisable(Action finishCallback = null) { }

	public bool TryGetUnderbarrelWeapon(out Launcher underbarrelWeapon) { }

	public bool TryReload(Callback reloadFinishedCallback = null) { }

}

