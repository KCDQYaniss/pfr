namespace UnityEngine.Profiling;

[UsedByNativeCode]
public sealed class Recorder
{
	internal static Recorder s_InvalidRecorder; //Field offset: 0x0
	private ProfilerRecorder m_RecorderCPU; //Field offset: 0x10
	private ProfilerRecorder m_RecorderGPU; //Field offset: 0x18

	public long elapsedNanoseconds
	{
		 get { } //Length: 48
	}

	public int sampleBlockCount
	{
		 get { } //Length: 86
	}

	private static Recorder() { }

	internal Recorder() { }

	internal Recorder(ProfilerRecorderHandle handle) { }

	protected virtual void Finalize() { }

	public static Recorder Get(string samplerName) { }

	public long get_elapsedNanoseconds() { }

	public int get_sampleBlockCount() { }

}

