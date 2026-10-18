//Type is in global namespace

public class ZoneShellingProcess
{
	public int roundsCountTarget; //Field offset: 0x10
	public int roundsCountCurrent; //Field offset: 0x14
	public int shotsCountTarget; //Field offset: 0x18
	public int shotsCountCurrent; //Field offset: 0x1C
	public float pauseBetweenShotsTime; //Field offset: 0x20
	public float pauseBetweenShotsTimeElapsed; //Field offset: 0x24
	public float pauseBetweenRoundsTime; //Field offset: 0x28
	public float pauseBetweenRoundsTimeElapsed; //Field offset: 0x2C
	public float remainingTime; //Field offset: 0x30
	public bool pauseBetweenShotOn; //Field offset: 0x34
	public bool pauseBetweenRoundOn; //Field offset: 0x35
	public bool shellingNotifySended; //Field offset: 0x36
	public int shellingBrigadeID; //Field offset: 0x38
	public List ShellingPoints; //Field offset: 0x40
	public List BoundsPoints; //Field offset: 0x48
	public Dictionary PlayersInAlertZone; //Field offset: 0x50

	public ZoneShellingProcess() { }

	public void CalculateRoundsPause() { }

	public void CalculateShotsPause() { }

	public void InitRoundsPause(float time) { }

	public void InitShotPause(float time) { }

	public void RefreshProcess() { }

}

