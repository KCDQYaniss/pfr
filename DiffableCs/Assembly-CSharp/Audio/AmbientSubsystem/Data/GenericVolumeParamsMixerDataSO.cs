namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/GenericVolumeParamsMixerDataSO", fileName = "GenericVolumeParamsMixerData")]
public class GenericVolumeParamsMixerDataSO : ScriptableObject, IEnvironmentMixerParamsHandler
{
	public MixerEnvironmentParameter[] mixerEnvironmentParameters; //Field offset: 0x18

	public GenericVolumeParamsMixerDataSO() { }

	public override void Apply(AudioMixer mixer, EAudioRoomTypeMask roomType) { }

}

