//Type is in global namespace

public class BotLocationModifier
{
	public float AccuracySpeed; //Field offset: 0x10
	public float Scattering; //Field offset: 0x14
	public float GainSight; //Field offset: 0x18
	public float MarksmanAccuratyCoef; //Field offset: 0x1C
	public float VisibleDistance; //Field offset: 0x20
	public float DistToSleep; //Field offset: 0x24
	public float DistToActivate; //Field offset: 0x28
	public float LeaveDist; //Field offset: 0x2C
	public float DistToPersueAxemanCoef; //Field offset: 0x30
	public float MinExfiltrationTime; //Field offset: 0x34
	public float MaxExfiltrationTime; //Field offset: 0x38
	public AdditionalHostilitySettings[] AdditionalHostilitySettings; //Field offset: 0x40
	public float LockSpawnStartTime; //Field offset: 0x48
	public float LockSpawnStartTimePvE; //Field offset: 0x4C
	public float LockSpawnStepTime; //Field offset: 0x50
	public float LockSpawnStepTimePvE; //Field offset: 0x54
	public float LockSpawnCheckRadius; //Field offset: 0x58
	public float LockSpawnCheckRadiusPvE; //Field offset: 0x5C
	public int NonWaveSpawnBotsLimitPerPlayer; //Field offset: 0x60
	public int NonWaveSpawnBotsLimitPerPlayerPvE; //Field offset: 0x64
	public float FogVisibilitySpeedCoef; //Field offset: 0x68
	public float FogVisibilityDistanceCoef; //Field offset: 0x6C
	public float RainVisibilitySpeedCoef; //Field offset: 0x70
	public float RainVisibilityDistanceCoef; //Field offset: 0x74
	public bool IgnoreGreenAcidFollowPlayerEvent; //Field offset: 0x78

	public BotLocationModifier() { }

	public void Validate() { }

	private void ValidateVal(ref float val) { }

}

