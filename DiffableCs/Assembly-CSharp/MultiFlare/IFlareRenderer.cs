namespace MultiFlare;

public interface IFlareRenderer
{

	public bool IsDebugModeEnabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_IsDebugModeEnabled() { }

	public IEnumerable GetBatches() { }

	public IEnumerable GetCameras() { }

	public void set_IsDebugModeEnabled(bool value) { }

}

