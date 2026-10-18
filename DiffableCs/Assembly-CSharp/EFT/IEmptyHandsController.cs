namespace EFT;

public interface IEmptyHandsController : IHandsController, ICompassController
{

	public EmptyHands Item
	{
		 get { } //Length: 0
	}

	public void ExamineWeapon() { }

	public EmptyHands get_Item() { }

}

