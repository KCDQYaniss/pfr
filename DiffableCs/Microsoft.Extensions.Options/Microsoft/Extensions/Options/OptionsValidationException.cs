namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class OptionsValidationException : Exception
{
	[CompilerGenerated]
	private readonly string <OptionsName>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly Type <OptionsType>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly IEnumerable <Failures>k__BackingField; //Field offset: 0xA0

	public IEnumerable Failures
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 69
	}

	public OptionsValidationException(string optionsName, Type optionsType, IEnumerable failureMessages) { }

	[CompilerGenerated]
	public IEnumerable get_Failures() { }

	public virtual string get_Message() { }

}

