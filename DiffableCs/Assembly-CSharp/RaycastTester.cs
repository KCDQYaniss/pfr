//Type is in global namespace

public class RaycastTester : MonoBehaviour
{
	public float dist; //Field offset: 0x20
	public int X_size; //Field offset: 0x24
	public float step; //Field offset: 0x28
	public Vector3 dir; //Field offset: 0x2C

	public RaycastTester() { }

	private void OnDrawGizmosSelected() { }

}

