namespace Audio.SpatialSystem.SpatialAudioCalculator;

public struct ReflectionPathResult
{
	public float pathLength; //Field offset: 0x0
	public EPathType pathType; //Field offset: 0x4

	public static ReflectionPathResult NoPath
	{
		 get { } //Length: 28
	}

	public static ReflectionPathResult get_NoPath() { }

}

