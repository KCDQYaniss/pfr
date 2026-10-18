namespace Audio.SpatialSystem;

public struct FilterBandRequest
{
	public ERequestBand bands; //Field offset: 0x0
	public float lowPassFreq; //Field offset: 0x4
	public float lowPassQ; //Field offset: 0x8
	public float highPassFreq; //Field offset: 0xC
	public float highPassQ; //Field offset: 0x10
	public ERequestSource source; //Field offset: 0x14

}

