//Type is in global namespace

public class TacticalComboVisualController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__9_0(Transform mod) { }

	}

	public const string DISABLED_TRANSFORM_NAME = "mode_000"; //Field offset: 0x0
	public const string LIGHT_BEAM_TRANSFORM_NAME = "mode_"; //Field offset: 0x0
	private readonly List _ligthbeamsTransforms; //Field offset: 0x20
	public LightComponent LightMod; //Field offset: 0x28
	private Transform _disabledTransform; //Field offset: 0x30
	[SerializeField]
	private float _shadowNearPlaneShift; //Field offset: 0x38
	private Light[] _lights; //Field offset: 0x40
	private LaserBeam[] _laserBeams; //Field offset: 0x48

	public TacticalComboVisualController() { }

	private void Awake() { }

	public void Init() { }

	public void SetPointOfView(EPointOfView pointOfView) { }

	public void UpdateBeams(bool isYourPlayer = false) { }

}

