namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class CallerArgumentExpressionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <ParameterName>k__BackingField; //Field offset: 0x10

	public string ParameterName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CallerArgumentExpressionAttribute(string parameterName) { }

	[CompilerGenerated]
	public string get_ParameterName() { }

}

