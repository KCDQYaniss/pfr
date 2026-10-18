namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Constructor (32), AllowMultiple = False, Inherited = False)]
[ExcludeFromCodeCoverage]
internal sealed class SetsRequiredMembersAttribute : Attribute
{

	public SetsRequiredMembersAttribute() { }

}

