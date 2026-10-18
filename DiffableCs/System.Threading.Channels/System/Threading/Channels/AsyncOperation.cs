namespace System.Threading.Channels;

internal abstract class AsyncOperation
{
	protected static readonly Action s_availableSentinel; //Field offset: 0x0
	protected static readonly Action s_completedSentinel; //Field offset: 0x8

	private static AsyncOperation() { }

	protected AsyncOperation() { }

	private static void AvailableSentinel(object s) { }

	private static void CompletedSentinel(object s) { }

	protected static void ThrowIncompleteOperationException() { }

	protected static void ThrowIncorrectCurrentIdException() { }

	protected static void ThrowMultipleContinuations() { }

}

