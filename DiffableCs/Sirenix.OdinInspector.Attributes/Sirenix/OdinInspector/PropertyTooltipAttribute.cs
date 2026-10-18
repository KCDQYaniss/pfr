namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class PropertyTooltipAttribute : Attribute
{
	public string Tooltip; //Field offset: 0x10

	public PropertyTooltipAttribute(string tooltip) { }

}

