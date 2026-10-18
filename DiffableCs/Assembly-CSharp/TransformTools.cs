//Type is in global namespace

[Extension]
public static class TransformTools
{

	[CanBeNull]
	public static Transform FindActiveTransformRecursive(Transform root, string name) { }

	internal static void FindAllTransformsWithName(Transform root, string searchName, List aimList) { }

	internal static List FindAllTransformsWithNameContains(Transform root, string searchName, bool activeOnly, string[] ignore) { }

	internal static int FindAllTransformsWithNameContains(Transform root, string searchName, List yourList, bool activeOnly, string[] ignore) { }

	internal static List FindAllTransformsWithNameStartsWith(Transform root, string searchName, bool activeOnly, string[] ignore) { }

	internal static int FindAllTransformsWithNameStartsWith(Transform root, string searchName, List yourList, bool activeOnly, string[] ignore) { }

	public static List FindChildsByNameRecNoneAlloc(Transform root, string name, List childs, bool activeInHierarchyOnly = false) { }

	[CanBeNull]
	[Extension]
	public static Transform FindTransform(Transform root, string name) { }

	[CanBeNull]
	public static Transform FindTransformRecursive(Transform root, string name, bool ignoreCase = false) { }

	[CanBeNull]
	public static Transform FindTransformRecursiveContains(Transform root, string name, bool activeInHierarchyOnly = false) { }

	[CanBeNull]
	public static Transform FindTransformRecursiveWidthFirst(Transform root, string name) { }

	[CanBeNull]
	[Extension]
	public static Transform FindTransformWhere(Transform root, Func where) { }

	public static Bounds GetAllBounds(GameObject itemGameObject) { }

	public static Matrix4x4 GetMatrixRelativeToParent(Transform parent, Transform child) { }

	public static Matrix4x4 GetMatrixRelativeToTransform(Transform parent, Transform my, Transform another) { }

	[CanBeNull]
	public static Transform GetMutualTransform(Transform a, Transform b) { }

	public static Vector3 GetPosition(Matrix4x4 m) { }

	public static Vector3 GetPositionRelativeToParent(Transform parent, Transform child) { }

	public static void GetPosRotRelativeToParent(Transform parent, Transform child, out Vector3 position, out Quaternion rotation) { }

	public static Quaternion GetRotation(Matrix4x4 m) { }

	public static Quaternion GetRotationRelativeToParent(Transform parent, Transform child) { }

	[Extension]
	public static void LerpPositionAndRotation(Transform transform, Vector3 newPos, Quaternion newRot, float t) { }

	public static Quaternion LocalIdenity(Transform parent, Transform child) { }

	[Extension]
	public static void LocalRotateAround(Transform t, Vector3 center, Vector3 eulerRotation) { }

	[Extension]
	public static void LookAtAround(Transform t, Vector3 center, Quaternion rot) { }

	public static int NumParents(Transform child, Transform parent, int index = 0) { }

	public static void ParentToInitial(Transform transform, Transform parentTransform) { }

	[Extension]
	public static float Random(Vector2 v, bool randomizeSign = false) { }

	[Extension]
	public static int Random(Vector2Int v, bool randomizeSign = false) { }

	[Extension]
	public static float RandomInt(Vector2 v, bool randomizeSign = false) { }

	public static void Render(Transform T, Vector3 position, Quaternion rotation, int layer, Camera camera, bool fast = true) { }

	private static void RenderReqursiveFast(Transform t, HashSet transforms, Vector3 position, Quaternion rotation, int layer, Camera camera) { }

	private static void RenderReqursiveWithMatrix(Transform t, HashSet transforms, Matrix4x4 matrix, int layer, Camera camera) { }

	[Extension]
	public static void RotateAround(Transform t, Vector3 center, Quaternion rot) { }

	[Extension]
	public static void RotateAround(Transform t, Vector3 center, Vector3 eulerRotation, Quaternion q) { }

	[Extension]
	public static void RotateAround(Transform t, Vector3 center, Vector3 eulerRotation) { }

	public static void SetLayersRecursively(GameObject gameObject, int layer) { }

	public static void SetLayersRecursively(GameObject gameObject, int layer, string[] ignore) { }

	public static void SetLayersRecursively(GameObject gameObject, int layer) { }

	public static void SetLayersRecursively(GameObject gameObject, int layer, string[] ignore) { }

}

