namespace EFT.SeasonalRewards;

[IsReadOnly]
public struct RewardLocation
{
	[JsonProperty("x")]
	public readonly int X; //Field offset: 0x0
	[JsonProperty("y")]
	public readonly int Y; //Field offset: 0x4
	[JsonProperty("w")]
	public readonly int Width; //Field offset: 0x8
	[JsonProperty("h")]
	public readonly int Height; //Field offset: 0xC

	[JsonConstructor]
	public RewardLocation(int x, int y, int width, int height) { }

}

