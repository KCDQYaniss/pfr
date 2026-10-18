namespace UnityEngine;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour
{
	internal enum ReflectionProbeEvent
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action reflectionProbeChanged; //Field offset: 0x0
	private static Dictionary registeredDefaultReflectionSetActions; //Field offset: 0x8
	private static List registeredDefaultReflectionTextureActions; //Field offset: 0x10

	public Color backgroundColor
	{
		 set { } //Length: 93
	}

	public ReflectionProbeClearFlags clearFlags
	{
		 set { } //Length: 91
	}

	public int cullingMask
	{
		 set { } //Length: 91
	}

	[NativeName("IntensityMultiplier")]
	public float intensity
	{
		 set { } //Length: 94
	}

	public ReflectionProbeMode mode
	{
		 set { } //Length: 91
	}

	public ReflectionProbeRefreshMode refreshMode
	{
		 set { } //Length: 91
	}

	[NativeName("BoxSize")]
	public Vector3 size
	{
		 set { } //Length: 93
	}

	public ReflectionProbeTimeSlicingMode timeSlicingMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	private static ReflectionProbe() { }

	[RequiredByNativeCode]
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	public bool IsFinishedRendering(int renderId) { }

	public int RenderProbe(RenderTexture targetTexture) { }

	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	public void set_cullingMask(int value) { }

	public void set_intensity(float value) { }

	public void set_mode(ReflectionProbeMode value) { }

	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	public void set_size(Vector3 value) { }

	private void set_size_Injected(ref Vector3 value) { }

	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

}

