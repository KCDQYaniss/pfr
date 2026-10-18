//Type is in global namespace

public class SuppressionData
{
	public EnemyInfo EnemyByRequester; //Field offset: 0x10
	private readonly Vector3 _point; //Field offset: 0x18
	private Vector3 _shootPosition; //Field offset: 0x24

	public SuppressionData(EnemyInfo enemyByRequester) { }

	public SuppressionData(Vector3 point) { }

	public bool IsTarget(IPlayer person) { }

	public Vector3 ShootPos() { }

}

