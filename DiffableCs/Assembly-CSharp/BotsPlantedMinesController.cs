//Type is in global namespace

public class BotsPlantedMinesController
{
	private AICoversData _data; //Field offset: 0x10
	private Dictionary _planted; //Field offset: 0x18
	[CompilerGenerated]
	private PlantedAIMineDelegate OnAdd; //Field offset: 0x20
	[CompilerGenerated]
	private PlantedAIMineDelegate OnRemove; //Field offset: 0x28

	public event PlantedAIMineDelegate OnAdd
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event PlantedAIMineDelegate OnRemove
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public BotsPlantedMinesController(AICoversData data) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnAdd(PlantedAIMineDelegate value) { }

	[CompilerGenerated]
	public void add_OnRemove(PlantedAIMineDelegate value) { }

	public void Dispose() { }

	private void OnDeactivateTripwire(TripwireSynchronizableObject tripwire) { }

	private void OnPlantTripwire(TripwireSynchronizableObject tripwire, Vector3 position) { }

	private void OnPlantTripwireDestroyed(TripwireSynchronizableObject tripwire) { }

	[CompilerGenerated]
	public void remove_OnAdd(PlantedAIMineDelegate value) { }

	[CompilerGenerated]
	public void remove_OnRemove(PlantedAIMineDelegate value) { }

}

