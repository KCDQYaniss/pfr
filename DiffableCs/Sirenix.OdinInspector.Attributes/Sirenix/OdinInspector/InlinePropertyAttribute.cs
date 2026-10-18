namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False)]
[Conditional("UNITY_EDITOR")]
public class InlinePropertyAttribute : Attribute
{
	public int LabelWidth; //Field offset: 0x10

	public InlinePropertyAttribute() { }

}

