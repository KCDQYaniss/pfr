namespace Sirenix.Serialization;

[AttributeUsage(384, AllowMultiple = False, Inherited = True)]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [HideInInspector] instead - it now also excludes the member completely from becoming a property in the property tree.", False)]
public sealed class ExcludeDataFromInspectorAttribute : Attribute
{

	public ExcludeDataFromInspectorAttribute() { }

}

