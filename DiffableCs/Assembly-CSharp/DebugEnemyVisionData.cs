//Type is in global namespace

public struct DebugEnemyVisionData
{
	public int Id; //Field offset: 0x0
	public bool Visible; //Field offset: 0x4
	public float VisibilityLevel; //Field offset: 0x8
	public EEnemyPartVisibleType VisibleType; //Field offset: 0xC
	public bool CanShoot; //Field offset: 0x10
	public ELookObstacleType BotToTargetObstacleType; //Field offset: 0x14
	public int PartsCount; //Field offset: 0x18
	public DebugEnemyPartVisionData[] PartVisions; //Field offset: 0x20

}

