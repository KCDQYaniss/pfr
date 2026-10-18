namespace FilesChecker;

[Extension]
public static class CheckResultExtension
{

	[Extension]
	public static bool Cancelled(ICheckResult result) { }

	[Extension]
	public static bool Failed(ICheckResult result) { }

	[Extension]
	public static bool Succeed(ICheckResult result) { }

}

