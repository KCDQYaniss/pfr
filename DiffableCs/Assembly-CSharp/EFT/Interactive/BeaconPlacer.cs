namespace EFT.Interactive;

public class BeaconPlacer : MonoBehaviour
{
	private const float CallDelay = 0.2; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Available>k__BackingField; //Field offset: 0x20
	private BoxCollider _collider; //Field offset: 0x28
	private DateTime _lastUpdate; //Field offset: 0x30
	private readonly List _placeItemTriggers; //Field offset: 0x38

	public private bool Available
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private BoxCollider Collider
	{
		private get { } //Length: 335
	}

	public BeaconPlacer() { }

	private void CalculatePlaceItemTrigger() { }

	[CompilerGenerated]
	public bool get_Available() { }

	private BoxCollider get_Collider() { }

	[CompilerGenerated]
	private void set_Available(bool value) { }

	private void Update() { }

}

