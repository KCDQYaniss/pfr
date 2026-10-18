//Type is in global namespace

public class FollowerGluharScoutLayersStrategy : GluharAbstractLayersStrategy
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int TARGET_LOGIC_SIMPLE = 6; //Field offset: 0x0
	private const int ENEMY_LOGIC_SIMPLE = 7; //Field offset: 0x0
	private const int PATROL_REQUEST = 9; //Field offset: 0x0
	private const int FIGHT_REQUEST = 10; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private readonly FollowerGluharScoutFightLayer _killa; //Field offset: 0x60
	private readonly float SDIST_TO_START_ATTACK; //Field offset: 0x68
	private bool _doDefence; //Field offset: 0x6C
	private bool _shallAttack; //Field offset: 0x6D
	private float _nextAssaultCheck; //Field offset: 0x70
	private float _checkUpdate; //Field offset: 0x74

	public FollowerGluharScoutLayersStrategy(BotOwner owner) { }

	private void CheckWantAttack() { }

	private void DoDefence() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void FindBoss() { }

	public virtual void ManualUpdate() { }

	private void OnBossFinded(IBossToFollow bossToFollow) { }

	private void OnScoutWannaAttack(BotOwner obj) { }

	public virtual string ShortName() { }

	private void SubFindBoss(IBossToFollow bossToFollow) { }

}

