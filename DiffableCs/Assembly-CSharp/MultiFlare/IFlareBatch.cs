namespace MultiFlare;

public interface IFlareBatch
{

	public int Capacity
	{
		 get { } //Length: 0
	}

	public int Length
	{
		 get { } //Length: 0
	}

	public Material Material
	{
		 get { } //Length: 0
	}

	public int get_Capacity() { }

	public int get_Length() { }

	public Material get_Material() { }

}

