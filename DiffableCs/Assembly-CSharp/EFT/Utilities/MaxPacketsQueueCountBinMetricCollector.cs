namespace EFT.Utilities;

public sealed class MaxPacketsQueueCountBinMetricCollector : BinMetricCollector
{

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public MaxPacketsQueueCountBinMetricCollector(uint[] keys = null) { }

	public virtual string get_Name() { }

	protected virtual uint GetCurrentValue() { }

}

