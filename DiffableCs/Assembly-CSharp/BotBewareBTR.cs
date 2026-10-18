//Type is in global namespace

public class BotBewareBTR : BotData
{
	public Action OnBewareGrenade; //Field offset: 0x18
	private float _endPeriodOfIgnore; //Field offset: 0x20
	private float _nextPossibleRunTime; //Field offset: 0x24
	private readonly float DELTA_CALC_TIME; //Field offset: 0x28
	private float deltaGoCheck; //Field offset: 0x2C

	private BTRVehicle BTRVehicle
	{
		private get { } //Length: 131
	}

	public BotBewareBTR(BotOwner owner) { }

	private void CalcToCoverBTR() { }

	private CustomNavigationPoint DoExtraSearch() { }

	private BTRVehicle get_BTRVehicle() { }

	public bool ShallRunAway() { }

	public void UpdateByNode() { }

}

