namespace Diz.LanguageExtensions;

[IsReadOnly]
public struct OperationResult`1 : IOption
{
	public readonly TValue Value; //Field offset: 0x0
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

	public OperationResult`1(TValue value) { }

	public OperationResult`1(Error error) { }

	[CompilerGenerated]
	public override Error get_Error() { }

	public override bool get_Failed() { }

	public override bool get_Succeeded() { }

	public static OperationResult op_Implicit(Error error) { }

	public static OperationResult op_Implicit(TValue value) { }

	public static OperationResult op_Implicit(OperationResult value) { }

}

