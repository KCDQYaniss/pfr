namespace EFT.NextObservedPlayer;

public class ObservedRangeFinder : IObservedUsableItem
{
	private OpticSight _opticSight; //Field offset: 0x10
	private TacticalRangeFinderController _rangeFinderController; //Field offset: 0x18
	private bool _isAiming; //Field offset: 0x20

	public OpticSight OpticSight
	{
		 get { } //Length: 5
	}

	public ObservedRangeFinder() { }

	private void ApplyAimingState(bool firstPersonPointOfView) { }

	public override void Disable() { }

	public OpticSight get_OpticSight() { }

	public override void Initialize(GameObject gameObject) { }

	public void SetAiming(bool isAiming, bool firstPersonPointOfView) { }

	public override void UpdateData(ObservedUsableItemUpdatedData observedUsableItemUpdatedData) { }

	public void UpdateForSpectating(bool isAiming, bool firstPersonPointOfView) { }

}

