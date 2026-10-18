//Type is in global namespace

public class TracersLight : MonoBehaviour
{
	private class TracerInfo
	{
		public readonly Color BackCurrentTracerColor; //Field offset: 0x10
		public readonly Color CurrentTracerColor; //Field offset: 0x20
		public Vector3 Direction; //Field offset: 0x30
		public readonly Vector3 PositionShift; //Field offset: 0x3C
		public readonly float SizePercent; //Field offset: 0x48
		public readonly float Speed; //Field offset: 0x4C

		public TracerInfo(Vector3 positionShift, Vector3 direction, Color currentTracerColor, Color backCurrentTracerColor, float sizePercent, float speed) { }

	}

	private static readonly float FIRSTSTEPMINSQRDISTANCE; //Field offset: 0x0
	[ColorUsage(True, True, 0, 8, 0.125, 3)]
	public Color Color; //Field offset: 0x20
	[SerializeField]
	private float _maxFlyingTime; //Field offset: 0x30
	[SerializeField]
	private AnimationCurve _sizeTimeCurve; //Field offset: 0x38
	[SerializeField]
	private AnimationCurve _colorAlphaCurve; //Field offset: 0x40
	[SerializeField]
	private float _grenadeFlyingMaxTime; //Field offset: 0x48
	[SerializeField]
	private float _grenadeSizeCoef; //Field offset: 0x4C
	[SerializeField]
	private MeshFilter _tracersMF; //Field offset: 0x50
	[SerializeField]
	private float _speedModifier; //Field offset: 0x58
	[SerializeField]
	private float _grenadeSpeedModifier; //Field offset: 0x5C
	private List _ballisticCalculators; //Field offset: 0x60
	private List TracerInfos; //Field offset: 0x68
	private bool _isMeshShouldBeCleared; //Field offset: 0x70
	private bool _particlesIsDirty; //Field offset: 0x71

	private static TracersLight() { }

	public TracersLight() { }

	private void Awake() { }

	private void ClearTracersMesh() { }

	private void CreateGrenadeTracer(Shot shot, Vector3 p0, Vector3 p1) { }

	private void CreateShotTracer(Shot shot, Vector3 p0, Vector3 p1) { }

	private void CreateTracer(Shot shot) { }

	private void ProcessShots(IBallisticsCalculator ballisticsCalculator) { }

	private void Update() { }

	private void UpdateTracers() { }

	private void WorkCycle() { }

}

