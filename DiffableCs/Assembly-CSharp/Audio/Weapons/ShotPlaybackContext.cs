namespace Audio.Weapons;

[IsReadOnly]
public struct ShotPlaybackContext
{
	public readonly SoundBank bank; //Field offset: 0x0
	public readonly float distanceToListener; //Field offset: 0x8
	public readonly float maxDistance; //Field offset: 0xC
	public readonly float baseVolume; //Field offset: 0x10
	public readonly EnvironmentType environment; //Field offset: 0x14
	public readonly bool isFirstPerson; //Field offset: 0x18
	public readonly float delay; //Field offset: 0x1C
	public readonly float pitchA; //Field offset: 0x20
	public readonly float pitchB; //Field offset: 0x24
	public readonly float beatDuration; //Field offset: 0x28
	public readonly bool isSilenced; //Field offset: 0x2C

	public ShotPlaybackContext(SoundBank bank, float distanceToListener, float maxDistance, float baseVolume, EnvironmentType environment, bool isFirstPerson, float delay, float beatDuration, float pitchA, float pitchB, bool isSilenced) { }

}

