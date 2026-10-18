//Type is in global namespace

[AddComponentMenu("Image Effects/Dithering")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Dithering : MonoBehaviour
{
	private static readonly int _ditheringTexture; //Field offset: 0x0
	public Texture DitTex; //Field offset: 0x20
	public Shader shader; //Field offset: 0x28
	private Material _material; //Field offset: 0x30

	private Material material
	{
		private get { } //Length: 435
	}

	private static Dithering() { }

	public Dithering() { }

	private Material get_material() { }

	protected void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

