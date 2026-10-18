namespace Audio.SpatialSystem.SpatialAudioCalculator;

public struct BatchProcessingOutput
{
	public bool foundDirectPathClearThisBatch; //Field offset: 0x0
	public ShortestPathResultData bestOverallDataSoFar; //Field offset: 0x8
	public ShortestPathResultData bestReflectedDataSoFar; //Field offset: 0x98

}

