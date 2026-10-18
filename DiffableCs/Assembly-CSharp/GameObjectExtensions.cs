//Type is in global namespace

[Extension]
public static class GameObjectExtensions
{
	[CompilerGenerated]
	private struct <>c__DisplayClass15_0
	{
		public List objectsChildren; //Field offset: 0x0
		public Action onTick; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string part; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal bool <FindObjectByFullPath>b__0(GameObject o) { }

	}

	[CompilerGenerated]
	private struct <SetHierarchyActiveAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Action onTick; //Field offset: 0x20
		public GameObject object; //Field offset: 0x28
		public float delay; //Field offset: 0x30
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x38
		private float <startTime>5__2; //Field offset: 0x48
		private float <endTime>5__3; //Field offset: 0x4C
		private int <previousIndex>5__4; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x54

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SmartEnableAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject object; //Field offset: 0x20
		public float delay; //Field offset: 0x28
		public Action onTick; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[CompilerGenerated]
	internal static void <SetHierarchyActiveAsync>g__ImmediateEnable|15_0(ref <>c__DisplayClass15_0 unnamed_param_0) { }

	[CompilerGenerated]
	internal static void <SetHierarchyActiveAsync>g__TickChild|15_1(Transform transform, ref <>c__DisplayClass15_0 unnamed_param_1) { }

	[Extension]
	public static T AddComponentCopy(GameObject go, T source) { }

	[Extension]
	public static Material CopyToPreventMaterialChangeInEditor(Material material) { }

	[Extension]
	private static void DestroyAllChildren(Transform parent, bool onlyActive = false) { }

	[Extension]
	public static void DestroyAllChildren(GameObject parent, bool onlyActive = false) { }

	public static Transform FindObjectByFullPath(string path) { }

	[Extension]
	public static List GetChildren(Transform transform) { }

	[Extension]
	public static T GetComponentInChildrenActiveIgnoreFirstLevel(Transform transform) { }

	[Extension]
	public static List GetComponentsInChildrenActiveIgnoreFirstLevel(Transform transform) { }

	[Extension]
	public static string GetFullPath(Transform transform, bool withSceneName = false) { }

	[Extension]
	public static T GetOrAddComponent(MonoBehaviour component) { }

	[Extension]
	public static Component GetOrAddComponent(GameObject gameObject, Type type) { }

	[Extension]
	public static T GetOrAddComponent(GameObject gameObject) { }

	[Extension]
	public static GameObject InstantiatePrefab(Transform parent, GameObject prefab) { }

	[Extension]
	public static T InstantiatePrefab(GameObject parent, GameObject prefab) { }

	[Extension]
	public static T InstantiatePrefab(Transform parent, GameObject prefab) { }

	private static bool IsComponentActiveIgnoreFirstLevel(Component component, Transform firstLevel) { }

	[Extension]
	public static void ParentFake(Transform child, Transform parent) { }

	[Extension]
	public static void PreventMaterialChangeInEditor(Renderer renderer) { }

	[Extension]
	public static void SetActiveWithCheck(GameObject go, bool active) { }

	private static void SetFlaresActive(GameObject object, bool value) { }

	private static void SetHierarchyActive(GameObject object, bool value) { }

	[AsyncStateMachine(typeof(<SetHierarchyActiveAsync>d__15))]
	private static Task SetHierarchyActiveAsync(float delay, GameObject object, Action onTick) { }

	[Extension]
	public static void SmartDisable(GameObject object) { }

	[Extension]
	public static void SmartDisableWithoutHierarchy(GameObject object) { }

	[Extension]
	public static void SmartEnable(GameObject object) { }

	[AsyncStateMachine(typeof(<SmartEnableAsync>d__10))]
	[Extension]
	public static Task SmartEnableAsync(GameObject object, float delay, Action onTick = null) { }

	[Extension]
	public static void SmartEnableWithoutHierarchy(GameObject object) { }

	[Extension]
	public static bool TryGetComponentsInChildren(GameObject go, bool includeInactive, out T[] components) { }

}

