//Type is in global namespace

[ScriptOrder(19100)]
public class AmbientHighlight : OnRenderObjectConnector
{
	private struct AmbientDirectionalLight
	{
		public Transform LightTransform; //Field offset: 0x0
		public Color Color; //Field offset: 0x8
		public float Intensity; //Field offset: 0x18

	}

	private class HighlightSettings
	{
		public float HighlightMinMultiplier; //Field offset: 0x10
		public float HighlightMaxMultiplier; //Field offset: 0x14
		public AnimationCurve HighlightIntensityCurve; //Field offset: 0x18
		public StencilType StencilTypeToUse; //Field offset: 0x20

		public HighlightSettings() { }

	}

	internal enum StencilType
	{
		Static = 0,
		Characters = 1,
		Hands = 2,
	}

	private static Mesh _quadMesh; //Field offset: 0x0
	private static readonly Matrix4x4 MatrixIdentity; //Field offset: 0x8
	private static readonly int _srcBlendID; //Field offset: 0x48
	private static readonly int _dstBlendID; //Field offset: 0x4C
	private static readonly int[] _idSha; //Field offset: 0x50
	private static readonly int[] _idShb; //Field offset: 0x58
	private static readonly int _idShc; //Field offset: 0x60
	private static readonly int _stencilId; //Field offset: 0x64
	private static readonly int _highlightMultiplier; //Field offset: 0x68
	private static readonly int _ambientBlur; //Field offset: 0x6C
	[SerializeField]
	private float AmbientBlur; //Field offset: 0x20
	[SerializeField]
	private Material AmbientMaterial; //Field offset: 0x28
	[SerializeField]
	private HighlightSettings[] _highlightSettings; //Field offset: 0x30
	[SerializeField]
	private AmbientDirectionalLight[] _additionalLights; //Field offset: 0x38
	private CommandBufferManager _ambientBufferManager; //Field offset: 0x40
	private MaterialPropertyBlock _mpb; //Field offset: 0x48

	private static AmbientHighlight() { }

	public AmbientHighlight() { }

	public static Mesh GetQuadMesh() { }

	public virtual void ManualOnRenderObject(Camera currentCamera) { }

	private void OnDestroy() { }

	public void SetSH(SphericalHarmonicsL2 sh) { }

	protected virtual void Start() { }

	private void UpdateAmbientBuffer(CommandBuffer ambientBuffer, Camera currentCamera) { }

}

