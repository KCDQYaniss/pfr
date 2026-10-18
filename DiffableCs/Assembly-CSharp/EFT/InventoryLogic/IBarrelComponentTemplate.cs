namespace EFT.InventoryLogic;

public interface IBarrelComponentTemplate
{

	public float CenterOfImpact
	{
		 get { } //Length: 0
	}

	public float DeviationCurve
	{
		 get { } //Length: 0
	}

	public float DeviationMax
	{
		 get { } //Length: 0
	}

	public float ShotgunDispersion
	{
		 get { } //Length: 0
	}

	public float get_CenterOfImpact() { }

	public float get_DeviationCurve() { }

	public float get_DeviationMax() { }

	public float get_ShotgunDispersion() { }

}

