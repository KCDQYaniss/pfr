namespace RootMotion.FinalIK;

public class Constraints
{
	public Transform transform; //Field offset: 0x10
	public Vector3 positionOffset; //Field offset: 0x18
	public Vector3 position; //Field offset: 0x24
	[Range(0, 1)]
	public float positionWeight; //Field offset: 0x30
	public Vector3 rotationOffset; //Field offset: 0x34
	public Vector3 rotation; //Field offset: 0x40
	[Range(0, 1)]
	public float rotationWeight; //Field offset: 0x4C

	public Constraints() { }

	public void Initiate(Transform transform) { }

	public bool IsValid() { }

	public void Update() { }

}

