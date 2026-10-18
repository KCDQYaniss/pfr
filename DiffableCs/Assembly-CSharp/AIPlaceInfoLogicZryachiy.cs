//Type is in global namespace

public class AIPlaceInfoLogicZryachiy : AIPlaceInfoLogic
{
	public bool CloseZone; //Field offset: 0x20
	public bool AttackPossible; //Field offset: 0x21
	public bool PermanentVision; //Field offset: 0x22
	public bool ControllableZone; //Field offset: 0x23
	public bool FollowersPositions; //Field offset: 0x24
	public bool BossPositions; //Field offset: 0x25
	public bool LookAtCenter; //Field offset: 0x26
	private int IsTakenById; //Field offset: 0x28

	public AIPlaceInfoLogicZryachiy() { }

	public bool CanTakeBy(BotOwner bot) { }

	private void CheckHaveCoverWithPlaceId(AIPlaceInfo aIPlace) { }

	public virtual void EditorCheck(AIPlaceInfo aIPlace) { }

	public void ReleaseBy(BotOwner bot) { }

	public void TakeBy(BotOwner bot) { }

}

