namespace Audio.Data;

public class AudioMixerDataContainer : IDataContainer
{
	public readonly string GunsMixerVolume; //Field offset: 0x10
	public readonly string MainMixerVolume; //Field offset: 0x18
	public readonly string InGameVolumeMixer; //Field offset: 0x20
	public readonly string MusicVolumeMixer; //Field offset: 0x28
	public readonly string ReverbMixerVolume; //Field offset: 0x30
	public readonly string AmbientOutDayMixerVolume; //Field offset: 0x38
	public readonly string AmbientOutNightMixerVolume; //Field offset: 0x40
	public readonly string AmbientOutMixerVolume; //Field offset: 0x48
	public readonly string AmbientOutDayEffectsVolume; //Field offset: 0x50
	public readonly string AmbientOutNightEffectsVolume; //Field offset: 0x58
	public readonly string AmbientInMixerVolume; //Field offset: 0x60
	public readonly string AmbientInDayMixerVolume; //Field offset: 0x68
	public readonly string AmbientInNightMixerVolume; //Field offset: 0x70
	public readonly string WorldMixerVolume; //Field offset: 0x78
	public readonly string WorldMixerLowpassFreq; //Field offset: 0x80
	public readonly string WorldMixerReverbLevel; //Field offset: 0x88
	public readonly string HideoutMixerVolume; //Field offset: 0x90
	public readonly string RoomToneMixerVolume; //Field offset: 0x98
	public readonly string SFXBypassMixerVolume; //Field offset: 0xA0
	public readonly string GunsMixerTinnitusSendLevel; //Field offset: 0xA8
	public readonly string MainMixerTinnitusSendLevel; //Field offset: 0xB0
	public readonly string GunsReverbSendLevel; //Field offset: 0xB8
	public readonly string EnvironmentReverbSendLevel; //Field offset: 0xC0
	public readonly string OutEnvironmentVolume; //Field offset: 0xC8
	public readonly string OutEnvironmentLowpassFreq; //Field offset: 0xD0
	public readonly string AmbientOutLowpassFreq; //Field offset: 0xD8
	public readonly string AmbientEffectsHighpassFreq; //Field offset: 0xE0
	public readonly string AmbientEffectsLowpassFreq; //Field offset: 0xE8
	public readonly string HideoutMixerLowpass; //Field offset: 0xF0
	public readonly string AcousticReflectionLowpass; //Field offset: 0xF8
	public readonly string AcousticReflectionHighpass; //Field offset: 0x100

	public AudioMixerDataContainer() { }

}

