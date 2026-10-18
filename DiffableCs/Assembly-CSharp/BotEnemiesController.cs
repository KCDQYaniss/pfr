//Type is in global namespace

public class BotEnemiesController : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Remove>b__18_0(IPlayer x) { }

	}

	public const int CLOSE = 6; //Field offset: 0x0
	public const int MID = 8; //Field offset: 0x0
	private readonly EnemyInfo[] SortedInfos; //Field offset: 0x18
	private int _countEnemies; //Field offset: 0x20
	private bool _havePersuitableEnemy; //Field offset: 0x24
	private bool _canPersueAxeman; //Field offset: 0x25
	[CompilerGenerated]
	private readonly Dictionary <EnemyInfos>k__BackingField; //Field offset: 0x28
	public EnemyInfo BestObservedEnemy; //Field offset: 0x30
	public BotEnemiesMissController MissController; //Field offset: 0x38

	public bool CanPursueAxeman
	{
		 get { } //Length: 52
	}

	public Dictionary EnemyInfos
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool HavePursuitableEnemy
	{
		 get { } //Length: 52
		 set { } //Length: 51
	}

	protected BotEnemiesController(BotOwner owner) { }

	public void Activate(bool globalPossibility) { }

	public override EnemyInfo AddNew(BotsGroup botsGroup, IPlayer enemy, BotGroupEnemyInfo groupInfo) { }

	private void ChangeByIndex(int a, int b) { }

	public void CheckEnemyPursuit(AIData aiData) { }

	public static BotEnemiesController Create(BotOwner owner) { }

	public void Dispose() { }

	public void DrawGizmos() { }

	public bool get_CanPursueAxeman() { }

	[CompilerGenerated]
	public Dictionary get_EnemyInfos() { }

	public bool get_HavePursuitableEnemy() { }

	public void HitTarget(Player target, DamageInfo damageInfo, EBodyPart bodyPart) { }

	public bool IsEnemy(IPlayer player) { }

	public void Remove(IPlayer info) { }

	public void set_HavePursuitableEnemy(bool value) { }

	public void SetInfo(IPlayer enemy, EnemyInfo info) { }

	public void SetSameEnemy(EnemyInfo enemyInfo) { }

	public void ShootDone() { }

	public void UpdateFor(EnemyInfo info) { }

	public void UpdateFor(EnemyInfo info, bool mainEnemy) { }

}

