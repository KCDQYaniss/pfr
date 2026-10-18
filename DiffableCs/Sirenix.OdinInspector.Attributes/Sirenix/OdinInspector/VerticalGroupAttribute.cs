namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class VerticalGroupAttribute : PropertyGroupAttribute
{
	public float PaddingTop; //Field offset: 0x38
	public float PaddingBottom; //Field offset: 0x3C

	public VerticalGroupAttribute(string groupId, float order = 0) { }

	public VerticalGroupAttribute(float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

