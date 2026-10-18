namespace System.Runtime.Versioning;

[AttributeUsage(448, AllowMultiple = True, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class SupportedOSPlatformGuardAttribute : Attribute
{

	[NullableContext(1)]
	public SupportedOSPlatformGuardAttribute(string platformName) { }

}

