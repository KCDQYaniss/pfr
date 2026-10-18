//Type is in global namespace

public static class PhysicsExtensions
{
	internal class ColliderSync : MonoBehaviour
	{
		private OverlapBoxSearcher _boxSearcher; //Field offset: 0x20
		private BoxCollider _collider; //Field offset: 0x28
		private Nullable _triggerId; //Field offset: 0x30

		public ColliderSync() { }

		public void Assign(OverlapBoxSearcher searcher, BoxCollider collider) { }

		private void OnDisable() { }

		private void OnEnable() { }

		public void Sync() { }

	}

	private static class Overseer
	{
		private const long _alertTime = 30000; //Field offset: 0x0
		private const float _alertDelay = 5; //Field offset: 0x0
		private const int _countForDetectStatus = 100; //Field offset: 0x0
		private static Stopwatch _stopwatch; //Field offset: 0x0
		private static long _beginTime; //Field offset: 0x8
		private static float _lastAlertTime; //Field offset: 0x10
		private static int _detectionCount; //Field offset: 0x14
		[CompilerGenerated]
		private static bool <RebuildingStaticCollidersDetected>k__BackingField; //Field offset: 0x18

		public private static bool RebuildingStaticCollidersDetected
		{
			[CompilerGenerated]
			 get { } //Length: 84
			[CompilerGenerated]
			private set { } //Length: 89
		}

		private static Overseer() { }

		private static void Alert(long passed) { }

		public static void BeginOperation() { }

		public static void EndOperation() { }

		[CompilerGenerated]
		public static bool get_RebuildingStaticCollidersDetected() { }

		[CompilerGenerated]
		private static void set_RebuildingStaticCollidersDetected(bool value) { }

	}

	internal static class Simulation
	{
		internal enum UpdateModeType
		{
			FixedUpdate = 0,
			Update = 1,
			QualityControl = 2,
			SmoothSimulate = 3,
		}

		private static bool _updateEnabled; //Field offset: 0x0
		public static UpdateModeType UpdateMode; //Field offset: 0x4
		private static float _quality; //Field offset: 0x8
		private static int _smoothSimulationSamplesCount; //Field offset: 0xC
		private static MovingAverage _simulationDeltaTimes; //Field offset: 0x10

		private static bool CanRunSimulate
		{
			private get { } //Length: 193
		}

		public static float Quality
		{
			 get { } //Length: 85
			 set { } //Length: 98
		}

		public static double SimulationAVGDeltaTime
		{
			 get { } //Length: 99
		}

		public static int SmoothSimulationSamplesCount
		{
			 get { } //Length: 83
			 set { } //Length: 268
		}

		public static bool SyncTransformsControlledByUnity
		{
			 get { } //Length: 123
			 set { } //Length: 132
		}

		public static bool UpdateControlledByUnity
		{
			 get { } //Length: 129
			 set { } //Length: 136
		}

		public static bool UpdateEnabled
		{
			 get { } //Length: 83
			 set { } //Length: 88
		}

		private static Simulation() { }

		public static void FixedUpdate() { }

		public static void ForceSyncTransforms() { }

		private static bool get_CanRunSimulate() { }

		public static float get_Quality() { }

		public static double get_SimulationAVGDeltaTime() { }

		public static int get_SmoothSimulationSamplesCount() { }

		public static bool get_SyncTransformsControlledByUnity() { }

		public static bool get_UpdateControlledByUnity() { }

		public static bool get_UpdateEnabled() { }

		private static void QualityControlUpdate(float deltaTime) { }

		public static void set_Quality(float value) { }

		public static void set_SmoothSimulationSamplesCount(int value) { }

		public static void set_SyncTransformsControlledByUnity(bool value) { }

		public static void set_UpdateControlledByUnity(bool value) { }

		public static void set_UpdateEnabled(bool value) { }

		public static void SetAVGSimulationDeltaTime(float time) { }

		private static void Simulate(float deltaTime) { }

		private static void SmoothSimulate(float deltaTime) { }

		public static void SyncTransforms() { }

		public static void Update() { }

	}

