//Type is in global namespace

public class DangerPoint : MonoBehaviour
{
	public float Radius; //Field offset: 0x20
	[HideInInspector]
	public Vector3 Position; //Field offset: 0x24

	public DangerPoint() { }

	public void Awake() { }

}

