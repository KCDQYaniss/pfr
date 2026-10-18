namespace EFT;

[Extension]
public static class OperationStatusExtensions
{

	[Extension]
	public static bool Finished(EOperationStatus status) { }

	[Extension]
	public static bool InProgress(EOperationStatus status) { }

}

