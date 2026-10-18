//Type is in global namespace

public class BotTilt : BotData
{
	private bool _coreTilt; //Field offset: 0x18
	private readonly bool _canITilt; //Field offset: 0x19
	private float tiltOff; //Field offset: 0x1C
	private float _curTilt; //Field offset: 0x20
	private BotTiltType _botTiltType; //Field offset: 0x24

	public BotTilt(BotOwner owner) { }

	public float CurStatus() { }

	public void ManualUpdate() { }

	public void Set(BotTiltType tiltSide) { }

	public void Stop(bool force = false) { }

	public static void TryTiltToEnemySide(BotOwner bot) { }

}

