namespace EFT.UI;

public interface IUIView : IDisposable
{

	public GameObject GameObject
	{
		 get { } //Length: 0
	}

	public Transform Transform
	{
		 get { } //Length: 0
	}

	public GameObject get_GameObject() { }

	public Transform get_Transform() { }

}

