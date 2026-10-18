namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/MixerEffectsDataSO", fileName = "MixerEffectsData")]
public class MixerEffectsDataSO : ScriptableObject
{
	public ReverbMixerDataSO reverbMixerData; //Field offset: 0x18
	public DelayMixerDataSO delayMixerData; //Field offset: 0x20
	public GenericVolumeParamsMixerDataSO effectsSendsMixerData; //Field offset: 0x28
	public GenericVolumeParamsMixerDataSO effectsVolumesMixerData; //Field offset: 0x30

	public MixerEffectsDataSO() { }

}

