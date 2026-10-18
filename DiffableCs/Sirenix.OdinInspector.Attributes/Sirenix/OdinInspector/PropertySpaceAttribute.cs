namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class PropertySpaceAttribute : Attribute
{
	public float SpaceBefore; //Field offset: 0x10
	public float SpaceAfter; //Field offset: 0x14

	public PropertySpaceAttribute() { }

	public PropertySpaceAttribute(float spaceBefore) { }

	public PropertySpaceAttribute(float spaceBefore, float spaceAfter) { }

}