	internal static class UpdateController
	{
		internal static class Quality
		{
			public const float Low = 0; //Field offset: 0x0
			public const float High = 1; //Field offset: 0x0

		}

		internal struct RigidbodyData
		{
			public Rigidbody rigidbody; //Field offset: 0x0
			public ObjectVisibility visibilityChecker; //Field offset: 0x8

		}

		private const float _defaultQuality = 1; //Field offset: 0x0
		private static List _rigidbodies; //Field offset: 0x0
		private static bool _enabled; //Field offset: 0x8

		public static bool Enabled
		{
			 get { } //Length: 84
			 set { } //Length: 432
		}

		private static UpdateController() { }

		private static void CheckRigidbodiesDone() { }

		public static bool get_Enabled() { }

		public static void set_Enabled(bool value) { }

		private static void SimulationEnabled(bool enabled) { }

		public static void SupportRigidbody(Rigidbody rigidbody, float quality = 1, ObjectVisibility visibilityChecker = null) { }

		public static void UnsupportRigidbody(Rigidbody rigidbody) { }

		public static void Update() { }

	}

	internal static class Worlds
	{
		internal sealed class AwaitMultiWorldsOverlapBoxAsyncData
		{
			public static readonly AwaitMultiWorldsOverlapBoxAsyncData EmptyComplete; //Field offset: 0x0
			public Collider[] Results; //Field offset: 0x10
			public Collider[][] Buffers; //Field offset: 0x18
			public bool IsComplete; //Field offset: 0x20
			public int TotalWorldsCount; //Field offset: 0x24
			public int Count; //Field offset: 0x28
			private int _completeWorldsCount; //Field offset: 0x2C

			private static AwaitMultiWorldsOverlapBoxAsyncData() { }

			public AwaitMultiWorldsOverlapBoxAsyncData() { }

			public void OneWorldCompleteCallback(int index, int count) { }

			public void Reset() { }

		}

		internal class DefaultWorld : World
		{

			public DefaultWorld() { }

			public virtual void Create() { }

			protected virtual void ExtractGameObjectsToPhysicsScene() { }

			public virtual bool IsSupportingMask(int mask) { }

		}

		internal class DisablerCullingObjectTriggersWorld : World
		{

			public DisablerCullingObjectTriggersWorld() { }

			protected virtual void ExtractGameObjectsToPhysicsScene() { }

			public virtual bool IsSupportingMask(int mask) { }

		}

		[Flags]
		internal enum EWorldType
		{
			Default = 2,
			VolumePropagationAndEnvironmentSwitcherTriggers = 4,
			DisablerCullingObjectTriggers = 8,
		}

		internal class VolumePropagationAndEnvironmentSwitcherTriggersWorld : World
		{

			public VolumePropagationAndEnvironmentSwitcherTriggersWorld() { }

			[CompilerGenerated]
			private void <ExtractGameObjectsToPhysicsScene>g__MoveObjectsToAdditionalPhysScene|2_0(IEnumerable betterPropagationVolumes1, bool moveWithChild = false) { }

			protected virtual void ExtractGameObjectsToPhysicsScene() { }

			public virtual bool IsSupportingMask(int mask) { }

		}

		internal abstract class World
		{
			protected Scene _scene; //Field offset: 0x10
			protected PhysicsScene _physicsScene; //Field offset: 0x14
			protected List _customOverlapsBoxSearchers; //Field offset: 0x18
			private int _freeOverlapSearcherIndex; //Field offset: 0x20
			[CompilerGenerated]
			private bool <IsCreated>k__BackingField; //Field offset: 0x24
			[CompilerGenerated]
			private EWorldType <WorldType>k__BackingField; //Field offset: 0x28
			[CompilerGenerated]
			private string <Name>k__BackingField; //Field offset: 0x30

			public bool IsCreated
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				 set { } //Length: 4
			}

			public private string Name
			{
				[CompilerGenerated]
				 get { } //Length: 76
				[CompilerGenerated]
				private set { } //Length: 82
			}

