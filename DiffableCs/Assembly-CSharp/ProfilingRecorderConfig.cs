//Type is in global namespace

public struct ProfilingRecorderConfig
{
	public readonly string SamplerName; //Field offset: 0x0
	public readonly bool DivideBySamplesCount; //Field offset: 0x8

	public ProfilingRecorderConfig(string samplerName, bool divideBySamplesCount = false) { }

}

