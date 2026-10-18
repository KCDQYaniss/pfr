namespace EFT.Vaulting.Models;

public interface IGridPointsModel
{

	public List AllWorldHitPoints
	{
		 get { } //Length: 0
	}

	public List ForwardWorldHitPoints
	{
		 get { } //Length: 0
	}

	public List VerticalWorldHitPoints
	{
		 get { } //Length: 0
	}

	public void CalculateHitPoints() { }

	public List get_AllWorldHitPoints() { }

	public List get_ForwardWorldHitPoints() { }

	public List get_VerticalWorldHitPoints() { }

	public void RecalculateGrid(IGridSettingsDataTransferModel data) { }

}

