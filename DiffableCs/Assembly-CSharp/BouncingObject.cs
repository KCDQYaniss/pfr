//Type is in global namespace

public class BouncingObject : MonoBehaviour
{
	private struct Jump
	{
		private const float _bezierRaisePercent = 0.3; //Field offset: 0x0
		public int index; //Field offset: 0x0
		public Vector3 beginPoint; //Field offset: 0x4
		public Vector3 startVelocity; //Field offset: 0x10
		public Vector3 acceleration; //Field offset: 0x1C
		public float endTime; //Field offset: 0x28
		public float currentTime; //Field offset: 0x2C
		public Vector3 currentPoint; //Field offset: 0x30
		public Vector3 currentVelocity; //Field offset: 0x3C
		public Vector3 nextJumpDirection; //Field offset: 0x48
		public bool useBezier; //Field offset: 0x54
		public Vector3 bezierRaisePoint; //Field offset: 0x58
		public float bezierStartTime; //Field offset: 0x64
		public Vector3 bezierStartPoint; //Field offset: 0x68
		public Vector3 bezierEndPoint; //Field offset: 0x74
		public Collider hitCollider; //Field offset: 0x80

		public Vector3 CalculatePoint(float time, Vector3 currentVelocity) { }

		public Vector3 CalculateVelocity(float time) { }

		public void Init(int index, Vector3 beginPoint, Vector3 startVelocity, Vector3 acceleration) { }

		public void SetUseBezier(float bezierStartTime, Vector3 startPoint, Vector3 endPoint, float distance) { }

		public void SetUseBezier(float bezierStartTime, Vector3 startPoint, Vector3 bezierRaisePoint, Vector3 endPoint) { }

		public bool Update(ref float deltaTime) { }

	}

	private const int MIN_FRAME_DELTA = 3; //Field offset: 0x0
	private float _deltaTimeStep; //Field offset: 0x20
	private LayerMask _castMask; //Field offset: 0x24
	private RaycastHit[] _raycastHits; //Field offset: 0x28
	private int _maxCastCount; //Field offset: 0x30
	private Jump _currentJump; //Field offset: 0x38
	private float _playMult; //Field offset: 0xC0
	private float _randomReboundSpread; //Field offset: 0xC4
	private float _bounceSpeedMult; //Field offset: 0xC8
	private float _radius; //Field offset: 0xCC
	private int _frameDelta; //Field offset: 0xD0
	private bool _showDebug; //Field offset: 0xD4
	private Vector3 _acceleration; //Field offset: 0xD8
	[CompilerGenerated]
	private bool <Finished>k__BackingField; //Field offset: 0xE4
	private Vector3 _lastPosition; //Field offset: 0xE8

	public private bool Finished
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public float VelocitySqrMagnitude
	{
		 get { } //Length: 38
	}

	public BouncingObject() { }

	private Jump CreateJump(int index, Vector3 beginPoint, Vector3 velocity) { }

	[Conditional("UNITY_EDITOR")]
	private void DebugDrawTrajectory(Jump jump, float time) { }

	[CompilerGenerated]
	public bool get_Finished() { }

	public float get_VelocitySqrMagnitude() { }

	public void Init(Vector3 beginPoint, Vector3 velocity, float radius, float playMult, LayerMask castMask, int maxCastCount, float deltaTimeStep, float randomReboundSpread, float bounceSpeedMult, bool showDebug) { }

	protected override void OnBounce(Collider collider) { }

	protected override void OnDone() { }

	private void OnDrawGizmos() { }

	private void Process(float time) { }

	private bool Raycast(Vector3 point, Vector3 direction, float maxDistance, out RaycastHit hit) { }

	[CompilerGenerated]
	private void set_Finished(bool value) { }

	protected override void Update() { }

}

