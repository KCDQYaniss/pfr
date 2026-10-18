//Type is in global namespace

public class InfectedLookData : LookData
{

	public InfectedLookData(BotOwner owner) { }

	protected virtual bool IsLookPointExistAndValid(CustomNavigationPoint point) { }

	public virtual void SetLookPointByHearing(CustomNavigationPoint closestPoint = null) { }

}

