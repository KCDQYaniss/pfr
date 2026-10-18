//Type is in global namespace

public class BotSettingsInGameModif
{
	public float PrecicingSpeedCoef; //Field offset: 0x10
	public float AccuratySpeedCoef; //Field offset: 0x14
	public float LayChanceDangerCoef; //Field offset: 0x18
	public float VisibleDistCoef; //Field offset: 0x1C
	public float RuntimeVisionEffectK; //Field offset: 0x20
	public float ScatteringCoef; //Field offset: 0x24
	public float PriorityScatteringCoef; //Field offset: 0x28
	public float HearingDistCoef; //Field offset: 0x2C
	public float TriggerDownDelay; //Field offset: 0x30
	public float WaitInCoverCoef; //Field offset: 0x34
	public bool IsApplyed; //Field offset: 0x38

	public BotSettingsInGameModif() { }

	public BotSettingsInGameModif(float precicingSpeedCoef, float accuratySpeedCoef, float layChanceDangerCoef, float visibleDistCoef, float runtimeVisionEffectK, float scatteringCoef, float hearingDistCoef, float priorityScatteringCoef, float triggerDownDelay) { }

}

