//Type is in global namespace

public class BotObserverVertical : BotData
{
	private float MinAng; //Field offset: 0x18
	private float MaxAng; //Field offset: 0x1C
	private float MinPeriod; //Field offset: 0x20
	private float MaxPeriod; //Field offset: 0x24
	private float Speed; //Field offset: 0x28
	public float PeriodNoOffsetCoef; //Field offset: 0x2C
	public float PeriodWithOffsettCoef; //Field offset: 0x30
	private float _curOffset; //Field offset: 0x34
	private float _targetOffset; //Field offset: 0x38
	private bool _curStateOffset; //Field offset: 0x3C
	private bool _isOffsetCompleted; //Field offset: 0x3D
	private float _nextChnageState; //Field offset: 0x40
	private int _lastSing; //Field offset: 0x44

	public BotObserverVertical(BotOwner owner) { }

	public float GetVerAng() { }

	public void ManualUpdate() { }

	public void VertialUpdate() { }

}

