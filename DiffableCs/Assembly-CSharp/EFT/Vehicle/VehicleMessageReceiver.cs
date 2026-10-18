namespace EFT.Vehicle;

public class VehicleMessageReceiver : IDisposable
{

	public VehicleMessageReceiver() { }

	public override void Dispose() { }

	public void OnDespawnBTRVehicle(NetworkMessage networkMessage) { }

	public void OnSnapshotBTRVehicles(NetworkMessage networkMessage) { }

}

