//Type is in global namespace

public class BotSearchPoint
{
	public Vector3 Position; //Field offset: 0x10
	public EBotSearchPoint TypeSearch; //Field offset: 0x1C
	public bool Reachable; //Field offset: 0x20

	public BotSearchPoint(Vector3 position, EBotSearchPoint typeSearch, bool reachable) { }

	public override void Come() { }

	public virtual string ToString() { }

}

