namespace Audio.Vehicles;

internal class VehicleSoundRunningState : VehicleSoundAbstractState
{

	public virtual EVehicleMovementStatus Status
	{
		 get { } //Length: 6
	}

	public VehicleSoundRunningState(VehicleMovementSoundContext context) { }

	public virtual void Exit() { }

	public virtual EVehicleMovementStatus get_Status() { }

	public virtual EVehicleMovementStatus Run() { }

	public virtual void Update() { }

}

