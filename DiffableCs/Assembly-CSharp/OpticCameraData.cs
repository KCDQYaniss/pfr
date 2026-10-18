//Type is in global namespace

public class OpticCameraData : MonoBehaviour
{
	public float Fov; //Field offset: 0x20

	public OpticCameraData() { }

	[ContextMenu("ReInit")]
	public void ReInit() { }

}

