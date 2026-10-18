namespace EFT.InventoryLogic;

public interface IHealthEffectsComponentTemplate : IStimulatorBuffsComponentTemplate
{

	public KeyValuePair[] BodyPartTimeMults
	{
		 get { } //Length: 0
	}

	public Dictionary DamageEffects
	{
		 get { } //Length: 0
	}

	public Dictionary HealthEffects
	{
		 get { } //Length: 0
	}

	public float UseTime
	{
		 get { } //Length: 0
	}

	public KeyValuePair[] get_BodyPartTimeMults() { }

	public Dictionary get_DamageEffects() { }

	public Dictionary get_HealthEffects() { }

	public float get_UseTime() { }

}

