namespace Audio.Weapons;

public interface IAudioSourceFactory
{

	public BetterSource Create(AudioSourceGroupType groupType, bool persistent, Transform parent, bool isFirstPerson) { }

}

