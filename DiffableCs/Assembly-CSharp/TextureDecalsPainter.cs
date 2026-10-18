//Type is in global namespace

public class TextureDecalsPainter : MonoBehaviour
{
	internal struct DecalDescription
	{
		public Renderer Renderer; //Field offset: 0x0
		public Vector3 Point; //Field offset: 0x8
		public Vector3 Normal; //Field offset: 0x14
		public Texture2D Texture; //Field offset: 0x20
		public bool HasToSetShaderVars; //Field offset: 0x28
		public bool HasToSetTexture; //Field offset: 0x29

	}

	private const int _maxTexturePoolSize = 128; //Field offset: 0x0
	private static readonly int MAXDECALSPERFRAME; //Field offset: 0x0
	private static int _textureIdCounter; //Field offset: 0x4
	private static readonly int _decal; //Field offset: 0x8
	private static readonly int _decalsTex; //Field offset: 0xC
	private static readonly int _decalPower; //Field offset: 0x10
	private static readonly int _objectDecalTexture; //Field offset: 0x14
	private static readonly int _right; //Field offset: 0x18
	private static readonly int _up; //Field offset: 0x1C
	private static readonly int _fwd; //Field offset: 0x20
	private static readonly int _point; //Field offset: 0x24
	[Header("Render textures settings")]
	[SerializeField]
	private PowOfTwoDimensions _renderTexDimension; //Field offset: 0x20
	[SerializeField]
	private DepthSize _renderTexDepthSize; //Field offset: 0x24
	[Header("Shaders")]
	[SerializeField]
	private Shader _drawInterceptionShader; //Field offset: 0x28
	[SerializeField]
	private Shader _blitShader; //Field offset: 0x30
	[Header("Textures")]
	[SerializeField]
	private Texture2D _bloodDecalTexture; //Field offset: 0x38
	[SerializeField]
	private Texture2D _vestDecalTexture; //Field offset: 0x40
	[SerializeField]
	private Texture2D _backDecalTexture; //Field offset: 0x48
	[Header("Decal settings")]
	[SerializeField]
	private float _projectorHeight; //Field offset: 0x50
	[MinMaxVec2(0, 0.5, -1)]
	[SerializeField]
	private Vector2 _decalSize; //Field offset: 0x54
	private Material _drawInterceptionMaterial; //Field offset: 0x60
	private Material _screenToTexMaterial; //Field offset: 0x68
	private RenderTexture _renderTargetTex; //Field offset: 0x70
	private RenderTexture _tmpTex; //Field offset: 0x78
	private CommandBuffer _buffer; //Field offset: 0x80
	private Dictionary _renderers; //Field offset: 0x88
	private List _decalDescriptions; //Field offset: 0x90
	private ObjectPool _texturesPool; //Field offset: 0x98

	private static TextureDecalsPainter() { }

	public TextureDecalsPainter() { }

	private void AddDecalDescription(Renderer objRenderer, Vector3 point, Vector3 normal, Texture2D texture, bool hasToSetShaderVars, bool hasToSetTexture) { }

	public void Awake() { }

	public void Clear() { }

	private RenderTexture CreateDecalTexture() { }

	private void DestroyDecalTexture(RenderTexture rendererDecalTex) { }

	public void DrawDecal(Renderer objRenderer) { }

	public void DrawDecal(List renderers, Vector3 point, Vector3 normal) { }

	private Texture2D GetTextureByType(EDecalTextureType type) { }

	private bool IsCorrectRenderer(Renderer objRenderer) { }

	private void OnDestroy() { }

	private void SetShaderVars(Vector3 point, Vector3 normal) { }

	private void Update() { }

}

