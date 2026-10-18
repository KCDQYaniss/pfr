namespace Meta.XR.Acoustics;

[Flags]
public enum EnableFlagInternal
{
	NONE = 0,
	SIMPLE_ROOM_MODELING = 2,
	LATE_REVERBERATION = 3,
	RANDOMIZE_REVERB = 4,
	PERFORMANCE_COUNTERS = 5,
	DIFFRACTION = 6,
}

