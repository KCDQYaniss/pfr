namespace EFT.Utilities;

public sealed class ReceivedPacketsCountBinMetricCollector : BinMetricCollector
{

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public ReceivedPacketsCountBinMetricCollector(uint[] keys = null) { }

	public virtual string get_Name() { }

	protected virtual uint GetCurrentValue() { }

}

