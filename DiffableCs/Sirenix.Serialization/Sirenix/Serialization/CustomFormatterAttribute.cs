namespace Sirenix.Serialization;

[AttributeUsage(AttributeTargets::Class (4))]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use a RegisterFormatterAttribute applied to the containing assembly instead.", True)]
public class CustomFormatterAttribute : Attribute
{
	public readonly int Priority; //Field offset: 0x10

	public CustomFormatterAttribute() { }

	public CustomFormatterAttribute(int priority = 0) { }

}

