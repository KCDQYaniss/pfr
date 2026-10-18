namespace CommonAssets.Scripts.Utilities;

public class ThresholdCounter
{
	private int _targetCount; //Field offset: 0x10
	private int _currentCount; //Field offset: 0x14

	public bool IsThresholdReached
	{
		 get { } //Length: 10
	}

	public ThresholdCounter() { }

	public bool get_IsThresholdReached() { }

	public void ResetCounter() { }

	public void SetTargetCount(int targetCount) { }

	public bool TryReachThreshold() { }

}

