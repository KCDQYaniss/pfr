namespace Meta.XR.Acoustics;

[Flags]
public enum AcousticMapFlags
{
	NONE = 0,
	STATIC_ONLY = 1,
	NO_FLOATING = 2,
	MAP_ONLY = 4,
	DIFFRACTION = 8,
}

