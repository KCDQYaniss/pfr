namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class IndentAttribute : Attribute
{
	public int IndentLevel; //Field offset: 0x10

	public IndentAttribute(int indentLevel = 1) { }

}

