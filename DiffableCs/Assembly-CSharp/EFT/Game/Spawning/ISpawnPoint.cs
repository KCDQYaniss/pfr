namespace EFT.Game.Spawning;

public interface ISpawnPoint : IPositionPoint
{

	public string BotZoneName
	{
		 get { } //Length: 0
	}

	public ESpawnCategoryMask Categories
	{
		 get { } //Length: 0
	}

	public ISpawnPointCollider Collider
	{
		 get { } //Length: 0
	}

	public int CorePointId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float DelayToCanSpawnSec
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public string Infiltration
	{
		 get { } //Length: 0
	}

	public bool IsSnipeZone
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public float NextBornTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public Quaternion Rotation
	{
		 get { } //Length: 0
	}

	public EPlayerSideMask Sides
	{
		 get { } //Length: 0
	}

	public bool SpawnBlocked
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float CalcMultiSpawnDelay(float additionalDelay, BotCreationData creationData) { }

	public void Dispose() { }

	public string get_BotZoneName() { }

	public ESpawnCategoryMask get_Categories() { }

	public ISpawnPointCollider get_Collider() { }

	public int get_CorePointId() { }

	public float get_DelayToCanSpawnSec() { }

	public string get_Id() { }

	public string get_Infiltration() { }

	public bool get_IsSnipeZone() { }

	public string get_Name() { }

	public float get_NextBornTime() { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	public EPlayerSideMask get_Sides() { }

	public bool get_SpawnBlocked() { }

	public void IncreaseUsedPlayerSpawnsForNearestPlayer(BotCreationData creationData) { }

	public bool IsInPlayersIndividualLimits(BotCreationData creationData) { }

	public bool IsNotCollidedArtillery(ArtilleryShellingControllerServer artilleryShelling) { }

	public void set_CorePointId(int value) { }

	public void set_NextBornTime(float value) { }

	public void set_SpawnBlocked(bool value) { }

}

