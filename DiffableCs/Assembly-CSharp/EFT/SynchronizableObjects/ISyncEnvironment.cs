namespace EFT.SynchronizableObjects;

public interface ISyncEnvironment
{

	public void DeActivateTripwire(TripwireSynchronizableObject tripwire) { }

	public void TriggerTripwire(TripwireSynchronizableObject tripwire) { }

}

