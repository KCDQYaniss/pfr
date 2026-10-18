namespace Audio.SpatialSystem.SpatialAudioCalculator.Data;

public struct TransmissionPathResult
{
	public float RemainingEnergy; //Field offset: 0x0
	public float TotalThickness; //Field offset: 0x4
	public bool PathPotentiallyValid; //Field offset: 0x8

	public static TransmissionPathResult ClearPath
	{
		 get { } //Length: 23
	}

	public static TransmissionPathResult NoPath
	{
		 get { } //Length: 19
	}

	public static TransmissionPathResult get_ClearPath() { }

	public static TransmissionPathResult get_NoPath() { }

}

