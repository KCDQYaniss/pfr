namespace EFT.Utilities;

public sealed class FrameWithoutFixedUpdatesBinMetricCollector : BinMetricCollector
{

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public FrameWithoutFixedUpdatesBinMetricCollector(uint[] keys = null) { }

	public virtual string get_Name() { }

	protected virtual uint GetCurrentValue() { }

}

