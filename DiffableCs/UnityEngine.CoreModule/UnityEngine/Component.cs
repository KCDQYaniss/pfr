namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : Object
{

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public string tag
	{
		 get { } //Length: 156
		 set { } //Length: 171
	}

	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		 get { } //Length: 78
	}

	public Component() { }

	public bool CompareTag(string tag) { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	public GameObject get_gameObject() { }

	public string get_tag() { }

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	public Transform get_transform() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True)]
	public Component GetComponent(string type) { }

	public T GetComponent() { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public T GetComponentInChildren(bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	public T GetComponentInParent() { }

	public void GetComponents(Type type, List results) { }

	public void GetComponents(List results) { }

	public T[] GetComponents() { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public T[] GetComponentsInChildren() { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInChildren(bool includeInactive, List result) { }

	public void GetComponentsInChildren(List results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List results) { }

	public T[] GetComponentsInParent() { }

	[FreeFunction("SendMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void SendMessage(string methodName) { }

	public void set_tag(string value) { }

	public bool TryGetComponent(out T component) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

}

