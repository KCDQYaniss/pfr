//Type is in global namespace

[AddComponentMenu("Image Effects/ChromaticAberration")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ChromaticAberration : MonoBehaviour
{
	private static readonly int _shift; //Field offset: 0x0
	public float Shift; //Field offset: 0x20
	public int Aniso; //Field offset: 0x24
	public bool Simple; //Field offset: 0x28
	public Shader shader; //Field offset: 0x30
	private Material _material; //Field offset: 0x38
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x40

	private Material material
	{
		private get { } //Length: 433
	}

	private static ChromaticAberration() { }

	public ChromaticAberration() { }

	private void Awake() { }

	private Material get_material() { }

	protected void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

