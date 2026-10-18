namespace Audio.Vehicles;

internal class VehicleSoundStartState : VehicleSoundAbstractState
{

	public virtual EVehicleMovementStatus Status
	{
		 get { } //Length: 6
	}

	public VehicleSoundStartState(VehicleMovementSoundContext context) { }

	public virtual EVehicleMovementStatus get_Status() { }

	public virtual EVehicleMovementStatus Run() { }

}

