//Type is in global namespace

public interface IMoveByPath
{

	public PathConfig CurrentPathConfig
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public MoveByPathType MoveByPathType
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public PathConfig get_CurrentPathConfig() { }

	public MoveByPathType get_MoveByPathType() { }

	public void Initialization(MapPathConfig mapPathsConfig) { }

	public void MoveDisable() { }

	public void MoveEnable() { }

	public void MovePauseOff() { }

	public void MovePauseOn(float pauseDuration) { }

	public void MoveProcess() { }

	public void MoveToDestination(string destinationID) { }

	public void PauseProcess() { }

	public void Reset() { }

	public void set_CurrentPathConfig(PathConfig value) { }

	public void set_MoveByPathType(MoveByPathType value) { }

	public void SpawnInPoint(int index) { }

}

