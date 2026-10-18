namespace Audio.AmbientSubsystem.GameEvents;

public class AudioEventsFactory : IAudioEventsFactory
{

	public AudioEventsFactory() { }

	public override IGameEventAudioPlayer CreateChristmasEventPlayer() { }

	public override IGameEventAudioPlayer CreateFakeEventPlayer() { }

	public override IGameEventAudioPlayer CreateHalloweenEventPlayer() { }

}

