namespace Sirenix.OdinInspector;

[AttributeUsage(1036, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class TypeInfoBoxAttribute : Attribute
{
	public string Message; //Field offset: 0x10

	public TypeInfoBoxAttribute(string message) { }

}

