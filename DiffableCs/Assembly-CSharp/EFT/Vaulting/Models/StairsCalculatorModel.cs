namespace EFT.Vaulting.Models;

public class StairsCalculatorModel : IStairsCalculator
{
	private readonly Transform _gridRoot; //Field offset: 0x10
	private float _stepping; //Field offset: 0x18
	private float _averageTan; //Field offset: 0x1C
	private float _startZ; //Field offset: 0x20

	public StairsCalculatorModel(Transform gridRoot) { }

	public override bool IsStairsCondition() { }

}

