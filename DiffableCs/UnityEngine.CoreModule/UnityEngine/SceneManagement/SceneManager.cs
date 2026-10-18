namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager
{
	internal static bool s_AllowLoadScene; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction sceneLoaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction sceneUnloaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction activeSceneChanged; //Field offset: 0x18

	public static event UnityAction activeSceneChanged
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static event UnityAction sceneLoaded
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static event UnityAction sceneUnloaded
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static int sceneCount
	{
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		[NativeMethod("GetSceneCount")]
		[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
		 get { } //Length: 69
	}

	private static SceneManager() { }

	[CompilerGenerated]
	public static void add_activeSceneChanged(UnityAction value) { }

	[CompilerGenerated]
	public static void add_sceneLoaded(UnityAction value) { }

	[CompilerGenerated]
	public static void add_sceneUnloaded(UnityAction value) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeMethod("GetSceneCount")]
	[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
	public static int get_sceneCount() { }

	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene GetActiveScene() { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene GetSceneAt(int index) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene GetSceneByName(string name) { }

	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters) { }

	[ExcludeFromDocs]
	public static void LoadScene(int sceneBuildIndex) { }

	[ExcludeFromDocs]
	public static void LoadScene(string sceneName) { }

	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

	[CompilerGenerated]
	public static void remove_activeSceneChanged(UnityAction value) { }

	[CompilerGenerated]
	public static void remove_sceneLoaded(UnityAction value) { }

	[CompilerGenerated]
	public static void remove_sceneUnloaded(UnityAction value) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static bool SetActiveScene(Scene scene) { }

	private static bool SetActiveScene_Injected(ref Scene scene) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	public static AsyncOperation UnloadSceneAsync(string sceneName) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

