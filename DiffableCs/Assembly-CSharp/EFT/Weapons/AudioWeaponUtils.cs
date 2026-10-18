namespace EFT.Weapons;

public static class AudioWeaponUtils
{

	public static AudioMixerGroup GetGunshotOcclusionMixerGroup(float occlusionEffect, float threshold) { }

	public static float GetPitchByOverheat(Weapon shotWeapon) { }

	public static ValueTuple GetPitchOnShot(Weapon weapon, AnimationCurve pitchByAmmo, WeaponPlaybackSettings settings, bool isFirstPerson) { }

	public static float GetShotDuration(Weapon shotWeapon) { }

	public static ESoundWeaponType GetWeaponType(IWeapon weapon) { }

}

