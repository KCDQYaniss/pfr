namespace Audio.Vehicles;

internal class VehicleSoundStopState : VehicleSoundAbstractState
{

	public virtual EVehicleMovementStatus Status
	{
		 get { } //Length: 3
	}

	public VehicleSoundStopState(VehicleMovementSoundContext context) { }

	public virtual EVehicleMovementStatus get_Status() { }

	public virtual EVehicleMovementStatus Run() { }

}

