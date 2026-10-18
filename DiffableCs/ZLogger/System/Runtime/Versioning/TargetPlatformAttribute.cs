namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class TargetPlatformAttribute : Attribute
{

	[NullableContext(1)]
	public TargetPlatformAttribute(string platformName) { }

}

