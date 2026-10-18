//Type is in global namespace

public interface IAudioGroupResourceMonitor
{

	public event Action OnCriticalResources
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnGroupCriticalResources
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnLowResources
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnResourcesRestored
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnCriticalResources(Action value) { }

	[CompilerGenerated]
	public void add_OnGroupCriticalResources(Action value) { }

	[CompilerGenerated]
	public void add_OnLowResources(Action value) { }

	[CompilerGenerated]
	public void add_OnResourcesRestored(Action value) { }

	[CompilerGenerated]
	public void remove_OnCriticalResources(Action value) { }

	[CompilerGenerated]
	public void remove_OnGroupCriticalResources(Action value) { }

	[CompilerGenerated]
	public void remove_OnLowResources(Action value) { }

	[CompilerGenerated]
	public void remove_OnResourcesRestored(Action value) { }

	public void SetMonitoringInterval(float interval) { }

	public void SetResourceThreshold(AudioSourceGroupType groupType, float lowThreshold, float highThreshold, float criticalThreshold) { }

	public void StartMonitoring(float interval = 0.5) { }

	public void StopMonitoring() { }

}

