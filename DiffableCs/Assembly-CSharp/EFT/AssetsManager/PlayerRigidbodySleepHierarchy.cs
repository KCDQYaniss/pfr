namespace EFT.AssetsManager;

public class PlayerRigidbodySleepHierarchy
{
	public EBodyPartColliderType BodyPart; //Field offset: 0x10
	public RigidbodySpawner RigidbodySpawner; //Field offset: 0x18
	public PlayerRigidbodySleepHierarchy Parent; //Field offset: 0x20
	public bool MustBeSleeping; //Field offset: 0x28

	public bool CanSleep
	{
		 get { } //Length: 110
	}

	public PlayerRigidbodySleepHierarchy() { }

	public bool get_CanSleep() { }

	public void Reset() { }

	public bool TryPutToSleep() { }

	public void WakeUp() { }

}

