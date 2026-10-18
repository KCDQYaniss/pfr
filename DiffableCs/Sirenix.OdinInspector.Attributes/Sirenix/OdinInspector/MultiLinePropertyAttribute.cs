namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MultiLinePropertyAttribute : Attribute
{
	public int Lines; //Field offset: 0x10

	public MultiLinePropertyAttribute(int lines = 3) { }

}

