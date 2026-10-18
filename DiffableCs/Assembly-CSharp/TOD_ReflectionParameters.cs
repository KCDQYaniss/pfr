//Type is in global namespace

public class TOD_ReflectionParameters
{
	[Tooltip("Reflection probe mode.")]
	public TOD_ReflectionType Mode; //Field offset: 0x10
	[Tooltip("Clear flags to use for the reflection.")]
	public ReflectionProbeClearFlags ClearFlags; //Field offset: 0x14
	[Tooltip("Layers to include in the reflection.")]
	public LayerMask CullingMask; //Field offset: 0x18
	[Tooltip("Time slicing behaviour to spread out rendering cost over multiple frames.")]
	public ReflectionProbeTimeSlicingMode TimeSlicing; //Field offset: 0x1C
	[TOD_Min(0)]
	[Tooltip("Refresh interval of the reflection cubemap in seconds.")]
	public float UpdateInterval; //Field offset: 0x20

	public TOD_ReflectionParameters() { }

}

