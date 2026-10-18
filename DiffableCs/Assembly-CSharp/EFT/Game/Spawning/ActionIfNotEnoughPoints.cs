namespace EFT.Game.Spawning;

public enum ActionIfNotEnoughPoints
{
	ReturnFoundPoints = 0,
	ReturnNothing = 1,
	DuplicateIfAtLeastOne = 2,
	FillWithDiscardedPointsAndDuplicates = 3,
}

