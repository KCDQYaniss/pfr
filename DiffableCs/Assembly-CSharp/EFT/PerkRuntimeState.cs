namespace EFT;

public sealed class PerkRuntimeState
{
	public readonly PerkRuntimeValue[] Values; //Field offset: 0x10
	public readonly List ActiveEffects; //Field offset: 0x18
	public readonly float[] SkillExperienceMultipliers; //Field offset: 0x20
	public readonly int[] SkillMaxLevels; //Field offset: 0x28
	public readonly List SecureContainerRestrictions; //Field offset: 0x30
	public readonly List ItemUseEffects; //Field offset: 0x38
	public readonly List ResolvedItemUseEffects; //Field offset: 0x40
	public readonly Dictionary ItemUseEffectsByTemplateId; //Field offset: 0x48
	public readonly List ItemResourceUsageEffects; //Field offset: 0x50
	public float GlobalSkillExperienceMultiplier; //Field offset: 0x58
	private readonly float[] _traderBuyPriceMultipliers; //Field offset: 0x60
	private readonly float[] _traderSellPriceMultipliers; //Field offset: 0x68
	private readonly float[] _traderRepairPriceMultipliers; //Field offset: 0x70
	private readonly float[] _traderInsurancePriceMultipliers; //Field offset: 0x78
	private readonly float[] _traderTreatmentPriceMultipliers; //Field offset: 0x80

	public PerkRuntimeState(int skillCount, int traderTypesCount) { }

	public void AddActiveEffect(ISeasonalPerkEffect effect) { }

	public void ApplyTraderPriceMultiplier(ETraderType traderType, EPerkTradeAction tradeAction, float multiplier) { }

	public BoolPerkRuntimeValue GetBoolValue(EPerkRuntimeStatId valueId) { }

	public NumericPerkRuntimeValue GetNumericValue(EPerkRuntimeStatId valueId) { }

	public float GetSkillExperienceMultiplier(ESkillId skillId) { }

	public int GetSkillMaxLevel(ESkillId skillId, int fallbackLevel) { }

	public float GetTraderPriceMultiplier(ETraderType traderType, EPerkTradeAction tradeAction) { }

	private float[] GetTraderPriceMultipliers(EPerkTradeAction tradeAction) { }

	public void Reset() { }

	private static void ResetTraderMultipliers(float[] multipliers) { }

	public bool TryGetTraderType(MongoID traderId, out ETraderType traderType) { }

}

