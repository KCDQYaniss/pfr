namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False, AllowMultiple = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class DisableRuntimeMarshallingAttribute : Attribute
{

	public DisableRuntimeMarshallingAttribute() { }

}

