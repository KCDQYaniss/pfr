//Type is in global namespace

public class Paths : MonoBehaviour
{
	public Transform target; //Field offset: 0x20
	public PathType pathType; //Field offset: 0x28
	public Vector3[] waypoints; //Field offset: 0x30

	public Paths() { }

	private void Start() { }

}

