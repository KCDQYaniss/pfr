//Type is in global namespace

[ExecuteAlways]
public class DistortionObject : MonoBehaviour
{
	private Renderer _renderer; //Field offset: 0x20
	private Material _material; //Field offset: 0x28

	public Material GetMaterial
	{
		 get { } //Length: 5
	}

	public Renderer GetRenderer
	{
		 get { } //Length: 5
	}

	public DistortionObject() { }

	public Material get_GetMaterial() { }

	public Renderer get_GetRenderer() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

