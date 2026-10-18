//Type is in global namespace

public class ThrowGrenadePlaceRequest : ThrowGrenadeRequest
{
	private readonly ThrowGrenadePlace _placeToThrow; //Field offset: 0x88
	private readonly Action _callbackFinish; //Field offset: 0x90
	private readonly OpenDoorRequest _doorOpenRequest; //Field offset: 0x98
	private bool isDoorOpened; //Field offset: 0xA0

	public virtual Vector3 PlaceToThrow
	{
		 get { } //Length: 230
	}

	public ThrowGrenadePlaceRequest(Player requester, ThrowGrenadePlace pos, OpenDoorRequest doorOpenRequest, Action callbackFinish) { }

	public virtual bool CanProceed() { }

	public virtual bool CanStartExecute(BotOwner executer) { }

	public virtual bool CanThrow() { }

	public virtual void Dispose() { }

	public virtual Vector3 get_PlaceToThrow() { }

	private void OnDoorOpened(bool obj) { }

	public virtual void Take(BotOwner executor) { }

}

