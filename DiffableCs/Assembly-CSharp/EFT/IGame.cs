namespace EFT;

public interface IGame
{

	public GameObject gameObject
	{
		 get { } //Length: 0
	}

	public GameTimer GameTimer
	{
		 get { } //Length: 0
	}

	public float PastTime
	{
		 get { } //Length: 0
	}

	public GameStatus Status
	{
		 get { } //Length: 0
	}

	public GameObject get_gameObject() { }

	public GameTimer get_GameTimer() { }

	public float get_PastTime() { }

	public GameStatus get_Status() { }

}

