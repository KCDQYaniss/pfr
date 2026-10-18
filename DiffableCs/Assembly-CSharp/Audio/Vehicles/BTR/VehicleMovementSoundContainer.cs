namespace Audio.Vehicles.BTR;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/VehicleMovementSoundContainer", fileName = "VehicleMovementSoundContainer")]
public class VehicleMovementSoundContainer : ScriptableObject
{
	public AudioClip EngineStartClip; //Field offset: 0x18
	public AudioClip EngineIdleAccelClip; //Field offset: 0x20
	public AudioClip EngineLowAccelClip; //Field offset: 0x28
	public AudioClip EngineHighAccelClip; //Field offset: 0x30
	public AudioClip LowRpmLoopClip; //Field offset: 0x38
	public AudioClip HighRpmLoopClip; //Field offset: 0x40
	public AudioClip LowSpeedMovementLoopClip; //Field offset: 0x48
	public AudioClip HighSpeedMovementLoopClip; //Field offset: 0x50
	public AudioClip MovementStopBreakClip; //Field offset: 0x58
	public AudioClip[] SkidClips; //Field offset: 0x60
	public AudioClip[] SuspensionImpactClips; //Field offset: 0x68

	public VehicleMovementSoundContainer() { }

}

