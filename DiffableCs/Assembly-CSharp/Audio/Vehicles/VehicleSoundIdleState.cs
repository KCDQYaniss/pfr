namespace Audio.Vehicles;

internal class VehicleSoundIdleState : VehicleSoundAbstractState
{

	public virtual EVehicleMovementStatus Status
	{
		 get { } //Length: 6
	}

	public VehicleSoundIdleState(VehicleMovementSoundContext context) { }

	public virtual EVehicleMovementStatus get_Status() { }

	public virtual void Update() { }

}

