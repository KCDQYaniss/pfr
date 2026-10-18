//Type is in global namespace

public class CallEnemyTargetInfo
{
	private Nullable _target; //Field offset: 0x10
	private int _envId; //Field offset: 0x20

	public int EnvId
	{
		 get { } //Length: 4
	}

	public bool HasValue
	{
		 get { } //Length: 62
	}

	public Vector3 Value
	{
		 get { } //Length: 91
	}

	public CallEnemyTargetInfo(Vector3 trg, int envId) { }

	public CallEnemyTargetInfo() { }

	public int get_EnvId() { }

	public bool get_HasValue() { }

	public Vector3 get_Value() { }

}

