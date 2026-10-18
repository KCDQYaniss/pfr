namespace EFT;

public sealed class Sounds : ScriptableObject
{
	public SurfaceSet[] Sets; //Field offset: 0x18
	public SoundBank Gear; //Field offset: 0x20
	public SoundBank GearMedium; //Field offset: 0x28
	public SoundBank GearFast; //Field offset: 0x30
	public SoundBank GearVault; //Field offset: 0x38
	public SoundBank GearSprintVault; //Field offset: 0x40
	public SoundBank GearClimb; //Field offset: 0x48
	public SoundBank BackpackDrop; //Field offset: 0x50
	public AudioClip TinnitusSound; //Field offset: 0x58
	public AudioClip FractureSound; //Field offset: 0x60
	public AudioClip FaceShieldOn; //Field offset: 0x68
	public AudioClip FaceShieldOff; //Field offset: 0x70
	public AudioClip NightVisionOn; //Field offset: 0x78
	public AudioClip NightVisionOff; //Field offset: 0x80
	public AudioClip ThermalVisionOn; //Field offset: 0x88
	public AudioClip ThermalVisionOff; //Field offset: 0x90
	public AudioClip PropIn; //Field offset: 0x98
	public AudioClip PropOut; //Field offset: 0xA0
	public AudioClip SwitchHeadlights; //Field offset: 0xA8
	public AudioClip StopRecorder; //Field offset: 0xB0
	public SeasonSurfaceSetContainer SeasonSounds; //Field offset: 0xB8
	public TagBank FrostbiteEffects; //Field offset: 0xC0

	public Sounds() { }

	public SurfaceSet GetSurfaceSet(ESurfaceSound surfaceSound) { }

	public bool TryGetSeasonMovementSet(ESeasonStatus season, out SurfaceSet set) { }

}

