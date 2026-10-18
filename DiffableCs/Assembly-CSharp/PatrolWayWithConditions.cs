//Type is in global namespace

public class PatrolWayWithConditions : PatrolWay
{
	public SpawnTriggerType TriggerType; //Field offset: 0x48
	public string Id; //Field offset: 0x50

	public PatrolWayWithConditions() { }

	public virtual bool Suitable(BotOwner bot, IGetProfileData data) { }

}

