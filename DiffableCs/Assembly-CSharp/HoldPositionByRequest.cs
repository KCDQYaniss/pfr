//Type is in global namespace

public class HoldPositionByRequest : HoldPosition
{
	private float _nextTimeCheck; //Field offset: 0x60
	private bool _lookToPlace; //Field offset: 0x64

	public HoldPositionByRequest(BotOwner bot) { }

	protected virtual void Look() { }

}

