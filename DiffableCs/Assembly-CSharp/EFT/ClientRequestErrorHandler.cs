namespace EFT;

public static class ClientRequestErrorHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <HandleMessage>b__13_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public ErrorWindowContext context; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <HandleGlobalErrors>g__CloseHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public ErrorWindowContext context; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal void <HandleWrongMajorVersion>g__CloseHandler|0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__QuitGame; //Field offset: 0x0

	}

	public const string VERSION_OUTDATED_HEADER = "NetworkError/version_outdated_header"; //Field offset: 0x0
	public const string VERSION_OUTDATED_MESSAGE = "NetworkError/version_outdated_message"; //Field offset: 0x0
	public const string TRADER_DISABLED_MESSAGE = "TraderError/TraderDisabled"; //Field offset: 0x0
	private const string AUTH_ERROR_HEADER = "AuthorizationErrorHeader"; //Field offset: 0x0
	private const string AUTH_ERROR_MESSAGE = "AuthorizationErrorMessage"; //Field offset: 0x0
	private const string SESSION_LOST_MESSAGE = "NetworkError/SessionLostErrorMessage"; //Field offset: 0x0
	private const string SYSTEM_MESSAGE_HEADER = "Authorization/SystemMessageHeader"; //Field offset: 0x0
	private const string FORCE_LOGOUT_MESSAGE = "Authorization/ForceLogoutMessage"; //Field offset: 0x0

	public static void ForceLogout() { }

	private static void HandleBackendErrors(EBackendErrorCode errorCode) { }

	public static ERequestErrorHandlingResult HandleError(int errorCode, string errorMessage, bool abortOnFail) { }

	private static void HandleGlobalErrors(string headerId, string messageId) { }

	public static void HandleMessage(string messageId) { }

	private static void HandleNoArenaSyncError(EBackendErrorCode errorCode) { }

	private static void HandleUnknownError(string errorMessage) { }

	public static void HandleWrongMajorVersion() { }

	private static void QuitGame() { }

}

