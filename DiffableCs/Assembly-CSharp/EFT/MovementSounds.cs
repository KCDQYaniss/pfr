namespace EFT;

public sealed class MovementSounds : ScriptableObject
{
	public SoundBank RunSoundBank; //Field offset: 0x18
	public SoundBank SprintSoundBank; //Field offset: 0x20
	public SoundBank StopSoundBank; //Field offset: 0x28
	public SoundBank LandingSoundBank; //Field offset: 0x30
	public SoundBank TurnSoundBank; //Field offset: 0x38
	public SoundBank DuckSoundBank; //Field offset: 0x40
	public SoundBank ProneSoundBank; //Field offset: 0x48
	public SoundBank ProneDropSoundBank; //Field offset: 0x50
	public SoundBank GearSoundBank; //Field offset: 0x58
	public SoundBank JumpSoundBank; //Field offset: 0x60
	public SoundBank GearFastSoundBank; //Field offset: 0x68

	public MovementSounds() { }

}

