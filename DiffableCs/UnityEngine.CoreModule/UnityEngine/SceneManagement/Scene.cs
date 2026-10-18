namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[HideInInspector]
	[SerializeField]
	private int m_Handle; //Field offset: 0x0

	public int buildIndex
	{
		 get { } //Length: 76
	}

	public int handle
	{
		 get { } //Length: 5
	}

	public bool isLoaded
	{
		 get { } //Length: 76
	}

	public string name
	{
		 get { } //Length: 76
		 set { } //Length: 91
	}

	public string path
	{
		 get { } //Length: 76
	}

	public int rootCount
	{
		 get { } //Length: 76
	}

	public virtual bool Equals(object other) { }

	public int get_buildIndex() { }

	public int get_handle() { }

	public bool get_isLoaded() { }

	public string get_name() { }

	public string get_path() { }

	public int get_rootCount() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static int GetBuildIndexInternal(int sceneHandle) { }

	public virtual int GetHashCode() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetPathInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static int GetRootCountInternal(int sceneHandle) { }

	public GameObject[] GetRootGameObjects() { }

	public void GetRootGameObjects(List rootGameObjects) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	public bool IsValid() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool IsValidInternal(int sceneHandle) { }

	public static bool op_Equality(Scene lhs, Scene rhs) { }

	public static bool op_Inequality(Scene lhs, Scene rhs) { }

	public void set_name(string value) { }

	[NativeThrows]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static void SetNameInternal(int sceneHandle, string name) { }

}

