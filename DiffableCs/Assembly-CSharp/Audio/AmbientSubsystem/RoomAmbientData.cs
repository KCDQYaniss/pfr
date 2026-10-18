namespace Audio.AmbientSubsystem;

public class RoomAmbientData
{
	[Header("Room Tone Settings")]
	public float FadeInSeconds; //Field offset: 0x10
	public float FadeOutSeconds; //Field offset: 0x14
	[Range(0, 1)]
	public float RoomToneVolume; //Field offset: 0x18
	public AudioClip RoomTone; //Field offset: 0x20
	[Header("Room Outdoor Settings")]
	[Range(0, 1)]
	public float OutdoorAmbientVolume; //Field offset: 0x28
	[Range(20, 22000)]
	public float OutdoorAmbientLowpassFreq; //Field offset: 0x2C
	[Header("Precipitation Settings")]
	public SeasonClipsContentPreset SeasonSoundPreset; //Field offset: 0x30
	public bool UseVolumeRange; //Field offset: 0x38
	[Range(0, 1)]
	public float PrecipitationVolume; //Field offset: 0x3C
	[Tooltip("From Floor To Ceiling (RANGE 0-1)")]
	public Vector2 PrecipitationVolumeRange; //Field offset: 0x40
	[Header("Reverb Settings")]
	[ReverbPreset]
	public string ReverbPreset; //Field offset: 0x48
	[Range(0, 1)]
	public float ReverbSendVolume; //Field offset: 0x50

	public int RoomToneClipHash
	{
		 get { } //Length: 251
	}

	public RoomAmbientData() { }

	public int get_RoomToneClipHash() { }

	public int GetPrecipitationClip(ESeasonStatus season, ERainIntensity rainIntensity, out AudioClip clip) { }

}

