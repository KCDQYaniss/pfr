namespace Diz.LanguageExtensions;

[IsReadOnly]
public struct Option : IOption
{
	[CompilerGenerated]
	private readonly Error <Error>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <Failed>k__BackingField; //Field offset: 0x8

	[CanBeNull]
	public override Error Error
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override bool Failed
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool Succeeded
	{
		 get { } //Length: 8
	}

	public Option(Error error) { }

	[CompilerGenerated]
	public override Error get_Error() { }

	[CompilerGenerated]
	public override bool get_Failed() { }

	public override bool get_Succeeded() { }

	public static Option op_Implicit(Error error) { }

}

