namespace Audio;

public interface ITab : IDisposable
{

	public string Title
	{
		 get { } //Length: 0
	}

	public void Draw() { }

	public string get_Title() { }

	public void OnEnable() { }

}

