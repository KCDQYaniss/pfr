//Type is in global namespace

public struct ShooterPlaybackContext
{
	public Vector3 position; //Field offset: 0x0
	public WeaponProfile profile; //Field offset: 0x10
	public ISequenceEndSync sequenceEndSync; //Field offset: 0x18
	public float distanceToListener; //Field offset: 0x20
	public double startOffsetSec; //Field offset: 0x28
	public AudioSourcePriorityCalculator priorityCalculator; //Field offset: 0x30
	public MonoBehaviour runner; //Field offset: 0x38

	public FirearmAudioPreset AudioPreset
	{
		 get { } //Length: 15
	}

	public FirearmAudioPreset get_AudioPreset() { }

}

