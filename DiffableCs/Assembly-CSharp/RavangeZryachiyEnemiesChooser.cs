//Type is in global namespace

public class RavangeZryachiyEnemiesChooser : BotEnemyChooser
{
	private HashSet _playersIdsToKill; //Field offset: 0x28
	private int _lastId; //Field offset: 0x30
	private float _priorityEnds; //Field offset: 0x34

	public RavangeZryachiyEnemiesChooser(BotOwner owner) { }

	[CompilerGenerated]
	private bool <FindDangerEnemy>b__5_0(EnemyInfo x) { }

	public virtual void Activate() { }

	public virtual EnemyInfo FindDangerEnemy() { }

}

