namespace EFT.Vaulting.Models;

public interface IObstacleCalculatorModelDebug : IObstacleCalculatorModel
{

	public float MaxHeightOffset
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float RectangleAreaThreshold
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float SlopedAreaThreshold
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float get_MaxHeightOffset() { }

	public float get_RectangleAreaThreshold() { }

	public float get_SlopedAreaThreshold() { }

	public void set_MaxHeightOffset(float value) { }

	public void set_RectangleAreaThreshold(float value) { }

	public void set_SlopedAreaThreshold(float value) { }

}

