//Type is in global namespace

public class BotExfiltrationData : BotData
{
	private float MIN_SEC_TO_EXFILTRATION; //Field offset: 0x18
	private float MAX_SEC_TO_EXFILTRATION; //Field offset: 0x1C
	private float _timeToExfiltration; //Field offset: 0x20
	private float _leaveTime; //Field offset: 0x24

	public float LeaveTime
	{
		 get { } //Length: 6
	}

	public BotExfiltrationData(BotOwner owner) { }

	public bool BotInExfiltrationArea() { }

	public float get_LeaveTime() { }

	public void ResetLeaveTime() { }

	public void SetLeaveTime(float time) { }

	public bool WannaLeave() { }

}

