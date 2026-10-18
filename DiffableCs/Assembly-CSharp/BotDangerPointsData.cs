//Type is in global namespace

public class BotDangerPointsData : BotData
{
	public PlaceForCheck place; //Field offset: 0x18
	public bool realDanger; //Field offset: 0x20
	public float ExpireTime; //Field offset: 0x24
	public PanicType PanicType; //Field offset: 0x28
	public float PanicPower; //Field offset: 0x2C

	public bool HaveDangePoints
	{
		 get { } //Length: 8
	}

	public bool IsPanic
	{
		 get { } //Length: 238
	}

	public BotDangerPointsData(BotOwner owner) { }

	public void AddPointOfDanger(PlaceForCheck placeForCheck, bool realDanger) { }

	public void CheckDangerPoints(float maxLifetime) { }

	private void Clear() { }

	public bool get_HaveDangePoints() { }

	public bool get_IsPanic() { }

	public void SetAllDangerNull() { }

}

