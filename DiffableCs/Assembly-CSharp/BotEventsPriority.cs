//Type is in global namespace

public class BotEventsPriority
{
	public int Khorovod; //Field offset: 0x10
	public int ForceAttack; //Field offset: 0x14
	public int ForcePersuit; //Field offset: 0x18
	public int FollowPlayer; //Field offset: 0x1C
	public int HalloweenHide; //Field offset: 0x20
	public int GoToGenerator; //Field offset: 0x24
	public int GoToTarget; //Field offset: 0x28
	private WaitAndGoBotEventsPriority _waitAndGo; //Field offset: 0x30

	public BotEventsPriority(int priorityKhorovod, int priorityForceAttack, int priorityForcePersuit, int followPlayer, int halloweenHide = -1, int gotoGenerator = -1, int goToTarget = -1) { }

}

