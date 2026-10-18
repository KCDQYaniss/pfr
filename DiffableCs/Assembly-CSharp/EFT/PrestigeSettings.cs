namespace EFT;

public sealed class PrestigeSettings
{
	public readonly IReadOnlyList Templates; //Field offset: 0x10

	[JsonConstructor]
	public PrestigeSettings(List templates) { }

}

