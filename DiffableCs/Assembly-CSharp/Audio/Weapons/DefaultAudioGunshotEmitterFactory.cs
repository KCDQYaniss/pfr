namespace Audio.Weapons;

public sealed class DefaultAudioGunshotEmitterFactory : IAudioGunshotEmitterFactory
{

	public DefaultAudioGunshotEmitterFactory() { }

	public override IAudioGunshotEmitter Create(BifacialTransform weaponHierarchy, WeaponPlaybackSettings playbackSettings, WeaponPoolSettings poolSettings, IServerTimeProvider serverTimeProvider, IAudioFireModeSelector fireModeSelector, bool isAutoWeapon, bool isFirstPerson) { }

}

