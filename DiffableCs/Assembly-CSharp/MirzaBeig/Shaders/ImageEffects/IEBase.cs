namespace MirzaBeig.Shaders.ImageEffects;

[ExecuteInEditMode]
public class IEBase : MonoBehaviour
{
	private Material _material; //Field offset: 0x20
	[CompilerGenerated]
	private Shader <shader>k__BackingField; //Field offset: 0x28
	private Camera _camera; //Field offset: 0x30

	protected Camera camera
	{
		 get { } //Length: 320
	}

	protected Material material
	{
		 get { } //Length: 435
	}

	protected Shader shader
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public IEBase() { }

	private void Awake() { }

	protected void blit(RenderTexture source, RenderTexture destination) { }

	protected Camera get_camera() { }

	protected Material get_material() { }

	[CompilerGenerated]
	protected Shader get_shader() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	[CompilerGenerated]
	protected void set_shader(Shader value) { }

	private void Start() { }

	private void Update() { }

}

