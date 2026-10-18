namespace EFT.Vaulting.Models;

public class GridPointsModel : IGridPointsModel, IGridPointsModelDebug
{
	private readonly Transform _gridRoot; //Field offset: 0x10
	private readonly int _layersToIgonre; //Field offset: 0x18
	private List _frontFromLocalPositions; //Field offset: 0x20
	private List _frontToLocalPositions; //Field offset: 0x28
	private List _topFromLocalPositions; //Field offset: 0x30
	private List _frontFromWorldPositions; //Field offset: 0x38
	private List _frontToWorldPositions; //Field offset: 0x40
	private List _topFromWorldPositions; //Field offset: 0x48
	private List _forwardLocalHitPoints; //Field offset: 0x50
	private List _verticalLocalHitPoints; //Field offset: 0x58
	private List _allLocalHitPoints; //Field offset: 0x60
	private List _forwardWorldHitPoints; //Field offset: 0x68
	private List _verticalWorldHitPoints; //Field offset: 0x70
	private List _allWorldHitPoints; //Field offset: 0x78

	public override List AllWorldHitPoints
	{
		 get { } //Length: 5
	}

	public override List ForwardWorldHitPoints
	{
		 get { } //Length: 5
	}

	public override List FrontFromPositions
	{
		 get { } //Length: 5
	}

	public override Vector3 GridRootPosition
	{
		 get { } //Length: 138
	}

	public override List TopFromPositions
	{
		 get { } //Length: 76
	}

	public override List VerticalWorldHitPoints
	{
		 get { } //Length: 5
	}

	public GridPointsModel(Transform gridRoot) { }

	private void CalculateForwardHitPoints() { }

	private void CalculateFrontGridPoints(ref IGridSettingsDataTransferModel data) { }

	public override void CalculateHitPoints() { }

	private void CalculateTopGridPoints(ref IGridSettingsDataTransferModel data) { }

	private void CalculateVerticalHitPoints() { }

	private void ClearAll() { }

	private void ClearHitPoints() { }

	private void ClearPositions() { }

	public override List get_AllWorldHitPoints() { }

	public override List get_ForwardWorldHitPoints() { }

	public override List get_FrontFromPositions() { }

	public override Vector3 get_GridRootPosition() { }

	public override List get_TopFromPositions() { }

	public override List get_VerticalWorldHitPoints() { }

	private bool HasForwardPoints() { }

	private bool HasTopPoints() { }

	private void Initialize() { }

	public override void RecalculateGrid(IGridSettingsDataTransferModel data) { }

}

