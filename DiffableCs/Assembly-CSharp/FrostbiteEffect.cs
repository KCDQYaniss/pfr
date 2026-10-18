//Type is in global namespace

public class FrostbiteEffect : MonoBehaviour
{
	private const string SHADER_NAME = "Hidden/FrostbiteEffect"; //Field offset: 0x0
	private static readonly int _baseColorId; //Field offset: 0x0
	private static readonly int _baseColorMapId; //Field offset: 0x4
	private static readonly int _normalMapId; //Field offset: 0x8
	private static readonly int _tilingId; //Field offset: 0xC
	private static readonly int _ODRFId; //Field offset: 0x10
	private static readonly int _shapeRadiusId; //Field offset: 0x14
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x20
	private Material _material; //Field offset: 0x28
	[SerializeField]
	private Shader _shader; //Field offset: 0x30
	[SerializeField]
	private Color _baseColor; //Field offset: 0x38
	[SerializeField]
	private Texture2D _baseColorMap; //Field offset: 0x48
	[SerializeField]
	private Texture2D _normalMap; //Field offset: 0x50
	[SerializeField]
	private Vector2 _tiling; //Field offset: 0x58
	[Range(0, 1)]
	[SerializeField]
	private float _speed; //Field offset: 0x60
	[Range(0, 1)]
	[SerializeField]
	private float _opacity; //Field offset: 0x64
	[Range(0, 1)]
	[SerializeField]
	private float _distortion; //Field offset: 0x68
	[Range(0, 1)]
	[SerializeField]
	private float _radius; //Field offset: 0x6C
	[SerializeField]
	private Vector2 _shapeRadius; //Field offset: 0x70
	[Range(0, 5)]
	[SerializeField]
	private float _falloff; //Field offset: 0x78

	private Material Material
	{
		private get { } //Length: 734
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Speed
	{
		 get { } //Length: 6
	}

	private static FrostbiteEffect() { }

	public FrostbiteEffect() { }

	private void Awake() { }

	private Material get_Material() { }

	public float get_Radius() { }

	public float get_Speed() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_Radius(float value) { }

}

