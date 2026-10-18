namespace Diz.LanguageExtensions;

[IsReadOnly]
public struct Option`1 : IOption
{
	public readonly TOk Value; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Error <Error>k__BackingField; //Field offset: 0x0

	[CanBeNull]
	public override Error Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool Failed
	{
		 get { } //Length: 41
	}

	public override bool Succeeded
	{
		 get { } //Length: 41
	}

	public Option`1(TOk value) { }

	public Option`1(Error error) { }

	public Option Cast(Func selector) { }

	[CompilerGenerated]
	public override Error get_Error() { }

	public override bool get_Failed() { }

	public override bool get_Succeeded() { }

	public static Option op_Implicit(Error error) { }

	public static Option op_Implicit(TOk value) { }

}

