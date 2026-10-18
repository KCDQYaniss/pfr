//Type is in global namespace

public class NavGraphEditorPath
{
	public int FromId; //Field offset: 0x10
	public int ToId; //Field offset: 0x14
	public float Dist; //Field offset: 0x18
	public int Id; //Field offset: 0x1C
	public NavGraphEditorPoint From; //Field offset: 0x20
	public NavGraphEditorPoint To; //Field offset: 0x28
	public HashSet WaysTo; //Field offset: 0x30
	public int DoorLinkId; //Field offset: 0x38
	private float _coef; //Field offset: 0x3C

	public float Value
	{
		 get { } //Length: 11
	}

	private NavGraphEditorPath(NavGraphEditorPoint newPoint, NavGraphEditorPoint prevPoint, float dist, NavGraphContainer container) { }

	public static NavGraphEditorPath Create(NavGraphEditorPoint from, NavGraphEditorPoint to, float dist, NavGraphContainer container) { }

	public void DrawGizmosSelected(Vector3 up) { }

	public void DropCoef(float coef) { }

	public float get_Value() { }

	public Vector3 MidPos() { }

	public void SetBaseCoef() { }

	public void SetCoef(float coef) { }

	public void SetDoorLinkForCloseState(NavMeshDoorLink link) { }

	public void SetDoorLinkForOpenState(NavMeshDoorLink link) { }

}

