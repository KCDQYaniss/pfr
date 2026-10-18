//Type is in global namespace

public struct DebugEnemyPartVisionData
{
	public Vector3 RaycastTargetPosition; //Field offset: 0x0
	public bool Visible; //Field offset: 0xC
	public float VisibilityLevel; //Field offset: 0x10
	public float VisibilityDuration; //Field offset: 0x14
	public EEnemyPartVisibleType VisibleType; //Field offset: 0x18
	public bool HasLineOfSight; //Field offset: 0x1C
	public ELookObstacleType BotToTargetObstacleType; //Field offset: 0x20
	public Vector3 BotToTargetHitPosition; //Field offset: 0x24
	public float ObstaclePenetrationDepth; //Field offset: 0x30

}

