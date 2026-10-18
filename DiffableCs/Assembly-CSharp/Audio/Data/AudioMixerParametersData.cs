namespace Audio.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/AudioMixerParametersData", fileName = "AudioMixerParametersData")]
public class AudioMixerParametersData : ScriptableObject
{
	[SerializeField]
	private AudioMixerParametersByType MixerParametersByType; //Field offset: 0x18

	public AudioMixerParametersData() { }

	public bool TryGetParameters(EMixerParameterType parameterType, out AudioMixerParamsContainer mixerParams) { }

}

