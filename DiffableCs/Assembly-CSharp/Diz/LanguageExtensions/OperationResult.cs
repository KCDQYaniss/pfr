namespace Diz.LanguageExtensions;

[IsReadOnly]
public struct OperationResult : IOption
{
	public readonly IOperationResult Value; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Error <Error>k__BackingField; //Field offset: 0x8

	[CanBeNull]
	public override Error Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool Failed
	{
		 get { } //Length: 9
	}

	public override bool Succeeded
	{
		 get { } //Length: 9
	}

	public OperationResult(IOperationResult value) { }

	public OperationResult(Error error) { }

	[CompilerGenerated]
	public override Error get_Error() { }

	public override bool get_Failed() { }

	public override bool get_Succeeded() { }

	public static OperationResult op_Implicit(Error error) { }

}

