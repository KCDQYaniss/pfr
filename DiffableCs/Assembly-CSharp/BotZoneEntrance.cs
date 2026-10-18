//Type is in global namespace

public class BotZoneEntrance
{
	public Vector3 PointOutSide; //Field offset: 0x10
	public Vector3 PointInside; //Field offset: 0x1C
	public Vector3 CenterPoint; //Field offset: 0x28
	public int ConnectedAreaId; //Field offset: 0x34
	public int Id; //Field offset: 0x38

	public BotZoneEntrance(Vector3 center, int connectedAreaId, Vector3 pointOutSide, Vector3 pointInside) { }

	public void DrawGizmosSelected() { }

}

