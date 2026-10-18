namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/DelayMixerDataSO", fileName = "DelayMixerData")]
public class DelayMixerDataSO : ScriptableObject, IEnvironmentMixerParamsHandler
{
	public MixerEnvironmentParameter delayVolume; //Field offset: 0x18
	public MixerEnvironmentParameter delay; //Field offset: 0x20
	public MixerEnvironmentParameter decayTime; //Field offset: 0x28
	public MixerEnvironmentParameter wetMix; //Field offset: 0x30
	public MixerEnvironmentParameter lowpassFilterFreq; //Field offset: 0x38

	public DelayMixerDataSO() { }

	public override void Apply(AudioMixer mixer, EAudioRoomTypeMask roomType) { }

	private void ApplyInternal(MixerEnvironmentParameter parameter, AudioMixer mixer, EAudioRoomTypeMask roomType) { }

}

