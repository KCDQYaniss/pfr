namespace EFT.Vaulting.Models;

public interface IWeightCalculatorModel
{

	public VaultingPoint MaxWeightPoint
	{
		 get { } //Length: 0
	}

	public void CalculateWeights(List hits) { }

	public VaultingPoint get_MaxWeightPoint() { }

}

