namespace EFT.NextObservedPlayer;

public struct DefaultHandsOperationResult : IHandsOperationResult
{
	[CompilerGenerated]
	private readonly Task <Complete>k__BackingField; //Field offset: 0x0

	public override Task Complete
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public DefaultHandsOperationResult(Task complete) { }

	public static DefaultHandsOperationResult CompletedInstance() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override Task get_Complete() { }

}

