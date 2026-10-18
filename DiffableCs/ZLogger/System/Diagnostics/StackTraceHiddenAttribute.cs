namespace System.Diagnostics;

[AttributeUsage(108, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class StackTraceHiddenAttribute : Attribute
{

	public StackTraceHiddenAttribute() { }

}

