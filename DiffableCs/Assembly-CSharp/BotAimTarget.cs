//Type is in global namespace

public struct BotAimTarget
{
	public Vector3 Point; //Field offset: 0x0
	public bool AttackEnemy; //Field offset: 0xC
	public ELookObstacleType BotToTargetObstacleType; //Field offset: 0x10

	public BotAimTarget(Vector3 point, bool attackEnemy = false, ELookObstacleType botToTargetObstacleType = 0) { }

	public static BotAimTarget Enemy(Vector3 point, ELookObstacleType botToTargetObstacleType = 0) { }

	public static Nullable From(Nullable point, bool attackEnemy = false, ELookObstacleType botToTargetObstacleType = 0) { }

}

