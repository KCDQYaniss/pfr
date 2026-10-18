namespace Audio.SpatialSystem.SpatialAudioCalculator;

public enum EPathEndStatus
{
	InProgress = 0,
	ReachedListenerClear = 1,
	ReachedListenerBlocked = 2,
	HitObstacle = 3,
	MaxReflectionsOrDistance = 4,
}

