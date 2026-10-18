//Type is in global namespace

public class AIPlaceCorePointMarker : MonoBehaviour, IAICorePointLink
{
	[SerializeField]
	private string _debugInfo; //Field offset: 0x20
	[SerializeField]
	private int _corePointId; //Field offset: 0x28
	[SerializeField]
	private bool _isIndoor; //Field offset: 0x2C
	[SerializeField]
	private bool _lastCheckValid; //Field offset: 0x2D
	[SerializeField]
	private int _maxPersons; //Field offset: 0x30
	private AICorePoint _corePointInGame; //Field offset: 0x38

	public int CorePointId
	{
		 get { } //Length: 4
	}

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 483
	}

	public string DebugInfo
	{
		 get { } //Length: 5
	}

	public bool IsIndoor
	{
		 get { } //Length: 5
	}

	public bool LastCheckValid
	{
		 get { } //Length: 5
	}

	public int MaxPersons
	{
		 get { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public AIPlaceCorePointMarker() { }

	public void ApplyEditorCheckResult(AICorePoint corePoint, bool isIndoor, bool isValid) { }

	public bool CanFitPersons(int personsCount) { }

	public int get_CorePointId() { }

	public override AICorePoint get_CorePointInGame() { }

	public string get_DebugInfo() { }

	public bool get_IsIndoor() { }

	public bool get_LastCheckValid() { }

	public int get_MaxPersons() { }

	public override Vector3 get_Position() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

}

