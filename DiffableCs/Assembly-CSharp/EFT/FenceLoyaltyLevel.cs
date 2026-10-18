namespace EFT;

public sealed class FenceLoyaltyLevel
{
	[JsonProperty("HostileBosses")]
	public readonly bool HostileBosses; //Field offset: 0x10
	[JsonProperty("ScavAttackSupport")]
	public readonly bool ScavAttackSupport; //Field offset: 0x11
	[JsonProperty("ReactOnMarkOnUnknowns")]
	public readonly bool ReactOnMarkOnUnknowns; //Field offset: 0x12
	[JsonProperty("HostileScavs")]
	public readonly bool HostileScavs; //Field offset: 0x13
	[JsonProperty("BotSpreadoutChance")]
	public readonly float BotSpreadoutChance; //Field offset: 0x14
	[JsonProperty("BotGetInCoverChance")]
	public readonly float BotGetInCoverChance; //Field offset: 0x18
	[JsonProperty("BotApplySilenceChance")]
	public readonly float BotApplySilenceChance; //Field offset: 0x1C
	[JsonProperty("BotStopChance")]
	public readonly float BotStopChance; //Field offset: 0x20
	[JsonProperty("BotHelpChance")]
	public readonly float BotHelpChance; //Field offset: 0x24
	[JsonProperty("BotFollowChance")]
	public readonly float BotFollowChance; //Field offset: 0x28
	[JsonProperty("SavageCooldownModifier")]
	public readonly float SavageCooldownModifier; //Field offset: 0x2C
	[JsonProperty("ScavCaseTimeModifier")]
	public readonly float ScavCaseTimeModifier; //Field offset: 0x30
	[JsonProperty("PaidExitCostModifier")]
	public readonly float PaidExitCostModifier; //Field offset: 0x34
	[JsonProperty("ScavEquipmentSpawnChanceModifier")]
	public readonly float ScavEquipmentSpawnChanceModifier; //Field offset: 0x38
	[JsonProperty("PriceModifier")]
	public readonly float PriceModifier; //Field offset: 0x3C
	[JsonProperty("ExfiltrationPriceModifier")]
	public readonly float ExfiltrationPriceModifier; //Field offset: 0x40
	[JsonProperty("AvailableExits")]
	public readonly int AvailableExits; //Field offset: 0x44
	[JsonProperty("PriceModTaxi")]
	public readonly float PriceModTaxi; //Field offset: 0x48
	[JsonProperty("PriceModDelivery")]
	public readonly float PriceModDelivery; //Field offset: 0x4C
	[JsonProperty("PriceModCleanUp")]
	public readonly float PriceModCleanUp; //Field offset: 0x50
	[JsonProperty("CanInteractWithBtr")]
	public readonly bool CanInteractWithBtr; //Field offset: 0x54
	[JsonProperty("DeliveryGridSize")]
	public readonly Vector3 DeliveryGridSize; //Field offset: 0x58
	[JsonProperty("CircleOfCultistsBonusPercent")]
	public readonly float CircleOfCultistsBonusPercent; //Field offset: 0x64
	[JsonProperty("TransitGridSize")]
	public readonly Vector3 TransitGridSize; //Field offset: 0x68
	[CompilerGenerated]
	private double <StandingRequired>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsMaxLevel>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <IsMinLevel>k__BackingField; //Field offset: 0x81

	public private bool IsMaxLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsMinLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private double StandingRequired
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public FenceLoyaltyLevel() { }

	[CompilerGenerated]
	public bool get_IsMaxLevel() { }

	[CompilerGenerated]
	public bool get_IsMinLevel() { }

	[CompilerGenerated]
	public double get_StandingRequired() { }

	public void Init(double minStanding, bool first, bool last) { }

	[CompilerGenerated]
	private void set_IsMaxLevel(bool value) { }

	[CompilerGenerated]
	private void set_IsMinLevel(bool value) { }

	[CompilerGenerated]
	private void set_StandingRequired(double value) { }

}

