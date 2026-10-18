//Type is in global namespace

public abstract class MoveNode`1 : BaseNode
{
	protected bool ShouldGetUpWhileMoving; //Field offset: 0x0
	public bool WithDoor; //Field offset: 0x0
	protected BotObserveData _botObserveData; //Field offset: 0x0

	public MoveNode`1(BotOwner bot) { }

	protected void ChecksWhileMoving(out DoorInteractionStatus doorInteractionStatus, bool deactivatingMines = true) { }

	private void GetUpChecker() { }

	protected void GoFullSpeed() { }

	protected void GoProne() { }

	protected void MineAvoider(bool deavtivatingMines = true) { }

	protected void UpdateLookAroundTimer(bool anyway) { }

}

