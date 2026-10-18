namespace MultiFlare;

public interface ILightStorage
{

	public int Capacity
	{
		 get { } //Length: 0
	}

	public int Count
	{
		 get { } //Length: 0
	}

	public bool Contains(FlareLight light) { }

	public int get_Capacity() { }

	public int get_Count() { }

}

