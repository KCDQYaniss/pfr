namespace Audio.Vehicles;

internal abstract class VehicleSoundAbstractState
{
	protected readonly VehicleMovementSoundContext Context; //Field offset: 0x10

	public bool IsCurrent
	{
		 get { } //Length: 57
	}

	public abstract EVehicleMovementStatus Status
	{
		 get { } //Length: 0
	}

	protected VehicleSoundAbstractState(VehicleMovementSoundContext context) { }

	public override void Exit() { }

	public bool get_IsCurrent() { }

	public abstract EVehicleMovementStatus get_Status() { }

	public override EVehicleMovementStatus Run() { }

	public override void Update() { }

}

