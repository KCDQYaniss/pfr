namespace Audio.BackendSettings;

public class LocationOcclusionBackendSettings
{
	public CommonOcclusionSettings commonSettings; //Field offset: 0x10
	public PropagationSettings propagationSettings; //Field offset: 0x18
	public ReflectionSettings reflectionSettings; //Field offset: 0x20
	public DiffractionSettings diffractionSettings; //Field offset: 0x28
	public TransmissionSettings transmissionSettings; //Field offset: 0x30

	public LocationOcclusionBackendSettings() { }

}

