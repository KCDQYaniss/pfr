//Type is in global namespace

public interface IBotZone
{

	public float DistanceCoef
	{
		 get { } //Length: 0
	}

	public int MaxPersons
	{
		 get { } //Length: 0
	}

	public BotLocationModifier Modifier
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public string NameZone
	{
		 get { } //Length: 0
	}

	public PatrolWay[] PatrolWays
	{
		 get { } //Length: 0
	}

	public string ShortName
	{
		 get { } //Length: 0
	}

	public List SpawnPointMarkers
	{
		 get { } //Length: 0
	}

	public ISpawnPoint[] SpawnPoints
	{
		 get { } //Length: 0
	}

	public UnspawnPoint[] UnSpawnPoints
	{
		 get { } //Length: 0
	}

	public BotZoneDangerAreas ZoneDangerAreas
	{
		 get { } //Length: 0
	}

	public float get_DistanceCoef() { }

	public int get_MaxPersons() { }

	public BotLocationModifier get_Modifier() { }

	public string get_name() { }

	public string get_NameZone() { }

	public PatrolWay[] get_PatrolWays() { }

	public string get_ShortName() { }

	public List get_SpawnPointMarkers() { }

	public ISpawnPoint[] get_SpawnPoints() { }

	public UnspawnPoint[] get_UnSpawnPoints() { }

	public BotZoneDangerAreas get_ZoneDangerAreas() { }

}

