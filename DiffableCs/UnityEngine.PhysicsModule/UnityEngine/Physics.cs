namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
public class Physics
{
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		public ContactEventDelegate(object object, IntPtr method) { }

		public override void Invoke(PhysicsScene scene, ReadOnly headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x10
	private static readonly Collision s_ReusableCollision; //Field offset: 0x18

	public static bool autoSyncTransforms
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	[NativeProperty("DefaultPhysicsSceneHandle", True, TargetType::Function (0), True)]
	public static PhysicsScene defaultPhysicsScene
	{
		 get { } //Length: 140
	}

	public static Vector3 gravity
	{
		[ThreadSafe]
		 get { } //Length: 142
	}

	public static bool invokeCollisionCallbacks
	{
		 get { } //Length: 69
	}

	public static bool queriesHitBackfaces
	{
		 set { } //Length: 78
	}

	public static bool queriesHitTriggers
	{
		 get { } //Length: 69
	}

	public static bool reuseCollisionCallbacks
	{
		 get { } //Length: 69
	}

	public static SimulationMode simulationMode
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	private static Physics() { }

	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[ExcludeFromDocs]
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) { }

	[NativeName("BoxTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	[NativeName("SphereTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation) { }

	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	public static bool get_autoSyncTransforms() { }

	public static PhysicsScene get_defaultPhysicsScene() { }

	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	[ThreadSafe]
	public static Vector3 get_gravity() { }

	private static void get_gravity_Injected(out Vector3 ret) { }

	public static bool get_invokeCollisionCallbacks() { }

	public static bool get_queriesHitTriggers() { }

	public static bool get_reuseCollisionCallbacks() { }

	public static SimulationMode get_simulationMode() { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	public static bool GetIgnoreLayerCollision(int layer1, int layer2) { }

	[ExcludeFromDocs]
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[NativeName("IgnoreCollision")]
	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) { }

	[NativeName("RaycastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType::Dot (0))]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeName("RebuildBroadphaseRegions")]
	[StaticAccessor("GetPhysicsManager()")]
	private static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions) { }

	private static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions) { }

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	[RequiredByNativeCode]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[RequiredByNativeCode]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[NativeName("OverlapBox")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask) { }

	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	[ExcludeFromDocs]
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) { }

	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeName("OverlapSphere")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType::Dot (0))]
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeName("ClosestPoint")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point) { }

	private static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret) { }

	[NativeName("ComputePenetration")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions) { }

	private static void ReportContacts(ReadOnly array) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	public static void set_autoSyncTransforms(bool value) { }

	public static void set_queriesHitBackfaces(bool value) { }

	public static void set_simulationMode(SimulationMode value) { }

	public static void Simulate(float step) { }

	[NativeName("Simulate")]
	internal static void Simulate_Internal(PhysicsScene physicsScene, float step) { }

	private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) { }

	[ExcludeFromDocs]
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask) { }

	public static void SyncTransforms() { }

}

