namespace UnityEngine;

[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType::Arrow (1))]
public class Physics2D
{
	private static List m_LastDisabledRigidbody2D; //Field offset: 0x0

	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool autoSyncTransforms
	{
		 set { } //Length: 78
	}

	public static PhysicsScene2D defaultPhysicsScene
	{
		 get { } //Length: 5
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers
	{
		 get { } //Length: 69
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static SimulationMode2D simulationMode
	{
		 set { } //Length: 76
	}

	private static Physics2D() { }

	public static PhysicsScene2D get_defaultPhysicsScene() { }

	public static bool get_queriesHitTriggers() { }

	[RequiredByNativeCode]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCode]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List results, float distance = ∞) { }

	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	public static void set_autoSyncTransforms(bool value) { }

	public static void set_simulationMode(SimulationMode2D value) { }

}

