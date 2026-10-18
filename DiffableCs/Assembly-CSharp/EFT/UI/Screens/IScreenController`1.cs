namespace EFT.UI.Screens;

public interface IScreenController`1
{

	public bool Closed
	{
		 get { } //Length: 0
	}

	public T ScreenType
	{
		 get { } //Length: 0
	}

	public bool get_Closed() { }

	public T get_ScreenType() { }

	public Task TryCloseScreen() { }

}

