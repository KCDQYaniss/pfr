//Type is in global namespace

public class BotSuppressShoot : BotSuppressData
{
	private int _shoots; //Field offset: 0x50
	private bool _canShootLastTime; //Field offset: 0x54
	private float _nextShootTimeCheck; //Field offset: 0x58
	private List _points; //Field offset: 0x60
	private int _shootIndex; //Field offset: 0x68
	private int _limitShots; //Field offset: 0x6C

	public BotSuppressShoot(BotOwner owner) { }

	public virtual void Activate() { }

	public virtual void Dispose() { }

	public bool Init(EnemyInfo enemyToSupress, CustomNavigationPoint pos = null) { }

	public bool InitToPoint(Vector3 point, CustomNavigationPoint pos = null) { }

	public bool InitToPoints(List point, CustomNavigationPoint pos = null) { }

	public void ManualUpdate() { }

	private void OnTriggerPressed() { }

}

