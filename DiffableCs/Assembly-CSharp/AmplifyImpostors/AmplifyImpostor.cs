namespace AmplifyImpostors;

public class AmplifyImpostor : MonoBehaviour
{
	private const string ShaderGUID = "e82933f4c0eb9ba42aab0739f48efe21"; //Field offset: 0x0
	private const int MinAlphaResolution = 256; //Field offset: 0x0
	private const float StartYRotation = 90; //Field offset: 0x0
	private const float StartXRotation = -90; //Field offset: 0x0
	public const string _WIND = "_WIND"; //Field offset: 0x0
	public const string KEYWORD_HEMI_ON = "_HEMI_ON"; //Field offset: 0x0
	public static readonly int Property_HueVariation; //Field offset: 0x0
	private const string UShaderGUID = "da79d698f4bf0164e910ad798d07efdf"; //Field offset: 0x0
	private const string UShaderOctaGUID = "83dd8de9a5c14874884f9012def4fdcc"; //Field offset: 0x0
	private const string UPreset = "0403878495ffa3c4e9d4bcb3eac9b559"; //Field offset: 0x0
	private const int BlockSize = 65536; //Field offset: 0x0
	private const string HDShaderOctaGUID = "56236dc63ad9b7949b63a27f0ad180b3"; //Field offset: 0x0
	private const string PackerGUID = "31bd3cd74692f384a916d9d7ea87710d"; //Field offset: 0x0
	private const string DilateGUID = "57c23892d43bc9f458360024c5985405"; //Field offset: 0x0
	private const string ShaderOctaGUID = "572f9be5706148142b8da6e9de53acdb"; //Field offset: 0x0
	private const string StandardPreset = "e4786beb7716da54dbb02a632681cc37"; //Field offset: 0x0
	private const string LWPreset = "089f3a2f6b5f48348a48c755f8d9a7a2"; //Field offset: 0x0
	private const string HDShaderGUID = "175c951fec709c44fa2f26b8ab78b8dd"; //Field offset: 0x0
	private const string LWShaderOctaGUID = "94e2ddcdfb3257a43872042f97e2fb01"; //Field offset: 0x0
	private const string HDPreset = "47b6b3dcefe0eaf4997acf89caf8c75e"; //Field offset: 0x0
	private const string LWShaderGUID = "990451a2073f6994ebf9fd6f90a842b3"; //Field offset: 0x0
	public static readonly int Property_Hue; //Field offset: 0x4
	public static readonly int Property_Hemi; //Field offset: 0x8
	public static readonly int Property_AlbedoArray; //Field offset: 0xC
	public static readonly int Property_NormalsArray; //Field offset: 0x10
	public static readonly int Property_Albedo; //Field offset: 0x14
	public static readonly int Property_Normals; //Field offset: 0x18
	public static readonly int Property_Specular; //Field offset: 0x1C
	public static readonly int Property_Emission; //Field offset: 0x20
	public static readonly int Property_Index; //Field offset: 0x24
	public static readonly int Property_Frames; //Field offset: 0x28
	public static readonly int Property_ImpostorSize; //Field offset: 0x2C
	public static readonly int Property_Offset; //Field offset: 0x30
	public static readonly int Property_DepthSize; //Field offset: 0x34
	public static readonly int Property_ClipMask; //Field offset: 0x38
	public static readonly int Property_AI_ShadowBias; //Field offset: 0x3C
	public static readonly int Property_AI_ShadowView; //Field offset: 0x40
	public static readonly int Property_FramesX; //Field offset: 0x44
	public static readonly int Property_FramesY; //Field offset: 0x48
	public static readonly int Property_AI_Frames; //Field offset: 0x4C
	public static readonly int Property_AI_ImpostorSize; //Field offset: 0x50
	public static readonly int Property_AI_Offset; //Field offset: 0x54
	public static readonly int Property_AI_SizeOffset; //Field offset: 0x58
	public static readonly int Property_TextureBias; //Field offset: 0x5C
	public static readonly int Property_Parallax; //Field offset: 0x60
	public static readonly int Property_AI_DepthSize; //Field offset: 0x64
	public static readonly int Property_AI_FramesX; //Field offset: 0x68
	public static readonly int Property_AI_FramesY; //Field offset: 0x6C
	public static readonly int Property_AI_AlphaToCoverage; //Field offset: 0x70
	[SerializeField]
	private AmplifyImpostorAsset m_data; //Field offset: 0x20
	[SerializeField]
	private Transform m_rootTransform; //Field offset: 0x28
	[SerializeField]
	private LODGroup m_lodGroup; //Field offset: 0x30
	[SerializeField]
	private Renderer[] m_renderers; //Field offset: 0x38
	public LODReplacement m_lodReplacement; //Field offset: 0x40
	[SerializeField]
	public RenderPipelineInUse m_renderPipelineInUse; //Field offset: 0x44
	public int m_insertIndex; //Field offset: 0x48
	[SerializeField]
	public GameObject m_lastImpostor; //Field offset: 0x50
	[SerializeField]
	public string m_folderPath; //Field offset: 0x58
	public string m_impostorName; //Field offset: 0x60
	[SerializeField]
	public CutMode m_cutMode; //Field offset: 0x68
	private RenderTexture[] m_rtGBuffers; //Field offset: 0x70
	private RenderTexture[] m_alphaGBuffers; //Field offset: 0x78
	private RenderTexture m_trueDepth; //Field offset: 0x80
	public Texture2D m_alphaTex; //Field offset: 0x88
	private float m_xyFitSize; //Field offset: 0x90
	private float m_depthFitSize; //Field offset: 0x94
	private Vector2 m_pixelOffset; //Field offset: 0x98
	private Bounds m_originalBound; //Field offset: 0xA0
	private Vector3 m_oriPos; //Field offset: 0xB8
	private Quaternion m_oriRot; //Field offset: 0xC4
	private Vector3 m_oriSca; //Field offset: 0xD4

