namespace EFT;

public sealed class HideoutCounters
{
	[JsonProperty("fuelCounter")]
	public float FuelCounter; //Field offset: 0x10
	[JsonProperty("airFilterCounter")]
	public float AirFilterCounter; //Field offset: 0x14
	[JsonProperty("waterFilterCounter")]
	public float WaterFilterCounter; //Field offset: 0x18
	[JsonProperty("craftingTimeCounter")]
	public float CraftingTimeCounter; //Field offset: 0x1C

	public HideoutCounters() { }

	public float GetCounter(EAreaType areaType) { }

}

