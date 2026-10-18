//Type is in global namespace

[ExecuteInEditMode]
public class SimpleCharacterController : MonoBehaviour, ICharacterController
{
	internal class CollidersArray
	{
		internal struct CollisionInfo
		{
			public bool IsOverlapped; //Field offset: 0x0

		}

		public Collider[] colliders; //Field offset: 0x10
		public CollisionInfo[] collisionInfos; //Field offset: 0x18
		public int count; //Field offset: 0x20
		public List seepColliders; //Field offset: 0x28

		public CollidersArray(int capacity) { }

	}

	private const float _stepOffestAddition = 0.17; //Field offset: 0x0
	private const int _maxNeighboursColliders = 64; //Field offset: 0x0
	[SerializeField]
	private Transform _movementTransform; //Field offset: 0x20
	[SerializeField]
	private CapsuleCollider _mainCollider; //Field offset: 0x28
	[SerializeField]
	private Collider[] _colliders; //Field offset: 0x30
	[SerializeField]
	private LayerMask _collisionMask; //Field offset: 0x38
	[Header("Settings")]
	[SerializeField]
	private float _castHalo; //Field offset: 0x3C
	[SerializeField]
	private float _groundDotThreshold; //Field offset: 0x40
	[SerializeField]
	private float _maxDepenetrationDistance; //Field offset: 0x44
	[SerializeField]
	private float _maxDepenetrationDistanceResolve; //Field offset: 0x48
	[SerializeField]
	private float _snapGroundDenepentrationToUp; //Field offset: 0x4C
	[SerializeField]
	private float _fixedDeltaDistance; //Field offset: 0x50
	[Header("Speed Limit")]
	[SerializeField]
	private float _speedLimit; //Field offset: 0x54
	[SerializeField]
	private float _sqrSpeedLimit; //Field offset: 0x58
	[Header("Resolve Tightness")]
	[SerializeField]
	private float _tightDotThreshold; //Field offset: 0x5C
	[SerializeField]
	private int _maxIterationsToResolveTightness; //Field offset: 0x60
	[SerializeField]
	private float _feelingTightMaxMotion; //Field offset: 0x64
	[SerializeField]
	private int _finePositionsToRemember; //Field offset: 0x68
	[SerializeField]
	private bool _isSeepingActive; //Field offset: 0x6C
	[Header("Stepping")]
	[SerializeField]
	private float _canStandUpRising; //Field offset: 0x70
	[SerializeField]
	private float _canStepUpExpanse; //Field offset: 0x74
	[SerializeField]
	private float _stepUpDumpPercent; //Field offset: 0x78
	[SerializeField]
	private float _canStandUpObstacleHeight; //Field offset: 0x7C
	[Header("Huunity Depenetration Bug")]
	[SerializeField]
	private bool _resolveHuunityDepenetrationBug; //Field offset: 0x80
	[SerializeField]
	private float _depenetrationBugRayAddition; //Field offset: 0x84
	[Header("Alerts")]
	[SerializeField]
	private int _maxCycleCountToHalt; //Field offset: 0x88
	private Vector3 _lastFinePosition; //Field offset: 0x8C
	private int _finePositionsInARow; //Field offset: 0x98
	private bool _finePositionRemembered; //Field offset: 0x9C
	private bool _isEnabledVerticalDepenetration; //Field offset: 0x9D
	private HashSet _noSpeedLimitCollisionColliders; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <IsSpeedLimitWasEnabledAtTheFrame>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <IsMoveIgnored>k__BackingField; //Field offset: 0xA9
	private CollidersArray[] _neighboursColliders; //Field offset: 0xB0
	private RaycastHit[] _raycastHits; //Field offset: 0xB8
	private Vector3 _currentPosition; //Field offset: 0xC0
	[CompilerGenerated]
	private Action OnHeightChanged; //Field offset: 0xD0
	private bool _isGrounded; //Field offset: 0xD8
	private bool _isAbsoluteGrounded; //Field offset: 0xD9
	private float _skinWidth; //Field offset: 0xDC
	private float _slopLimit; //Field offset: 0xE0
	[Header("Other")]
	[SerializeField]
	private float _slopLimitDot; //Field offset: 0xE4
	private float _stepOffset; //Field offset: 0xE8
	[SerializeField]
	private float _stepOffsetInternal; //Field offset: 0xEC
	private Vector3 _velocity; //Field offset: 0xF0
	private Vector3 _surfaceNormalAccordingToCapsule; //Field offset: 0xFC
	private Func _canSeepThroughDelegate; //Field offset: 0x108

