namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : Object
{

	public bool activeInHierarchy
	{
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 78
	}

	public bool activeSelf
	{
		[NativeMethod(Name = "IsSelfActive")]
		 get { } //Length: 78
	}

	public GameObject gameObject
	{
		 get { } //Length: 6
	}

	public bool isStatic
	{
		[NativeMethod(Name = "GetIsStaticDeprecated")]
		 get { } //Length: 78
		[NativeMethod(Name = "SetIsStaticDeprecated")]
		 set { } //Length: 93
	}

	public int layer
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public Scene scene
	{
		[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
		 get { } //Length: 95
	}

	public string tag
	{
		[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
		 get { } //Length: 78
		[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
		 set { } //Length: 93
	}

	public Transform transform
	{
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public GameObject(string name, Type[] components) { }

	public GameObject() { }

	public GameObject(string name) { }

	public T AddComponent() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component AddComponent(Type componentType) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	public bool CompareTag(string tag) { }

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name) { }

	[NativeMethod(Name = "IsActive")]
	public bool get_activeInHierarchy() { }

	[NativeMethod(Name = "IsSelfActive")]
	public bool get_activeSelf() { }

	public GameObject get_gameObject() { }

	[NativeMethod(Name = "GetIsStaticDeprecated")]
	public bool get_isStatic() { }

	public int get_layer() { }

	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	public Scene get_scene() { }

	private void get_scene_Injected(out Scene ret) { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	public string get_tag() { }

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	public Transform get_transform() { }

	public T GetComponent() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	public T GetComponentInChildren(bool includeInactive) { }

	public T GetComponentInParent(bool includeInactive) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInParent() { }

	public void GetComponents(List results) { }

	public T[] GetComponents() { }

	public Component[] GetComponents(Type type) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInChildren(bool includeInactive, List results) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInParent(bool includeInactive, List results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public T[] GetComponentsInParent() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	private Component Internal_AddComponentWithType(Type componentType) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName, object value) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[NativeMethod(Name = "SetIsStaticDeprecated")]
	public void set_isStatic(bool value) { }

	public void set_layer(int value) { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	public void set_tag(string value) { }

	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value) { }

	public bool TryGetComponent(Type type, out Component component) { }

	public bool TryGetComponent(out T component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	internal Component TryGetComponentInternal(Type type) { }

}

