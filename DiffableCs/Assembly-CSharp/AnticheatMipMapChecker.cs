//Type is in global namespace

public class AnticheatMipMapChecker : MonoBehaviour
{
	private class TextureChecker
	{
		[SerializeField]
		public Texture2D CheckTexture; //Field offset: 0x10
		[SerializeField]
		public float CheckValue; //Field offset: 0x18

		public TextureChecker() { }

	}

	public static AnticheatMipMapChecker Instance; //Field offset: 0x0
	private static readonly int _mainTex; //Field offset: 0x8
	private static readonly int _mapChecker; //Field offset: 0xC
	[HideInInspector]
	public bool IsMipMapCorrect; //Field offset: 0x20
	[SerializeField]
	private Shader _mipMapChecker; //Field offset: 0x28
	[SerializeField]
	private TextureChecker textureChecker; //Field offset: 0x30
	private Material _checkerMaterial; //Field offset: 0x38
	private RenderTexture _checkerRenderTexture; //Field offset: 0x40
	private Texture2D _checkerTexture2D; //Field offset: 0x48
	private Material _material; //Field offset: 0x50

	private static AnticheatMipMapChecker() { }

	public AnticheatMipMapChecker() { }

	private void Awake() { }

	private bool CheckMipMapCorrectness() { }

	private void Clear() { }

	private void CreateTexture() { }

	private Material GetCheckerMaterial() { }

	private void SetMipMapCheckerShaderValue(bool isMipMapCorrect) { }

	private void Start() { }

}

