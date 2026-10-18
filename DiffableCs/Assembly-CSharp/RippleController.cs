//Type is in global namespace

[ExecuteInEditMode]
public class RippleController : MonoBehaviour
{
	internal sealed class Cycle
	{
		public float CucleSpeed; //Field offset: 0x10
		[MinMaxVec2(0.0001, 1, -1)]
		public Vector2 CucleLengthRelationMinMax; //Field offset: 0x14
		[MinMaxVec2(0, 1, -1)]
		public Vector2 IntensityMinMax; //Field offset: 0x1C
		private float _time; //Field offset: 0x24
		private float _lastCucleLengthRelation; //Field offset: 0x28

		public Cycle() { }

		private static float CalcNewTime(float currentTime, float lastCucleLengthRelation, float newCucleLengthRelation) { }

		public Vector4 Update(float dt, float intensity) { }

	}

	private static readonly int _waterRippleCycleHash; //Field offset: 0x0
	private static readonly int _waterRippleConfigHash; //Field offset: 0x4
	private static readonly int _environmentRippleCycleHash; //Field offset: 0x8
	private static readonly int _rippleTextureHash; //Field offset: 0xC
	private static readonly int _wetDropSpecularHash; //Field offset: 0x10
	private static readonly int _wetDropGlossnessHash; //Field offset: 0x14
	private static readonly int _wetDropAlbedoHash; //Field offset: 0x18
	private static readonly int _wetDropNormalHash; //Field offset: 0x1C
	private static readonly int _rippleFakeLightIntensityHash; //Field offset: 0x20
	private static readonly int _rainIntensityRippleScaleHash; //Field offset: 0x24
	private static readonly int _sunDirectionHash; //Field offset: 0x28
	[CompilerGenerated]
	private float <Intensity>k__BackingField; //Field offset: 0x20
	public Texture2D RippleTexture; //Field offset: 0x28
	[Header("Water Ripples")]
	public Cycle WaterCucle; //Field offset: 0x30
	public int RippleWaveCount; //Field offset: 0x38
	public float RippleWaveFreq; //Field offset: 0x3C
	[Header("Environment Ripples")]
	public Cycle EnvironmentCucle; //Field offset: 0x40
	[Range(0, 1)]
	public float WetDropsSpecular; //Field offset: 0x48
	[Range(0, 1)]
	public float WetDropsGlossness; //Field offset: 0x4C
	[Range(0, 1)]
	public float WetDropsAlbedo; //Field offset: 0x50
	[Range(0, 1)]
	public float WetDropsNormal; //Field offset: 0x54
	[Range(0, 3)]
	public float RippleFakeLightIntensity; //Field offset: 0x58
	[Range(0, 5)]
	public float RainIntensityRippleScale; //Field offset: 0x5C
	[SerializeField]
	private bool _forceTriplanar; //Field offset: 0x60
	[SerializeField]
	private bool _useFakeRippleLight; //Field offset: 0x61

	public float Intensity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private static RippleController() { }

	public RippleController() { }

	[CompilerGenerated]
	public float get_Intensity() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public void set_Intensity(float value) { }

	private void SetShaderValues(Vector4 waterCycle, Vector4 environmentCycle) { }

	private void Start() { }

	private void Update() { }

}

