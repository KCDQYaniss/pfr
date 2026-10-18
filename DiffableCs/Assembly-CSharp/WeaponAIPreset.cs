//Type is in global namespace

public class WeaponAIPreset
{
	public float BaseShift; //Field offset: 0x10
	public float XZ_COEF; //Field offset: 0x14
	public Func TriggerDownTime; //Field offset: 0x18
	public Func HoldTriggerUpTime; //Field offset: 0x20
	public EWeaponAIPresetType WeaponAIPresetType; //Field offset: 0x28

	public WeaponAIPreset(float baseShift, float xzCoef, Func triggerDownTime, Func holdTriggerUpTime, EWeaponAIPresetType weaponAIPresetType) { }

}

