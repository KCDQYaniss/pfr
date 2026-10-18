namespace Sirenix.Serialization;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
[EditorBrowsable(EditorBrowsableState::Never (1))]
public sealed class EmittedAssemblyAttribute : Attribute
{

	[Obsolete("This attribute cannot be used in code, and is only meant to be applied to dynamically emitted assemblies.", True)]
	public EmittedAssemblyAttribute() { }

}

