//Type is in global namespace

public class PatrolWayWithName : PatrolWay
{
	public string NameId; //Field offset: 0x48

	public PatrolWayWithName() { }

	public virtual bool Suitable(BotOwner bot, IGetProfileData data) { }

	public virtual string SuitableData() { }

}

