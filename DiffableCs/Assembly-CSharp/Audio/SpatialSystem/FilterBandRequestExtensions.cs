namespace Audio.SpatialSystem;

public static class FilterBandRequestExtensions
{

	public static FilterBandRequest CreateBoth(float lpFreq, float hpFreq, float lpQ, float hpQ, ERequestSource source = 0) { }

	public static FilterBandRequest CreateHighPass(float freq, float q, ERequestSource source = 1) { }

	public static FilterBandRequest CreateLowPass(float freq, float q, ERequestSource source = 1) { }

}

