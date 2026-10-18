namespace EFT.InventoryLogic;

public class FoodDrinkTemplate : ItemTemplate, IFoodDrinkComponentTemplate, IHealthEffectsComponentTemplate, IStimulatorBuffsComponentTemplate
{
	public float MaxResource; //Field offset: 0x148
	[JsonProperty("foodUseTime")]
	public int UseTime; //Field offset: 0x14C
	[JsonProperty("effects_health")]
	public Dictionary HealthEffects; //Field offset: 0x150
	[JsonProperty("effects_damage")]
	public Dictionary DamageEffects; //Field offset: 0x158
	public string StimulatorBuffs; //Field offset: 0x160

	private override float EFT.InventoryLogic.IFoodDrinkComponentTemplate.MaxResource
	{
		private get { } //Length: 9
	}

	private override KeyValuePair[] EFT.InventoryLogic.IHealthEffectsComponentTemplate.BodyPartTimeMults
	{
		private get { } //Length: 3
	}

	private override Dictionary EFT.InventoryLogic.IHealthEffectsComponentTemplate.DamageEffects
	{
		private get { } //Length: 8
	}

	private override Dictionary EFT.InventoryLogic.IHealthEffectsComponentTemplate.HealthEffects
	{
		private get { } //Length: 8
	}

	private override float EFT.InventoryLogic.IHealthEffectsComponentTemplate.UseTime
	{
		private get { } //Length: 12
	}

	private override string EFT.InventoryLogic.IStimulatorBuffsComponentTemplate.StimulatorBuffs
	{
		private get { } //Length: 8
	}

	public FoodDrinkTemplate() { }

	private override float EFT.InventoryLogic.IFoodDrinkComponentTemplate.get_MaxResource() { }

	private override KeyValuePair[] EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_BodyPartTimeMults() { }

	private override Dictionary EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_DamageEffects() { }

	private override Dictionary EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_HealthEffects() { }

	private override float EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_UseTime() { }

	private override string EFT.InventoryLogic.IStimulatorBuffsComponentTemplate.get_StimulatorBuffs() { }

}

