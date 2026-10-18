namespace EFT.InventoryLogic;

public class HeadphonesTemplate : EquipmentTemplate
{
	public float RolloffMultiplier; //Field offset: 0x178
	public float GunsCompressorSendLevel; //Field offset: 0x17C
	public float ClientPlayerCompressorSendLevel; //Field offset: 0x180
	public float ObservedPlayerCompressorSendLevel; //Field offset: 0x184
	public float NpcCompressorSendLevel; //Field offset: 0x188
	public float EnvTechnicalCompressorSendLevel; //Field offset: 0x18C
	public float EnvNatureCompressorSendLevel; //Field offset: 0x190
	public float EnvCommonCompressorSendLevel; //Field offset: 0x194
	public float AmbientCompressorSendLevel; //Field offset: 0x198
	public float EffectsReturnsCompressorSendLevel; //Field offset: 0x19C
	public float HeadphonesMixerVolume; //Field offset: 0x1A0
	public float AmbientVolume; //Field offset: 0x1A4
	public float PrecipitationVolume; //Field offset: 0x1A8
	public float DryVolume; //Field offset: 0x1AC
	public float EffectsReturnsGroupVolume; //Field offset: 0x1B0
	public float Distortion; //Field offset: 0x1B4
	public float CompressorThreshold; //Field offset: 0x1B8
	public float CompressorAttack; //Field offset: 0x1BC
	public float CompressorRelease; //Field offset: 0x1C0
	public float CompressorGain; //Field offset: 0x1C4
	public float GunsCompressorThreshold; //Field offset: 0x1C8
	public float GunsCompressorAttack; //Field offset: 0x1CC
	public float GunsCompressorRelease; //Field offset: 0x1D0
	public float GunsCompressorGain; //Field offset: 0x1D4
	public int HighpassFreq; //Field offset: 0x1D8
	public float HighpassResonance; //Field offset: 0x1DC
	public int LowpassFreq; //Field offset: 0x1E0
	public float EQBand1Frequency; //Field offset: 0x1E4
	public float EQBand1Gain; //Field offset: 0x1E8
	public float EQBand1Q; //Field offset: 0x1EC
	public float EQBand2Frequency; //Field offset: 0x1F0
	public float EQBand2Gain; //Field offset: 0x1F4
	public float EQBand2Q; //Field offset: 0x1F8
	public float EQBand3Frequency; //Field offset: 0x1FC
	public float EQBand3Gain; //Field offset: 0x200
	public float EQBand3Q; //Field offset: 0x204

	public HeadphonesTemplate() { }

	public EQBand GetEQBand1() { }

	public EQBand GetEQBand2() { }

	public EQBand GetEQBand3() { }

}

