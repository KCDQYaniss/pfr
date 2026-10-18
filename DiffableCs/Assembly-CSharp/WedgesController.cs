//Type is in global namespace

public class WedgesController
{
	public const float SDistSafeRewarmMine = 81; //Field offset: 0x0
	public const int MaxPlantAttempts = 3; //Field offset: 0x0
	private readonly int _maxRewarmMinePlanted; //Field offset: 0x10
	private int _rewarmMinePlanted; //Field offset: 0x14
	private int _plantedTries; //Field offset: 0x18

	public int MaxRewarmMinePlanted
	{
		 get { } //Length: 164
	}

	public int PlantedTries
	{
		 get { } //Length: 4
	}

	public int RewarmMinePlanted
	{
		 get { } //Length: 4
	}

	public WedgesController(BotsController botsController) { }

	public bool CanPlantMoreRewarmMines() { }

	public int get_MaxRewarmMinePlanted() { }

	public int get_PlantedTries() { }

	public int get_RewarmMinePlanted() { }

	public void RegisterRewarmMinePlanted() { }

	public bool TryBeginPlantAttempt() { }

}

