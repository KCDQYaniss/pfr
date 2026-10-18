namespace Dissonance.Datastructures;

internal class PacketLossCalculator : BaseWindowCalculator
{
	private uint _lost; //Field offset: 0x18

	public float PacketLoss
	{
		 get { } //Length: 225
	}

	public PacketLossCalculator(uint size) { }

	public virtual void Clear() { }

	public float get_PacketLoss() { }

	protected virtual void Updated(Nullable removed, bool added) { }

}

