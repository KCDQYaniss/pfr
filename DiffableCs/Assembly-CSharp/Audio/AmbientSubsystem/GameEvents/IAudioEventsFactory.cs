namespace Audio.AmbientSubsystem.GameEvents;

public interface IAudioEventsFactory
{

	public IGameEventAudioPlayer CreateChristmasEventPlayer() { }

	public IGameEventAudioPlayer CreateFakeEventPlayer() { }

	public IGameEventAudioPlayer CreateHalloweenEventPlayer() { }

}

