//Type is in global namespace

[AddComponentMenu("Image Effects/ScreenWater")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ScreenWater : MonoBehaviour
{
	private static readonly int _splat; //Field offset: 0x0
	private static readonly int _flow; //Field offset: 0x4
	private static readonly int _water; //Field offset: 0x8
	private static readonly int _speed; //Field offset: 0xC
	private static readonly int _intens; //Field offset: 0x10
	[CompilerGenerated]
	private float <Intensity>k__BackingField; //Field offset: 0x20
	public Shader shaderRGB; //Field offset: 0x28
	public float _distortionCooldownTime; //Field offset: 0x30
	public Texture2D WaterFlows; //Field offset: 0x38
	public Texture2D WaterMask; //Field offset: 0x40
	public Texture2D WetScreen; //Field offset: 0x48
	public float Speed; //Field offset: 0x50
	public float InitialIntensity; //Field offset: 0x54
	private Material m_MaterialRGB; //Field offset: 0x58
	private float _distortionAmount; //Field offset: 0x60
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x68
	private bool _hasGlases; //Field offset: 0x70

	public float Intensity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected Material material
	{
		 get { } //Length: 435
	}

	private static ScreenWater() { }

	public ScreenWater() { }

	protected void Awake() { }

	public void ChangeGlassesState(bool hasGlases) { }

	[CompilerGenerated]
	public float get_Intensity() { }

	protected Material get_material() { }

	protected void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	[CompilerGenerated]
	public void set_Intensity(float value) { }

	public void SetInitialIntensity(float intensity) { }

	public void SetIntensity(float intensity) { }

	public void SetSpeed(float speed) { }

	protected void Start() { }

}

