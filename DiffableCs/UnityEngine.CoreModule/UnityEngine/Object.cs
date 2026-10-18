namespace UnityEngine;

[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class Object
{
	internal static int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x10

	public HideFlags hideFlags
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public string name
	{
		 get { } //Length: 132
		 set { } //Length: 147
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	[ExcludeFromDocs]
	public static void Destroy(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocs]
	public static void DestroyImmediate(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	public static void DontDestroyOnLoad(Object target) { }

	public virtual bool Equals(object other) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static Object FindObjectOfType(Type type, bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static Object FindObjectOfType(Type type) { }

	public static T FindObjectOfType() { }

	public static T[] FindObjectsByType(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	public static T[] FindObjectsOfType() { }

	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	internal static Object ForceLoadFromInstanceID(int instanceID) { }

	public HideFlags get_hideFlags() { }

	public string get_name() { }

	private IntPtr GetCachedPtr() { }

	public virtual int GetHashCode() { }

	public int GetInstanceID() { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	private static string GetName(Object obj) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static Object Instantiate(Object original) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Transform parent) { }

	public static T Instantiate(T original) { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunction("CloneObject")]
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("InstantiateObject")]
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

	private static bool IsNativeObjectAlive(Object o) { }

	public static bool op_Equality(Object x, Object y) { }

	public static bool op_Implicit(Object exists) { }

	public static bool op_Inequality(Object x, Object y) { }

	public void set_hideFlags(HideFlags value) { }

	public void set_name(string value) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	private static void SetName(Object obj, string name) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(Object obj) { }

	public virtual string ToString() { }

}

