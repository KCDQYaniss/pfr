namespace Audio;

public class NullAudioLogger : IAudioLogger
{
	private static IAudioLogger _instance; //Field offset: 0x0

	public static IAudioLogger Instance
	{
		 get { } //Length: 169
	}

	private NullAudioLogger() { }

	public static IAudioLogger get_Instance() { }

	public override EAudioLogLevel GetCurrentLogLevelMask() { }

	public override void Log(EAudioLogLevel level, string message) { }

	public override void SetLogLevel(EAudioLogLevel levelMask) { }

}

