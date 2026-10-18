//Type is in global namespace

[ExecuteAlways]
public class MountainViewAngleController : MonoBehaviour
{
	private const string EFFECT_ENABLED = "_EFFECT_ENABLED"; //Field offset: 0x0
	private static readonly int _directionLocalXZProperty; //Field offset: 0x0
	private static readonly int _cosCullProperty; //Field offset: 0x4
	private static readonly int _cosFeatherProperty; //Field offset: 0x8
	private MaterialPropertyBlock _mpb; //Field offset: 0x20
	private Renderer[] _renderers; //Field offset: 0x28
	[Range(0, 360)]
	[SerializeField]
	private float _directionDegrees; //Field offset: 0x30
	[Range(0, 270)]
	[SerializeField]
	private float _cullAngleDegrees; //Field offset: 0x34
	[Range(0.001, 30)]
	[SerializeField]
	private float _featherDegrees; //Field offset: 0x38

	public float CullAngleDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 51
	}

	public float DirectionDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 128
	}

	public float FeatherDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 41
	}

	private static MountainViewAngleController() { }

	public MountainViewAngleController() { }

	public float get_CullAngleDegrees() { }

	public float get_DirectionDegrees() { }

	public float get_FeatherDegrees() { }

	private static float Normalize360(float angle) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void set_CullAngleDegrees(float value) { }

	public void set_DirectionDegrees(float value) { }

	public void set_FeatherDegrees(float value) { }

	public void UpdateShaderGlobals() { }

}

