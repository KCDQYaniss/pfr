namespace Audio.SpatialSystem.Utils;

public class SpatialAudioPoolsConfig
{
	public int parallelPropagationCalculatorsPreCacheCount; //Field offset: 0x10
	public int combinedCalculatorsPreCacheCount; //Field offset: 0x14
	public int transmissionCalculatorsPoolCount; //Field offset: 0x18
	public int pendingCompleteCalculatorsCount; //Field offset: 0x1C

	public SpatialAudioPoolsConfig() { }

}

