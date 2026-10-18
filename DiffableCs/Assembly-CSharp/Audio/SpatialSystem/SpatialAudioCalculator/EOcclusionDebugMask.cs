namespace Audio.SpatialSystem.SpatialAudioCalculator;

[Flags]
public enum EOcclusionDebugMask
{
	None = 0,
	Reflection = 2,
	Diffraction = 4,
	Transmission = 8,
	Propagation = 16,
	All = 30,
}

