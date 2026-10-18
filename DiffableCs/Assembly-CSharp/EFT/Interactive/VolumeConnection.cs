namespace EFT.Interactive;

public class VolumeConnection
{
	public BetterPropagationVolume Volume; //Field offset: 0x10
	public EVolumeRelations Relations; //Field offset: 0x18
	[Range(0, 1)]
	public float ConnectionAudibility; //Field offset: 0x1C
	public bool UseManualAudibilitySettings; //Field offset: 0x20
	[HideInInspector]
	public EVolumeRelationsMask RelationsMask; //Field offset: 0x24

	public VolumeConnection() { }

}

