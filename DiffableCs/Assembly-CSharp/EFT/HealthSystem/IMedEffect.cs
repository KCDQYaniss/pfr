namespace EFT.HealthSystem;

public interface IMedEffect : IHealthEffect, IInitializable, IStackable, IDesirable
{

	public float Amount
	{
		 get { } //Length: 0
	}

	public Item MedItem
	{
		 get { } //Length: 0
	}

	public bool NoMove
	{
		 get { } //Length: 0
	}

	public float get_Amount() { }

	public Item get_MedItem() { }

	public bool get_NoMove() { }

}

