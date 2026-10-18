namespace Audio.AmbientSubsystem.GameEvents;

public interface IGameEventAudioPlayer
{

	public bool IsRunning
	{
		 get { } //Length: 0
	}

	public bool get_IsRunning() { }

	public void Run() { }

	public void Stop() { }

}

