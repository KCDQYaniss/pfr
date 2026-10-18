//Type is in global namespace

public class BotAssaultBuildingData : BotData
{
	private const float ATTACK_PERIOD = 60; //Field offset: 0x0
	private const float SDIST_TO_START_ATTACK = 625; //Field offset: 0x0
	private bool _isActive; //Field offset: 0x18
	private ITimer _timer; //Field offset: 0x20
	private int _taskId; //Field offset: 0x28
	private float _wantAssault; //Field offset: 0x2C

	public bool IsActive
	{
		 get { } //Length: 5
	}

	public BotAssaultBuildingData(BotOwner owner) { }

	private void AttackAllGroup() { }

	public void Dispose() { }

	public bool get_IsActive() { }

	private void OnStop() { }

	public void PeriodCheckStart() { }

	public void StartFor(float period) { }

	public void Stop() { }

}

