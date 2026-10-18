//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public abstract class TOD_ImageEffect : MonoBehaviour
{
	private static readonly int _mainTex; //Field offset: 0x0
	protected Camera cam; //Field offset: 0x20
	private TOD_Sky _sky; //Field offset: 0x28
	private bool _supportsRenderTextureFormatDepth; //Field offset: 0x30
	private bool _supportsRenderTextureFormatARGBHalf; //Field offset: 0x31

	public TOD_Sky Sky
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	private static TOD_ImageEffect() { }

	protected TOD_ImageEffect() { }

	protected void Awake() { }

	protected bool CheckSupport(bool needDepth = false, bool needHdr = false) { }

	protected Material CreateMaterial(Shader shader) { }

	protected void CustomBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr = 0) { }

	protected void DrawBorder(RenderTexture dest, Material material) { }

	public TOD_Sky get_Sky() { }

	public void set_Sky(TOD_Sky value) { }

}

