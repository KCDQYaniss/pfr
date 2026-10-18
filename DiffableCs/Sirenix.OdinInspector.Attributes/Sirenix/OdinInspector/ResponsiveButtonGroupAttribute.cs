namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[IncludeMyAttributes]
[ShowInInspector]
public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute
{
	public ButtonSizes DefaultButtonSize; //Field offset: 0x38
	public bool UniformLayout; //Field offset: 0x3C

	public ResponsiveButtonGroupAttribute(string group = "_DefaultResponsiveButtonGroup") { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

