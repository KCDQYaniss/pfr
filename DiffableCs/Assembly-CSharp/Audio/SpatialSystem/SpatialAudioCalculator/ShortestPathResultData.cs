namespace Audio.SpatialSystem.SpatialAudioCalculator;

public struct ShortestPathResultData
{
	public float pathLength; //Field offset: 0x0
	public float energy; //Field offset: 0x4
	public int rayIndex; //Field offset: 0x8
	public bool found; //Field offset: 0xC
	public FixedList128Bytes pathPoints; //Field offset: 0x10

}