	public AmplifyImpostorAsset Data
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public LODGroup LodGroup
	{
		 get { } //Length: 76
		 set { } //Length: 82
	}

	public Renderer[] Renderers
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public Transform RootTransform
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	private static AmplifyImpostor() { }

	public AmplifyImpostor() { }

	private void Apply(Material material, Vector4 offset, Vector4 sizeOffset) { }

	internal void Apply(Material material) { }

	private void ClearAlphaBuffers() { }

	private void ClearBuffers() { }

	private void GenerateAlphaTextures(List outputList) { }

	public void GenerateAutomaticMesh(AmplifyImpostorAsset data) { }

	public Mesh GenerateMesh(Vector2[] points, Vector3 offset, float width = 1, float height = 1, bool invertY = true) { }

	private void GenerateTextures(List outputList, bool standardRendering) { }

	public AmplifyImpostorAsset get_Data() { }

	public LODGroup get_LodGroup() { }

	public Renderer[] get_Renderers() { }

	public Transform get_RootTransform() { }

	private Matrix4x4 GetCameraRotationMatrix(ImpostorType impostorType, int hframes, int vframes, int x, int y) { }

	private Vector3 HemiOctahedronToVector(float x, float y) { }

	internal static Nullable IsEqual(AmplifyImpostor impostor, AmplifyImpostor reference) { }

	private Vector3 OctahedronToVector(Vector2 oct) { }

	private Vector3 OctahedronToVector(float x, float y) { }

	public void RenderImpostor(ImpostorType impostorType, int targetAmount, bool impostorMaps = true, bool combinedAlphas = false, bool useMinResolution = false, Shader customShader = null) { }

	public void set_Data(AmplifyImpostorAsset value) { }

	public void set_LodGroup(LODGroup value) { }

	public void set_Renderers(Renderer[] value) { }

	public void set_RootTransform(Transform value) { }

}

