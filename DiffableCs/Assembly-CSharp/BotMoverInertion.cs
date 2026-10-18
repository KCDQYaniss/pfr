//Type is in global namespace

public class BotMoverInertion : BotData
{
	public const float MAX_INERTION = 0.3; //Field offset: 0x0
	public const float CLAMP_ANG = 85; //Field offset: 0x0
	private Vector3 _lastInertion; //Field offset: 0x18
	private BotPathController _pathController; //Field offset: 0x28
	private float _collectedAng; //Field offset: 0x30
	private Vector3 _currentOffset; //Field offset: 0x34

	public float _collectedAngDownSpeed
	{
		 get { } //Length: 28
	}

	public float InertionDownSpeed
	{
		 get { } //Length: 28
	}

	public BotMoverInertion(BotOwner owner) { }

	public void Activate(BotPathController pathController) { }

	private void AddcollectedAng(float ang, bool isLeft) { }

	public Vector3 AddToInertion(Vector3 realDelta, Vector3 curPos, out Vector3 currentOffset) { }

	public void Dispose() { }

	private void DownGradeCollected() { }

	public void DropOffset() { }

	public float get__collectedAngDownSpeed() { }

	public float get_InertionDownSpeed() { }

	public Vector3 GetOffset() { }

	private void OnWayChanged(bool havePrevWay) { }

	public void UpdateOnCoef(float coef) { }

}

