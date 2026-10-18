//Type is in global namespace

public class BotCoreSettings
{
	public float VisibleAngle; //Field offset: 0x10
	public float VisibleDistance; //Field offset: 0x14
	public float ScatteringPerMeter; //Field offset: 0x18
	public float ScatteringClosePerMeter; //Field offset: 0x1C
	public float DamageCoeff; //Field offset: 0x20
	public float HearingSense; //Field offset: 0x24
	public bool CanRun; //Field offset: 0x28
	public bool CanGrenade; //Field offset: 0x29
	public AimingType AimingType; //Field offset: 0x2C
	public float PistolFireDistancePref; //Field offset: 0x30
	public float ShotgunFireDistancePref; //Field offset: 0x34
	public float RifleFireDistancePref; //Field offset: 0x38
	public float AccuratySpeed; //Field offset: 0x3C
	public float WaitInCoverBetweenShotsSec; //Field offset: 0x40
	public string[] EffectImmunity; //Field offset: 0x48

	public BotCoreSettings() { }

	public BotCoreSettings(BotCoreSettings core) { }

}

