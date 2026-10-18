//Type is in global namespace

public struct RaycastHitData
{
	public bool hasHit; //Field offset: 0x0
	public Vector3 normal; //Field offset: 0x4
	public Vector3 point; //Field offset: 0x10

	public static RaycastHitData op_Implicit(RaycastHit hit) { }

}

