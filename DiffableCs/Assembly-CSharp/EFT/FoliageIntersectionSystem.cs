namespace EFT;

public sealed class FoliageIntersectionSystem
{
	private const float FOLIAGE_INTERSECTION_UPDATE_TIME = 1; //Field offset: 0x0
	private static Vector3Int _playerVolumeDescretizationAccuracy; //Field offset: 0x0
	public float FoliageIntersectionPercent; //Field offset: 0x10
	[CompilerGenerated]
	private Collider <CurrentFoliageTrigger>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Transform <CurrentFoliageRoot>k__BackingField; //Field offset: 0x20
	private float _foliageLastUpdateTime; //Field offset: 0x28
	private float _descretizationStepVolume; //Field offset: 0x2C
	private Vector3 _descretizationStepSize; //Field offset: 0x30
	private CapsuleCollider _playerCapsuleCollider; //Field offset: 0x40
	private Transform _playerCapsuleTransform; //Field offset: 0x48
	private Vector3 _playerCapsuleGlobalCenter; //Field offset: 0x50
	private float _playerCapsuleRadius; //Field offset: 0x5C
	private float _playerCapsuleHeight; //Field offset: 0x60
	private float _playerCapsuleVolume; //Field offset: 0x64
	private readonly Vector3[] _playerCapsuleLocalPoints; //Field offset: 0x68
	private readonly HashSet _foliageIntersectedLocalPointsIds; //Field offset: 0x70
	private bool _needUpdateFoliage; //Field offset: 0x78

	public private Transform CurrentFoliageRoot
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Collider CurrentFoliageTrigger
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static FoliageIntersectionSystem() { }

	public FoliageIntersectionSystem() { }

	private float CalculateIntersectionPercentage(Collider colliderToCheck) { }

	private float CalculateIntersectionVolume(Collider colliderToCheck) { }

	public void DrawGizmosFoliageIntersection(bool isAI, Player player) { }

	private void GenerateLocalPoints(CapsuleCollider capsuleCollider, out float stepVolume, out Vector3 stepSize) { }

	[CompilerGenerated]
	public Transform get_CurrentFoliageRoot() { }

	[CompilerGenerated]
	public Collider get_CurrentFoliageTrigger() { }

	private static bool IsPointInsideCapsule(Vector3 pointToCheckWorld, Vector3 capsuleCenterWorld, float capsuleHeight, float capsuleRadius, Quaternion capsuleRotationWorld, Vector3 worldScale, out Vector3 pointToCheckLocal) { }

	public void LateUpdate() { }

	public void RecalculateLocalPoints() { }

	[CompilerGenerated]
	private void set_CurrentFoliageRoot(Transform value) { }

	[CompilerGenerated]
	private void set_CurrentFoliageTrigger(Collider value) { }

	public void SetOwnerCollider(CapsuleCollider playerCapsule) { }

	public void StayInTreeUpdate(Collider enteredCollider, Collider triggerCollider, bool isAI) { }

}

