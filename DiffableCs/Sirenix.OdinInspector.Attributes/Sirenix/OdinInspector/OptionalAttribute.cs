namespace Sirenix.OdinInspector;

[AttributeUsage(384, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class OptionalAttribute : Attribute
{

	public OptionalAttribute() { }

}