	public override event Action OnHeightChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private override Rigidbody attachedRigidbody
	{
		 get { } //Length: 62
		private set { } //Length: 62
	}

	public private override Bounds bounds
	{
		 get { } //Length: 144
		private set { } //Length: 3
	}

	public override Vector3 center
	{
		 get { } //Length: 138
		 set { } //Length: 112
	}

	public private override CollisionFlags collisionFlags
	{
		 get { } //Length: 62
		private set { } //Length: 62
	}

	public override float contactOffset
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool detectCollisions
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	public override float height
	{
		 get { } //Length: 90
		 set { } //Length: 152
	}

	public override bool isEnabled
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public private override bool isGrounded
	{
		 get { } //Length: 8
		private set { } //Length: 7
	}

	public bool IsMoveIgnored
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private bool IsSeepingActive
	{
		private get { } //Length: 21
	}

	public override bool IsSpeedLimitWasEnabledAtTheFrame
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override float radius
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool ShouldStickToGround
	{
		 get { } //Length: 3
	}

	public override float skinWidth
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public override float slopeLimit
	{
		 get { } //Length: 9
		 set { } //Length: 47
	}

	public override float SpeedLimit
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public override float stepOffset
	{
		 get { } //Length: 9
		 set { } //Length: 25
	}

	public override bool SupportDepenetration
	{
		 get { } //Length: 3
	}

	public private Vector3 surfaceNormalAccordingToCapsule
	{
		 get { } //Length: 25
		private set { } //Length: 22
	}

	public private override Vector3 velocity
	{
		 get { } //Length: 25
		private set { } //Length: 22
	}

	public SimpleCharacterController() { }

	[CompilerGenerated]
	public override void add_OnHeightChanged(Action value) { }

	public void AddNoSpeedLimitCollisionColliders(IEnumerable colliders) { }

	private void CalculateVelocity(Vector3 currentPoint, Vector3 destinationPoint, float deltaTime) { }

	private bool CanStandAt(Vector3 point) { }

	private void CheckSpeedLimit(Vector3 startPosition, float deltaTime) { }

	private void ClearSeepColliders(CollidersArray neighboursColliders) { }

	public override void CopyFields(CharacterControllerFootprint footprint) { }

	public override void CopyFields(ICharacterController characterController) { }

	[Conditional("UNITY_EDITOR")]
	private void DebugLabel(string name, T msg) { }

	[Conditional("UNITY_EDITOR")]
	private void DebugLog(string message, object[] args) { }

	private void FindCollidersForSeep() { }

	private void FindCollidersForSeep(CollidersArray collidersArray) { }

	private bool FindSomethingToStepUp(Vector3 startPoint, Vector3 forwardDirection, float forwardDistance, out RaycastHit bestHit) { }

	public override Rigidbody get_attachedRigidbody() { }

	public override Bounds get_bounds() { }

	public override Vector3 get_center() { }

	public override CollisionFlags get_collisionFlags() { }

	public override float get_contactOffset() { }

	public override bool get_detectCollisions() { }

	public override float get_height() { }

	public override bool get_isEnabled() { }

	public override bool get_isGrounded() { }

	[CompilerGenerated]
	public bool get_IsMoveIgnored() { }

	private bool get_IsSeepingActive() { }

	[CompilerGenerated]
	public override bool get_IsSpeedLimitWasEnabledAtTheFrame() { }

