namespace Sirenix.Serialization;

public class CustomLogger : ILogger
{
	private Action logWarningDelegate; //Field offset: 0x10
	private Action logErrorDelegate; //Field offset: 0x18
	private Action logExceptionDelegate; //Field offset: 0x20

	public CustomLogger(Action logWarningDelegate, Action logErrorDelegate, Action logExceptionDelegate) { }

	public override void LogError(string error) { }

	public override void LogException(Exception exception) { }

	public override void LogWarning(string warning) { }

}

