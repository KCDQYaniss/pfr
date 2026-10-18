//Type is in global namespace

public static class SoundOcclusionObstacleChecker
{
	private const float MIN_WALL_HEIGHT = 2.2; //Field offset: 0x0
	private const float MIN_WALL_WIDENESS = 3; //Field offset: 0x0
	private const float MIN_OBJECT_SIZE = 4; //Field offset: 0x0
	private const float MAX_OBSTACLE_EFFECT = 1; //Field offset: 0x0
	private const float MIN_OBSTACLE_EFFECT = 0.1; //Field offset: 0x0
	private const float SQR_MIN_DISTANCE_BETWEEN_OBSTACLES = 9; //Field offset: 0x0
	private const short MAX_BUFFER_SIZE = 2000; //Field offset: 0x0
	private static readonly Dictionary _tempHitsBallisticCache; //Field offset: 0x0
	private static readonly Dictionary _cachedBallisticColliders; //Field offset: 0x8
	private static BallisticCollider _cachedBallisticCollider; //Field offset: 0x10
	private static Vector3 _hitPoint; //Field offset: 0x18
	private static Vector3 _prevHit; //Field offset: 0x24
	private static Vector3 _colliderSize; //Field offset: 0x30
	private static float _thickness; //Field offset: 0x3C
	private static int _tempColliderHash; //Field offset: 0x40

	private static SoundOcclusionObstacleChecker() { }

	private static float CalculateObstaclesEffect() { }

	private static void CheckHit(RaycastHit hit, bool verticalCheck) { }

	public static void Clear() { }

	public static float FindObstaclesEffect(RaycastHit[] hits, bool verticalCheck) { }

	private static bool IsHitsDifferent(Vector3 firstHit, Vector3 secondHit) { }

}

