namespace EFT.Hideout;

public sealed class HideoutSettings
{
	public float generatorSpeedWithoutFuel; //Field offset: 0x10
	public float generatorFuelFlowRate; //Field offset: 0x14
	public float airFilterUnitFlowRate; //Field offset: 0x18
	public float gpuBoostRate; //Field offset: 0x1C
	public float cultistAmuletBonusPercent; //Field offset: 0x20

	public HideoutSettings() { }

}

