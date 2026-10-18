namespace Diz.LanguageExtensions;

[IsReadOnly]
public struct OperationCreationResult`1 : IOption
{
	public readonly AbstractOperation Value; //Field offset: 0x0
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

	private OperationCreationResult`1(AbstractOperation value) { }

	private OperationCreationResult`1(Error error) { }

	[CompilerGenerated]
	public override Error get_Error() { }

	public override bool get_Failed() { }

	public override bool get_Succeeded() { }

	public static OperationCreationResult op_Implicit(AbstractOperation value) { }

	public static OperationCreationResult op_Implicit(OperationCreationResult value) { }

	public static OperationCreationResult op_Implicit(Error error) { }

}

