//Type is in global namespace

public static class DebugExtension
{

	public static void DebugArrow(Vector3 position, Vector3 direction, float duration = 0, bool depthTest = true) { }

	public static void DebugArrow(Vector3 position, Vector3 direction, Color color, float duration = 0, bool depthTest = true) { }

	public static void DebugBounds(Bounds bounds, Color color, float duration = 0, bool depthTest = true) { }

	public static void DebugBounds(Bounds bounds, float duration = 0, bool depthTest = true) { }

	public static void DebugCapsule(Vector3 start, Vector3 end, Color color, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCapsule(Vector3 start, Vector3 end, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCircle(Vector3 position, Vector3 up, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCircle(Vector3 position, Vector3 up, Color color, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCircle(Vector3 position, Color color, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCircle(Vector3 position, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCone(Vector3 position, float angle = 45, float duration = 0, bool depthTest = true) { }

	public static void DebugCone(Vector3 position, Color color, float angle = 45, float duration = 0, bool depthTest = true) { }

	public static void DebugCone(Vector3 position, Vector3 direction, float angle = 45, float duration = 0, bool depthTest = true) { }

	public static void DebugCone(Vector3 position, Vector3 direction, Color color, float angle = 45, float duration = 0, bool depthTest = true) { }

	public static void DebugCube(Vector3 pos, Quaternion rot, Vector3 scale, Color c, float duration = 0) { }

	public static void DebugCylinder(Vector3 start, Vector3 end, Color color, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugCylinder(Vector3 start, Vector3 end, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugLocalCube(Transform transform, Vector3 size, Vector3 center = null, float duration = 0, bool depthTest = true) { }

	public static void DebugLocalCube(Transform transform, Vector3 size, Color color, Vector3 center = null, float duration = 0, bool depthTest = true) { }

	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Vector3 center = null, float duration = 0, bool depthTest = true) { }

	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Color color, Vector3 center = null, float duration = 0, bool depthTest = true) { }

	public static void DebugPlane(Vector3 position, Vector3 normal, Color color) { }

	public static void DebugPlane(Plane plane, float r, Color color) { }

	public static void DebugPoint(Vector3 position, Color color, float scale = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugPoint(Vector3 position, float scale = 1, float duration = 0, bool depthTest = true, Color color = null) { }

	public static void DebugWireSphere(Vector3 position, Color color, float radius = 1, float duration = 0, bool depthTest = true) { }

	public static void DebugWireSphere(Vector3 position, float radius = 1, Nullable color = null, float duration = 0, bool depthTest = true) { }

	public static void DrawArrow(Vector3 position, Vector3 direction) { }

	public static void DrawArrow(Vector3 position, Vector3 direction, Color color) { }

	public static void DrawBounds(Bounds bounds, Color color) { }

	public static void DrawBounds(Bounds bounds) { }

	public static void DrawCapsule(Vector3 start, Vector3 end, float radius = 1) { }

	public static void DrawCapsule(Vector3 start, Vector3 end, Color color, float radius = 1) { }

	public static void DrawCircle(Vector3 position, Color color, float radius = 1) { }

	public static void DrawCircle(Vector3 position, Vector3 up, float radius = 1) { }

	public static void DrawCircle(Vector3 position, Vector3 up, Color color, float radius = 1) { }

	public static void DrawCircle(Vector3 position, float radius = 1) { }

	public static void DrawCone(Vector3 position, Vector3 direction, Color color, float angle = 45) { }

	public static void DrawCone(Vector3 position, Vector3 direction, float angle = 45) { }

	public static void DrawCone(Vector3 position, Color color, float angle = 45) { }

	public static void DrawCone(Vector3 position, float angle = 45) { }

	public static void DrawCylinder(Vector3 start, Vector3 end, Color color, float radius = 1) { }

	public static void DrawCylinder(Vector3 start, Vector3 end, float radius = 1) { }

	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Vector3 center = null) { }

	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Color color, Vector3 center = null) { }

	public static void DrawLocalCube(Transform transform, Vector3 size, Vector3 center = null) { }

	public static void DrawLocalCube(Transform transform, Vector3 size, Color color, Vector3 center = null) { }

	public static void DrawPlane(Plane plane, float r, Color color) { }

	private static void DrawPlaneInternal(Plane plane, float r, Color color, bool debug) { }

	public static void DrawPoint(Vector3 position, float scale = 1) { }

	public static void DrawPoint(Vector3 position, Color color, float scale = 1) { }

	public static string MethodsOfObject(object obj, bool includeInfo = false) { }

	public static string MethodsOfType(Type type, bool includeInfo = false) { }

}

