namespace Audio.SpatialSystem;

[Extension]
public static class AudioFilterRequestBandExtensions
{

	[Extension]
	public static bool HasBand(ERequestBand bands, ERequestBand band) { }

	[Extension]
	public static bool HasHighPass(ERequestBand bands) { }

	[Extension]
	public static bool HasHighPass(FilterBandRequest request) { }

	[Extension]
	public static bool HasLowPass(ERequestBand bands) { }

	[Extension]
	public static bool HasLowPass(FilterBandRequest request) { }

}

