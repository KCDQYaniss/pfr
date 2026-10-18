//Type is in global namespace

public class BotMeleeWeaponData : BotData
{
	private const float BIG_PERIOD = 10; //Field offset: 0x0
	private const float CHANCE_TO_SAY = 100; //Field offset: 0x0
	private const float SDIST_TOO_CLOSE = 4; //Field offset: 0x0
	private const float SMAPLE_DIST = 2.6; //Field offset: 0x0
	private const float TOOFAR_BASE_PATH_DIST = 2; //Field offset: 0x0
	private const float NO_RECAL_CAUSE_TOO_CLOSE = 0.09; //Field offset: 0x0
	private readonly float TRY_HIT_PERIOD_FALSE; //Field offset: 0x18
	private bool _debugComboEnabled; //Field offset: 0x1C
	private float FAR_DIST; //Field offset: 0x20
	private float MID_DIST; //Field offset: 0x24
	private float farRecalc; //Field offset: 0x28
	private float midRecalc; //Field offset: 0x2C
	private float closeRecalc; //Field offset: 0x30
	private float midRecalcZZ; //Field offset: 0x34
	private float closeRecalcZZ; //Field offset: 0x38
	private Vector3 _lastTarget; //Field offset: 0x3C
	private bool _lastCanHitResult; //Field offset: 0x48
	private Vector3[] _pathToRun; //Field offset: 0x50
	[CompilerGenerated]
	private bool <MeleeWeaponEquipped>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <HaveMelee>k__BackingField; //Field offset: 0x59
	private float _runPathCheck; //Field offset: 0x5C
	private float _nextTryHitTime; //Field offset: 0x60
	[CompilerGenerated]
	private IKnifeController <KnifeController>k__BackingField; //Field offset: 0x68
	private Vector3[] _lastCalcPath; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnEnemyHitted; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnTryHit; //Field offset: 0x80
	[CompilerGenerated]
	private float <LastTimeEnemyHit>k__BackingField; //Field offset: 0x88
	public bool Running; //Field offset: 0x8C
	private bool _useZigZag; //Field offset: 0x8D
	[CompilerGenerated]
	private bool <ShallEndRun>k__BackingField; //Field offset: 0x8E

	public event Action OnEnemyHitted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTryHit
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private float DIST_TO_HIT
	{
		private get { } //Length: 58
	}

	private float DIST_TO_STOP_SPRINT
	{
		private get { } //Length: 58
	}

	public private bool HaveMelee
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private IKnifeController KnifeController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float LastTimeEnemyHit
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public bool meleeOptimize
	{
		 get { } //Length: 57
	}

	public private bool MeleeWeaponEquipped
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool ShallEndRun
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private float TRY_HIT_PERIOD
	{
		private get { } //Length: 58
	}

	private bool UseMeleeCombos
	{
		private get { } //Length: 57
	}

	public BotMeleeWeaponData(BotOwner owner) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnEnemyHitted(Action value) { }

	[CompilerGenerated]
	public void add_OnTryHit(Action value) { }

	private bool CanHitToPoint(Vector3 targetPoint, out Vector3[] pathToRun) { }

	public bool CanRunToEnemyToHit(EnemyInfo enemy, out Vector3[] pathToRun) { }

	public void Dispose() { }

	private float get_DIST_TO_HIT() { }

	private float get_DIST_TO_STOP_SPRINT() { }

	[CompilerGenerated]
	public bool get_HaveMelee() { }

	[CompilerGenerated]
	public IKnifeController get_KnifeController() { }

	[CompilerGenerated]
	public float get_LastTimeEnemyHit() { }

	public bool get_meleeOptimize() { }

	[CompilerGenerated]
	public bool get_MeleeWeaponEquipped() { }

	[CompilerGenerated]
	public bool get_ShallEndRun() { }

	private float get_TRY_HIT_PERIOD() { }

	private bool get_UseMeleeCombos() { }

	public void HitCurrentEnemy(DamageInfo damageInfo, float val, Player target) { }

	private void OnAttackEnd() { }

	private void OnComboPlanning() { }

	[CompilerGenerated]
	public void remove_OnEnemyHitted(Action value) { }

	[CompilerGenerated]
	public void remove_OnTryHit(Action value) { }

	private void ResetHitTime(float delay) { }

	public bool RunToEnemyUpdate() { }

	[CompilerGenerated]
	private void set_HaveMelee(bool value) { }

	[CompilerGenerated]
	private void set_KnifeController(IKnifeController value) { }

	[CompilerGenerated]
	private void set_LastTimeEnemyHit(float value) { }

	[CompilerGenerated]
	private void set_MeleeWeaponEquipped(bool value) { }

	[CompilerGenerated]
	private void set_ShallEndRun(bool value) { }

	public void SetDebugCombo(bool state) { }

	private bool TryHit(EnemyInfo enemy) { }

	public void UpdateKnifeController(IKnifeController knifeHandsController) { }

}

