namespace EFT;

public interface ICustomAudioSettingsFactory
{

	public IPlayerCustomAudioSettings CreateClientPlayerSettings(BetterAudio betterAudio, IPlayer player) { }

	public IPlayerCustomAudioSettings CreateObservedAiPlayerSettings(WildSpawnType wildSpawnType, BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IPlayer player, WeaponPlaybackSettings weaponSettings) { }

	public IPlayerCustomAudioSettings CreateObservedPlayerSettings(BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IPlayer player, WeaponPlaybackSettings weaponSettings) { }

}

