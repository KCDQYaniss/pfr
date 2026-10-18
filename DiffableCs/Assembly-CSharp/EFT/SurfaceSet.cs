namespace EFT;

[Obfuscation(Exclude = True)]
public class SurfaceSet
{
	public ESurfaceSound Surface; //Field offset: 0x10
	public SoundBank RunSoundBank; //Field offset: 0x18
	public SoundBank SprintSoundBank; //Field offset: 0x20
	public SoundBank StopSoundBank; //Field offset: 0x28
	public SoundBank LandingSoundBank; //Field offset: 0x30
	public SoundBank TurnSoundBank; //Field offset: 0x38
	public SoundBank DuckSoundBank; //Field offset: 0x40
	public SoundBank ProneSoundBank; //Field offset: 0x48
	public SoundBank ProneDropSoundBank; //Field offset: 0x50
	public SoundBank JumpSoundBank; //Field offset: 0x58
	[Header("Vaulting Sounds")]
	[Space]
	public VaultingSoundSet VaultSoundSet; //Field offset: 0x60
	public VaultingSoundSet SprintVaultSoundSet; //Field offset: 0x68
	public VaultingSoundSet ClimbSoundSet; //Field offset: 0x70

	public bool IsFull
	{
		 get { } //Length: 1454
	}

	public SurfaceSet() { }

	public bool get_IsFull() { }

	public bool TryGetVaultingSoundSet(EVaultingSoundType soundType, out VaultingSoundSet vaultingSet) { }

}

