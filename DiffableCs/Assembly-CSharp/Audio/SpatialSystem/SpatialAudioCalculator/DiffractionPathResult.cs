namespace Audio.SpatialSystem.SpatialAudioCalculator;

public struct DiffractionPathResult
{
	public float pathLength; //Field offset: 0x0
	public Vector3 diffractionPoint; //Field offset: 0x4
	public float energyFactor; //Field offset: 0x10
	public bool isDirectPath; //Field offset: 0x14

	public bool FoundPath
	{
		 get { } //Length: 15
	}

	public static DiffractionPathResult NoPath
	{
		 get { } //Length: 108
	}

	public static DiffractionPathResult DirectPath(float directDistance, float3 endPoint) { }

	public bool get_FoundPath() { }

	public static DiffractionPathResult get_NoPath() { }

}

