//Type is in global namespace

public class BotGroupDangerAreas
{
	private const float S_RAD_TO_START_ATTACK = 3600; //Field offset: 0x0
	private float _nextCheckPeriod; //Field offset: 0x10
	private readonly BotZoneDangerAreas _datas; //Field offset: 0x18
	private readonly BotsGroup _group; //Field offset: 0x20
	private readonly List _assaultGroups; //Field offset: 0x28
	private readonly bool _canUse; //Field offset: 0x30

	public int AssaultGroupsCount
	{
		 get { } //Length: 65
	}

	public int DangerZonesCount
	{
		 get { } //Length: 74
	}

	public BotGroupDangerAreas(BotZoneDangerAreas botZoneDangerAreas, BotsGroup group) { }

	private void CheckBotsForArea(AIDangerArea botZoneDangerArea) { }

	public void Dispose() { }

	public int get_AssaultGroupsCount() { }

	public int get_DangerZonesCount() { }

	public void ManualUpdate() { }

}

