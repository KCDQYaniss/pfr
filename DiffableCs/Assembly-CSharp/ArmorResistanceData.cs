//Type is in global namespace

public struct ArmorResistanceData
{
	private const float MIN_CHANCE = 0; //Field offset: 0x0
	private const float MAX_CHANCE = 100; //Field offset: 0x0
	private const float MIN_DELTA_FOR_MIN_CHANCE = 15; //Field offset: 0x0
	private const float MAX_DELTA_FOR_MAX_CHANCE = -15; //Field offset: 0x0
	private const float CHANCE_COEFFICIENT_AT_POSITIVE_DELTA = 0.4; //Field offset: 0x0
	private const float RESISTANCE_COEFFICIENT_AT_NEGATIVE_DELTA = 0.9; //Field offset: 0x0
	public float RealResistance; //Field offset: 0x0
	public float ArmorClassResistance; //Field offset: 0x4
	public float CF; //Field offset: 0x8

	public float GetPenetrationChance(float penetrationPower) { }

}

