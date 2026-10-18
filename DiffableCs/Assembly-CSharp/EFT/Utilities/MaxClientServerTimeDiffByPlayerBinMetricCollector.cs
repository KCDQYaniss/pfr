namespace EFT.Utilities;

public sealed class MaxClientServerTimeDiffByPlayerBinMetricCollector : BinMetricCollector
{

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public MaxClientServerTimeDiffByPlayerBinMetricCollector(uint[] keys = null) { }

	public virtual string get_Name() { }

	protected virtual uint GetCurrentValue() { }

	protected virtual Timing[] GetTimings() { }

	public virtual void LateUpdate() { }

}

