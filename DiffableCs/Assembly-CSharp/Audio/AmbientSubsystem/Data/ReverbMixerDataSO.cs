namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/ReverbMixerDataSO", fileName = "ReverbMixerData")]
public class ReverbMixerDataSO : ScriptableObject, IEnvironmentMixerParamsHandler
{
	public MixerEnvironmentParameter reverbVolume; //Field offset: 0x18
	public MixerEnvironmentParameter reverbDryLevel; //Field offset: 0x20
	public MixerEnvironmentParameter mix; //Field offset: 0x28
	public MixerEnvironmentParameter reverbDelay; //Field offset: 0x30
	public MixerEnvironmentParameter reflectDelay; //Field offset: 0x38
	public MixerEnvironmentParameter reflectMix; //Field offset: 0x40
	public MixerEnvironmentParameter roomSize; //Field offset: 0x48
	public MixerEnvironmentParameter decayTime; //Field offset: 0x50
	public MixerEnvironmentParameter decayHFRatio; //Field offset: 0x58
	public MixerEnvironmentParameter roomLowFrequencyGain; //Field offset: 0x60
	public MixerEnvironmentParameter lowFrequencyReference; //Field offset: 0x68
	public MixerEnvironmentParameter roomHighFrequencyGain; //Field offset: 0x70
	public MixerEnvironmentParameter highFrequencyReference; //Field offset: 0x78

	public ReverbMixerDataSO() { }

	public override void Apply(AudioMixer mixer, EAudioRoomTypeMask roomType) { }

	private void ApplyInternal(MixerEnvironmentParameter parameter, AudioMixer mixer, EAudioRoomTypeMask roomType) { }

}

