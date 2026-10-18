namespace EFT;

public class PlayerCustomAudioSettingsFactory : ICustomAudioSettingsFactory
{

	public PlayerCustomAudioSettingsFactory() { }

	public override IPlayerCustomAudioSettings CreateClientPlayerSettings(BetterAudio betterAudio, IPlayer player) { }

	public override IPlayerCustomAudioSettings CreateObservedAiPlayerSettings(WildSpawnType wildSpawnType, BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IPlayer player, WeaponPlaybackSettings weaponSettings) { }

	public override IPlayerCustomAudioSettings CreateObservedPlayerSettings(BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IPlayer player, WeaponPlaybackSettings weaponSettings) { }

}

