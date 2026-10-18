namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class PropertyOrderAttribute : Attribute
{
	public float Order; //Field offset: 0x10

	public PropertyOrderAttribute() { }

	public PropertyOrderAttribute(float order) { }

}

