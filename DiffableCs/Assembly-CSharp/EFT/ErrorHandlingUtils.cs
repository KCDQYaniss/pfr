namespace EFT;

[Extension]
public static class ErrorHandlingUtils
{
	private const string HTTP_ERROR_PREFIX = "http"; //Field offset: 0x0
	private static readonly HashSet _importantHTTPErrors; //Field offset: 0x0

	private static ErrorHandlingUtils() { }

	public static void AddCodeToImportantErrorsList(EBackendErrorCode code) { }

	[Extension]
	public static bool EqualsToInt(EBackendErrorCode code, int errorCode) { }

	[Extension]
	public static int GetIntCode(EBackendErrorCode code) { }

	public static int GetIntCode(string errorCode) { }

	public static bool IsHTTPError(int errorCode) { }

	public static bool IsUnknownError(int errorCode) { }

	public static void RemoveCodeFromImportantErrorsList(EBackendErrorCode code) { }

	public static bool TryParse(string errorCode, out EBackendErrorCode error) { }

}

