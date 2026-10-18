//Type is in global namespace

public class BotMoveToEnemyData : BotData
{
	private const float SDIST_TOO_CLOSE = 4; //Field offset: 0x0
	private const float SMAPLE_DIST = 2.6; //Field offset: 0x0
	private const float TOOFAR_BASE_PATH_DIST = 2; //Field offset: 0x0
	private NavMeshPath _path; //Field offset: 0x18

	public BotMoveToEnemyData(BotOwner owner) { }

	public bool CanMoveTo(Vector3 position) { }

	private bool CanShootAtEndCurWay(Vector3 shootTargetPoint, out Vector3 curTargetPos) { }

	public bool ShallRecalWay(out Vector3 lastPos) { }

	public bool TryMoveToEnemy(Vector3 targetPoint) { }

}

