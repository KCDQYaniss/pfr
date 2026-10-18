//Type is in global namespace

[ExecuteInEditMode]
public class MuzzleSmoke : MonoBehaviour
{
	private class Point
	{
		public bool SkipProcess; //Field offset: 0x10
		public Vector3 Position; //Field offset: 0x14
		public Vector3 Velocity; //Field offset: 0x20
		public Vector3 Turbulence; //Field offset: 0x2C
		public Vector3 Direction; //Field offset: 0x38
		public Color32 Color; //Field offset: 0x44
		public float Diffusion; //Field offset: 0x48
		public float YUv; //Field offset: 0x4C

		public Point() { }

	}

	public Material Material; //Field offset: 0x20
	public float SmokeEnd; //Field offset: 0x28
	public float BrakeDistance; //Field offset: 0x2C
	[Space(8)]
	public float DragValue; //Field offset: 0x30
	public float Gravity; //Field offset: 0x34
	public float SmokeVelocity; //Field offset: 0x38
	[Space(8)]
	public float TurbulenceDensity; //Field offset: 0x3C
	public float TurbulenceIntensity; //Field offset: 0x40
	[Space(8)]
	public float SmokeDiffusionBySmokeVelocity; //Field offset: 0x44
	[Header("Driven By Muzzle Speed")]
	public float MuzzleSpeedMultiplier; //Field offset: 0x48
	public AnimationCurve SpeedTurbulenceDensity; //Field offset: 0x50
	public AnimationCurve SpeedTurbulenceStrength; //Field offset: 0x58
	public AnimationCurve SpeedSmokeStrength; //Field offset: 0x60
	public AnimationCurve SpeedStartDiffusion; //Field offset: 0x68
	[Header("Driven By Time")]
	public AnimationCurve Smoke; //Field offset: 0x70
	public float SmokeStrength; //Field offset: 0x78
	public float SmokeLength; //Field offset: 0x7C
	public float SmokeLengthRandomness; //Field offset: 0x80
	public float SmokeIncreasingByShot; //Field offset: 0x84
	public float ShotFactorDropTime; //Field offset: 0x88
	private float ShotFactor; //Field offset: 0x8C
	private Transform _cachedTransform; //Field offset: 0x90
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; //Field offset: 0x98
	private float _smoking; //Field offset: 0x9C
	private LinkedList _points; //Field offset: 0xA0
	private Vector3 _pos; //Field offset: 0xA8
	private Vector3 _lastPos; //Field offset: 0xB4
	private Vector3 _velocity; //Field offset: 0xC0
	private float _velocityMag; //Field offset: 0xCC
	private int _lastYUv; //Field offset: 0xD0
	private float _sqrBrakeDistance; //Field offset: 0xD4
	private float _turPos; //Field offset: 0xD8
	private float _smokeLength; //Field offset: 0xDC
	private int _pointsCount; //Field offset: 0xE0

	public private bool Destroyed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public MuzzleSmoke() { }

	private void Awake() { }

	public void Clear() { }

	private void CreatePoint(float velocity, bool skipProcess = true) { }

	private void Draw() { }

	[CompilerGenerated]
	public bool get_Destroyed() { }

	private static float GetRnd(float t) { }

	private void InitializePoints(Camera cam) { }

	public void LateUpdateValues(Camera cam, float dt) { }

	private void OnRenderObject() { }

	private void OnValidate() { }

	private void ProcessPoints() { }

	[CompilerGenerated]
	private void set_Destroyed(bool value) { }

	public void Shot() { }

	private void StartSmoke() { }

}

