//Type is in global namespace

public class DistortRenderer : MonoBehaviour
{
	private Renderer _renderer; //Field offset: 0x20
	private Material _renderMaterial; //Field offset: 0x28

	public Material MeterialToRender
	{
		 get { } //Length: 216
	}

	public Renderer Renderer
	{
		 get { } //Length: 216
	}

	public DistortRenderer() { }

	public Material get_MeterialToRender() { }

	public Renderer get_Renderer() { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

}

