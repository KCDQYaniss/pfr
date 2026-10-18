//Type is in global namespace

public class DangerData
{
	public int _curShootTime; //Field offset: 0x10
	public PlaceForCheck _place; //Field offset: 0x18
	public int shootTime; //Field offset: 0x20
	private float disposeTime; //Field offset: 0x24

	public bool HaveCloseDanger
	{
		 get { } //Length: 133
	}

	public DangerData() { }

	public bool get_HaveCloseDanger() { }

	public void SetTarget(PlaceForCheck place, BotOwner owner) { }

	public void ShootDone() { }

	public void TargetNull() { }

}

