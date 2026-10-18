namespace Sirenix.Serialization;

[AttributeUsage(AttributeTargets::Class (4))]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use a RegisterFormatterAttribute applied to the containing assembly instead.", True)]
public class CustomGenericFormatterAttribute : CustomFormatterAttribute
{
	public readonly Type SerializedGenericTypeDefinition; //Field offset: 0x18

	public CustomGenericFormatterAttribute(Type serializedGenericTypeDefinition, int priority = 0) { }

}