			public private EWorldType WorldType
			{
				[CompilerGenerated]
				 get { } //Length: 4
				[CompilerGenerated]
				private set { } //Length: 4
			}

			public World(EWorldType worldType) { }

			public bool CanBeUsed(EWorldType worldTypeMask, int castMask) { }

			public override void Create() { }

			protected abstract void ExtractGameObjectsToPhysicsScene() { }

			[CompilerGenerated]
			public bool get_IsCreated() { }

			[CompilerGenerated]
			public string get_Name() { }

			[CompilerGenerated]
			public EWorldType get_WorldType() { }

			public abstract bool IsSupportingMask(int mask) { }

			protected void MoveToScene(GameObject target, bool moveWithChild = false) { }

			private void OnSceneUnloaded(Scene scene) { }

			public int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

			public void OverlapBoxNonAllocAsync(int index, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction, AwaitMultiWorldsOverlapBoxAsyncData asyncData) { }

			public int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

			public int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

			[CompilerGenerated]
			protected void set_IsCreated(bool value) { }

			[CompilerGenerated]
			private void set_Name(string value) { }

			[CompilerGenerated]
			private void set_WorldType(EWorldType value) { }

		}

		public static DefaultWorld Default; //Field offset: 0x0
		public static VolumePropagationAndEnvironmentSwitcherTriggersWorld VolumePropagationAndEnvironmentSwitcherTriggers; //Field offset: 0x8
		public static DisablerCullingObjectTriggersWorld DisablerCullingObjectTriggers; //Field offset: 0x10
		private static List _worlds; //Field offset: 0x18

		private static Worlds() { }

		public static void Create() { }

		private static ValueTuple CreatePhysicsScene(string sceneName) { }

		public static AwaitMultiWorldsOverlapBoxAsyncData OverlapBoxAsync(EWorldType worldTypeMask, Vector3 center, Vector3 halfExtents, Collider[][] buffers, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction, AwaitMultiWorldsOverlapBoxAsyncData complete) { }

		private static int OverlapBoxNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

		public static int OverlapBoxNonAlloc(EWorldType worldTypeMask, Vector3 center, Vector3 halfExtents, Collider[] results, Collider[] tempBuffer, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

		private static int OverlapSphereNonAlloc(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

		public static int OverlapSphereNonAlloc(EWorldType worldTypeMask, Vector3 position, float radius, Collider[] results, Collider[] tempBuffer, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	}

	private static Dictionary _ignoreCollisionMatrix; //Field offset: 0x0
	private const int _linecastPreciseMaxIterations = 8; //Field offset: 0x0
	private const float _linecastPreciseExtend = 0.001; //Field offset: 0x0

	public static bool RebuildingStaticCollidersDetected
	{
		 get { } //Length: 148
	}

	private static PhysicsExtensions() { }

	public static void FixedUpdate() { }

	public static void ForceSyncTransforms() { }

	public static bool get_RebuildingStaticCollidersDetected() { }

	public static bool GetIgnoreCollision(Collider collider1, Collider collider2) { }

	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore = true) { }

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit bestHit, LayerMask layerMask, bool reverseCheck, RaycastHit[] raycastHits, Func isHitIgnoredTest) { }

	public static bool Linecast(Vector3 start, Vector3 end, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction, out RaycastHit hit) { }

	public static bool LinecastInBothSides(Vector3 start, Vector3 end, out RaycastHit bestHit, out bool isForwardHit, LayerMask forwardLayerMask, LayerMask backwardLayerMask, RaycastHit[] raycastHits, Func isHitIgnoredTest) { }

	public static bool LinecastPrecise(Vector3 start, Vector3 end, out RaycastHit bestHit, LayerMask layerMask, bool reverseCheck, RaycastHit[] raycastHits, Func isHitIgnoredTest) { }

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool RaycastNonAlloc(Ray ray, ref RaycastHit[] hitInfos, float maxDistance, int layerMask) { }

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static void SyncTransforms() { }

	public static void Update() { }

	private static void WriteIgnoreCollisionMatrix(Collider collider1, Collider collider2, bool ignore) { }

}

