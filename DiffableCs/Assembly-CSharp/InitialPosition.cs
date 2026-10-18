//Type is in global namespace

public struct InitialPosition
{
	public Transform Transform; //Field offset: 0x0
	public Rigidbody Rigidbody; //Field offset: 0x8
	public Vector3 Positioin; //Field offset: 0x10
	public Quaternion Rotation; //Field offset: 0x1C
	public bool IsKinematic; //Field offset: 0x2C

	public InitialPosition(Transform t, Rigidbody r) { }

	public void Reset() { }

}

