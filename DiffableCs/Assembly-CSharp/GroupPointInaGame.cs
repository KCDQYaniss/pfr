//Type is in global namespace

public class GroupPointInaGame : IAICorePointLink
{
	private float _unSpottedTime; //Field offset: 0x10
	private bool _isSpotted; //Field offset: 0x14
	private bool _block; //Field offset: 0x15
	private int _ownerId; //Field offset: 0x18
	private AICorePoint _corePoint; //Field offset: 0x20
	private GroupPoint _parent; //Field offset: 0x28

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 5
	}

	public bool IsSpotted
	{
		 get { } //Length: 142
	}

	public int OwnerId
	{
		 get { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 41
	}

	public GroupPointInaGame(AICorePoint corePoint, GroupPoint parent) { }

	public void Block() { }

	public override AICorePoint get_CorePointInGame() { }

	public bool get_IsSpotted() { }

	public int get_OwnerId() { }

	public override Vector3 get_Position() { }

	public bool IsFreeById(int botId) { }

	public void SetOwner(int id) { }

	public void Spotted(float period) { }

	public void Unblock() { }

}

