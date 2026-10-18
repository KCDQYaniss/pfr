namespace EFT.Game.Spawning;

[Flags]
public enum ESpawnCategoryMask
{
	None = 0,
	Player = 1,
	Bot = 2,
	Boss = 4,
	Coop = 8,
	Group = 16,
	Opposite = 32,
	BotPmc = 64,
	Season01 = 128,
	All = 71,
}

