//Type is in global namespace

public class DeadBodiesController
{
	public List Bodies; //Field offset: 0x10
	private readonly Dictionary Bodiesgroups; //Field offset: 0x18
	private readonly BotZoneGroupsDictionary _groups; //Field offset: 0x20

	public int BodiesCount
	{
		 get { } //Length: 65
	}

	public DeadBodiesController(BotZoneGroupsDictionary groups) { }

	public void AddBody(BotsGroup botsGroup, DeadBody body) { }

	public void AddBody(IPlayer player) { }

	public List BodiesByGroup(BotsGroup botsGroup) { }

	public int get_BodiesCount() { }

	public bool HaveBody(IPlayer player) { }

	public void RemoveBody(DeadBody body) { }

}

