namespace Dissonance;

internal interface ILossEstimator
{

	public float PacketLoss
	{
		 get { } //Length: 0
	}

	public float get_PacketLoss() { }

}

