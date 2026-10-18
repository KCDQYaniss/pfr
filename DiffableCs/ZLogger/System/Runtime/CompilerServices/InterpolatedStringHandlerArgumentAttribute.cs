namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class InterpolatedStringHandlerArgumentAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string[] <Arguments>k__BackingField; //Field offset: 0x10

	public string[] Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public InterpolatedStringHandlerArgumentAttribute(string argument) { }

	public InterpolatedStringHandlerArgumentAttribute(string[] arguments) { }

	[CompilerGenerated]
	public string[] get_Arguments() { }

}

