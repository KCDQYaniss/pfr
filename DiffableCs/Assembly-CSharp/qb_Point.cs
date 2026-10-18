//Type is in global namespace

public class qb_Point
{
	public Vector3 position; //Field offset: 0x10
	public Vector3 upVector; //Field offset: 0x1C
	public Vector3 dirVector; //Field offset: 0x28
	public Quaternion rotation; //Field offset: 0x34

	public qb_Point() { }

	public qb_Point(Vector3 incomingPos, Vector3 incomingUpVector, Vector3 incomingDirVector) { }

	public void UpdatePoint(Vector3 incomingPos, Vector3 incomingUpVector, Vector3 incomingDirVector) { }

}

