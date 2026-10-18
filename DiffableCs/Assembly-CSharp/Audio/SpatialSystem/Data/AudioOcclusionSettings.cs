namespace Audio.SpatialSystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/OcclusionSettings/AudioOcclusionSettings", fileName = "AudioOcclusionSettings")]
public sealed class AudioOcclusionSettings : ScriptableObject
{
	[Tooltip("Settings for all system components")]
	public CommonOcclusionSettings commonSettings; //Field offset: 0x18
	[Tooltip("Settings for propagation-based occlusion calculation")]
	public PropagationSettings propagationSettings; //Field offset: 0x20
	[Tooltip("Settings for reflection-based occlusion sampling")]
	public ReflectionSettings reflectionSettings; //Field offset: 0x28
	[Tooltip("Settings for diffraction-based occlusion sampling")]
	public DiffractionSettings diffractionSettings; //Field offset: 0x30
	[Tooltip("Settings for transmission-based occlusion sampling")]
	public TransmissionSettings transmissionSettings; //Field offset: 0x38

	public AudioOcclusionSettings() { }

	public void Apply(LocationOcclusionBackendSettings backendSettings) { }

}

