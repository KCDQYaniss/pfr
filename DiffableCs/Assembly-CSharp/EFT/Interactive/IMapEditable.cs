namespace EFT.Interactive;

public interface IMapEditable
{

	public GameObject GameObject
	{
		 get { } //Length: 0
	}

	public string IdEditable
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string TypeKey
	{
		 get { } //Length: 0
	}

	public GameObject get_GameObject() { }

	public string get_IdEditable() { }

	public string get_TypeKey() { }

	public void set_IdEditable(string value) { }

}

