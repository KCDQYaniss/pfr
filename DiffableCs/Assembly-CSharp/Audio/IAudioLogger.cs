namespace Audio;

public interface IAudioLogger
{

	public EAudioLogLevel GetCurrentLogLevelMask() { }

	public void Log(EAudioLogLevel level, string message) { }

	public void SetLogLevel(EAudioLogLevel levelMask) { }

}

