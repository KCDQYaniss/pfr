namespace Audio.Vehicles;

public interface IVehicleSoundContext
{

	public void SetBaseVolume(float volume) { }

	public void SetMaxSpeed(float speed) { }

	public void SetPriority(int priority) { }

	public void SetSpatialBlend(float spatialBlend) { }

	public void UpdateSpeed(float speed, float dt) { }

}

