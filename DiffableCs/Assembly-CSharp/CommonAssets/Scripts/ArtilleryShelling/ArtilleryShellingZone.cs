namespace CommonAssets.Scripts.ArtilleryShelling;

public struct ArtilleryShellingZone
{
	public string ID; //Field offset: 0x0
	public Vector2 PointsInShellings; //Field offset: 0x8
	public int ShellingRounds; //Field offset: 0x10
	public int ShotCount; //Field offset: 0x14
	public Vector2 PauseBetweenRounds; //Field offset: 0x18
	public Vector2 PauseBetweenShots; //Field offset: 0x20
	public Vector3 Center; //Field offset: 0x28
	public Vector2 ExplosionDistanceRange; //Field offset: 0x34
	public float Rotate; //Field offset: 0x3C
	public Vector2 GridStep; //Field offset: 0x40
	public Vector2 Points; //Field offset: 0x48
	public Vector3[] PointsWorldPositions; //Field offset: 0x50
	public float PointRadius; //Field offset: 0x58
	public AlarmStage[] AlarmStages; //Field offset: 0x60
	public int LootTemplateId; //Field offset: 0x68
	public bool UsedInPlanedShelling; //Field offset: 0x6C
	public bool UseInCalledShelling; //Field offset: 0x6D
	public bool IsActive; //Field offset: 0x6E
	public List ZoneBounds; //Field offset: 0x70
	public string TriggerInclude; //Field offset: 0x78
	public string TriggerExclude; //Field offset: 0x80

}