	public override float get_radius() { }

	public override bool get_ShouldStickToGround() { }

	public override float get_skinWidth() { }

	public override float get_slopeLimit() { }

	public override float get_SpeedLimit() { }

	public override float get_stepOffset() { }

	public override bool get_SupportDepenetration() { }

	public Vector3 get_surfaceNormalAccordingToCapsule() { }

	public override Vector3 get_velocity() { }

	public override Collider GetCollider() { }

	public override CharacterControllerFootprint GetFootprint() { }

	private int GetSeepLayerLevel(Collider collider) { }

	private bool HasOverlap(int count, Collider[] colliders) { }

	private bool HasOverlap(int count, RaycastHit[] colliders) { }

	public void Init(Transform movementTransform, Collider[] colliders, CapsuleCollider mainCollider, float fixedDeltaDistance, LayerMask collisionMask, float stepOffset, float slopeLimit) { }

	private bool IsColliderIgnored(Collider collider) { }

	private bool IsOverlappedWithNeighbourCollider(LayerMask layerMask) { }

	private bool IsOverlappedWithNoSpeedLimitCollider() { }

	public override CollisionFlags Move(Vector3 motion, float deltaTime) { }

	private void OnDrawGizmos() { }

	private bool Raycast(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, out RaycastHit bestHit) { }

	public void RegisterCanSeepThroughDelegate(Func canSeepThroughDelegate) { }

	[CompilerGenerated]
	public override void remove_OnHeightChanged(Action value) { }

	public void RemoveNoSpeedLimitCollisionColliders(IEnumerable colliders) { }

	private int ResolvePenetration(Vector3 desiredPoint, bool updateNeighbours, bool doSnapToGround, out Vector3 resolvedPoint, out bool feelingTightMain) { }

	private int ResolvePenetration(Collider collider, CollidersArray neighboursColliders, Vector3 desiredPoint, float snapGroundDenepentrationToUp, bool updateNeighbours, out Vector3 resolvedPoint, out Vector3 surfaceNormal, out bool feelingTight) { }

	private Vector3 ResolveUnityDepenetrationBug(Vector3 point) { }

	public void SeGroundDotThreshold(float degrees) { }

	public void SeSlotLimitDot(float degrees) { }

	private void set_attachedRigidbody(Rigidbody value) { }

	private void set_bounds(Bounds value) { }

	public override void set_center(Vector3 value) { }

	private void set_collisionFlags(CollisionFlags value) { }

	public override void set_contactOffset(float value) { }

	public override void set_detectCollisions(bool value) { }

	public override void set_height(float value) { }

	public override void set_isEnabled(bool value) { }

	private void set_isGrounded(bool value) { }

	[CompilerGenerated]
	public void set_IsMoveIgnored(bool value) { }

	[CompilerGenerated]
	public override void set_IsSpeedLimitWasEnabledAtTheFrame(bool value) { }

	public override void set_radius(float value) { }

	public override void set_skinWidth(float value) { }

	public override void set_slopeLimit(float value) { }

	public override void set_SpeedLimit(float value) { }

	public override void set_stepOffset(float value) { }

	private void set_surfaceNormalAccordingToCapsule(Vector3 value) { }

	private void set_velocity(Vector3 value) { }

	private void SetColliders(Collider[] colliders) { }

	public override void SetEnableVerticalDepenetration(bool enable) { }

	public void SeTightDotThreshold(float degrees) { }

	public void SetSnapGroundDenepentrationToUpInDegrees(float degrees) { }

	public override void SetSteerDirection(Vector3 steerDirection) { }

	public override bool SimpleMove(Vector3 motion) { }

	private void SingleMove(Vector3 motion) { }

	private Vector3 TryToStepUp(Vector3 startPoint, Vector3 motion, Vector3 desiredPoint) { }

	private void UpdateNeighboursColliders(Collider collider, CollidersArray neighboursColliders, Vector3 desiredPoint) { }

}

