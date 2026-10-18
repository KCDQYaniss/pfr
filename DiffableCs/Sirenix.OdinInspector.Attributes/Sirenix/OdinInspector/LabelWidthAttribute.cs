namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class LabelWidthAttribute : Attribute
{
	public float Width; //Field offset: 0x10

	public LabelWidthAttribute(float width) { }

}

