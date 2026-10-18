namespace Audio.Weapons;

public interface IAudioGunshotEmitterFactory
{

	public IAudioGunshotEmitter Create(BifacialTransform weaponHierarchy, WeaponPlaybackSettings playbackSettings, WeaponPoolSettings poolSettings, IServerTimeProvider serverTimeProvider, IAudioFireModeSelector fireModeSelector, bool isAutoWeapon, bool isFirstPerson) { }

}

