namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class RequiredInAttribute : Attribute
{
	public string ErrorMessage; //Field offset: 0x10
	public PrefabKind PrefabKind; //Field offset: 0x18

	public RequiredInAttribute(PrefabKind kind) { }

}

