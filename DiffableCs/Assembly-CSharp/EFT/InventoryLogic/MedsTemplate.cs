namespace EFT.InventoryLogic;

public class MedsTemplate : ItemTemplate, IHealthEffectsComponentTemplate, IStimulatorBuffsComponentTemplate, IMedKitComponentTemplate
{
	[JsonProperty("medUseTime")]
	public float UseTime; //Field offset: 0x148
	[JsonProperty("bodyPartTimeMults")]
	public KeyValuePair[] BodyPartTimeMults; //Field offset: 0x150
	[JsonProperty("effects_health")]
	public Dictionary HealthEffects; //Field offset: 0x158
	[JsonProperty("effects_damage")]
	public Dictionary DamageEffects; //Field offset: 0x160
	public string StimulatorBuffs; //Field offset: 0x168
	[JsonProperty("MaxHpResource")]
	public int MaxHpResource; //Field offset: 0x170
	[JsonProperty("hpResourceRate")]
	public float HpResourceRate; //Field offset: 0x174
	[JsonProperty("bodyPartPriority")]
	public EBodyPart[] BodyPartPriority; //Field offset: 0x178

	private override KeyValuePair[] EFT.InventoryLogic.IHealthEffectsComponentTemplate.BodyPartTimeMults
	{
		private get { } //Length: 8
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
		private get { } //Length: 9
	}

	private override EBodyPart[] EFT.InventoryLogic.IMedKitComponentTemplate.BodyPartPriority
	{
		private get { } //Length: 8
	}

	private override float EFT.InventoryLogic.IMedKitComponentTemplate.HpResourceRate
	{
		private get { } //Length: 9
	}

	private override int EFT.InventoryLogic.IMedKitComponentTemplate.MaxHpResource
	{
		private get { } //Length: 7
	}

	private override string EFT.InventoryLogic.IStimulatorBuffsComponentTemplate.StimulatorBuffs
	{
		private get { } //Length: 8
	}

	public MedsTemplate() { }

	private override KeyValuePair[] EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_BodyPartTimeMults() { }

	private override Dictionary EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_DamageEffects() { }

	private override Dictionary EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_HealthEffects() { }

	private override float EFT.InventoryLogic.IHealthEffectsComponentTemplate.get_UseTime() { }

	private override EBodyPart[] EFT.InventoryLogic.IMedKitComponentTemplate.get_BodyPartPriority() { }

	private override float EFT.InventoryLogic.IMedKitComponentTemplate.get_HpResourceRate() { }

	private override int EFT.InventoryLogic.IMedKitComponentTemplate.get_MaxHpResource() { }

	private override string EFT.InventoryLogic.IStimulatorBuffsComponentTemplate.get_StimulatorBuffs() { }

}

