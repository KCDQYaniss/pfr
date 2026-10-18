namespace EFT.Utilities;

public interface IMetricsCollector
{

	public bool Stopped
	{
		 get { } //Length: 0
	}

	public bool get_Stopped() { }

	public void LateUpdate() { }

	public void Start() { }

	public void Stop() { }

}

