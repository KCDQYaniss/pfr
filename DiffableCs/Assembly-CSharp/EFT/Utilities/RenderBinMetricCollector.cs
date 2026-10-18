namespace EFT.Utilities;

public sealed class RenderBinMetricCollector : BinMetricCollector
{

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public RenderBinMetricCollector(uint[] keys = null) { }

	public virtual string get_Name() { }

	protected virtual uint GetCurrentValue() { }

}

