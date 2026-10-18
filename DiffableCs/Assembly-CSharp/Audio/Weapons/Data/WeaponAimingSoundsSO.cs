namespace Audio.Weapons.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/WeaponAimingSoundsSO", fileName = "WeaponAimingSounds")]
public sealed class WeaponAimingSoundsSO : ScriptableObject
{
	[SerializeField]
	private AimingSounds _aimingSounds; //Field offset: 0x18

	public WeaponAimingSoundsSO() { }

	public bool TryGetAimingBank(ESoundWeaponType soundWeaponType, out SoundBankWithSettings bank) { }

}

