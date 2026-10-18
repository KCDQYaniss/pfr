//Type is in global namespace

[AddComponentMenu("Image Effects/TopLight")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TopLight : MonoBehaviour
{
	private static readonly int _color; //Field offset: 0x0
	public Shader TheShader; //Field offset: 0x20
	public Color Color; //Field offset: 0x28
	private Material _material; //Field offset: 0x38
	private Color _lastColor; //Field offset: 0x40

	private Material Mat
	{
		private get { } //Length: 577
	}

	private static TopLight() { }

	public TopLight() { }

	private Material get_Mat() { }

	protected void OnDisable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

