namespace Audio.AmbientSubsystem.Data;

public class MixerEnvironmentParameter : IEnvironmentMixerParamsHandler
{
	public string paramName; //Field offset: 0x10
	public MixerEnvironmentParametersByRoom parametersByRoom; //Field offset: 0x18

	public MixerEnvironmentParameter() { }

	public override void Apply(AudioMixer mixer, EAudioRoomTypeMask roomType) { }

}

