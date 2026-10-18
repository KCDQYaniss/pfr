namespace Audio.SpatialSystem.SpatialAudioCalculator.CombinedOcclusionCalculator;

public struct AggregateOcclusionResult
{
	public float reflectionScore; //Field offset: 0x0
	public float diffractionScore; //Field offset: 0x4
	public float transmissionScore; //Field offset: 0x8

	public static AggregateOcclusionResult Clear
	{
		 get { } //Length: 12
	}

	public static AggregateOcclusionResult Obstructed
	{
		 get { } //Length: 24
	}

	public static AggregateOcclusionResult get_Clear() { }

	public static AggregateOcclusionResult get_Obstructed() { }

}

