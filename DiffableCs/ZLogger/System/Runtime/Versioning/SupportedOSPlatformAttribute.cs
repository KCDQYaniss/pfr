namespace System.Runtime.Versioning;

[AttributeUsage(2047, AllowMultiple = True, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class SupportedOSPlatformAttribute : Attribute
{

	[NullableContext(1)]
	public SupportedOSPlatformAttribute(string platformName) { }

}

