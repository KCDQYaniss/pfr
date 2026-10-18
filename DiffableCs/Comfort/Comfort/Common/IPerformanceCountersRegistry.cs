namespace Comfort.Common;

public interface IPerformanceCountersRegistry
{

	public string InstanceName
	{
		 get { } //Length: 0
	}

	public string get_InstanceName() { }

	public bool IsInstalled(Type categoryType) { }

	public void SetInstalled(Type categoryType) { }

}

