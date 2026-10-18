namespace EFT;

[DefaultMember("Item")]
public class EnvironmentVariety
{
	public DistanceVarity[] Clips; //Field offset: 0x10

	public DistanceVarity Item
	{
		 get { } //Length: 43
		 set { } //Length: 105
	}

	public int Length
	{
		 get { } //Length: 26
	}

	public EnvironmentVariety() { }

	public DistanceVarity get_Item(int i) { }

	public int get_Length() { }

	public void set_Item(int i, DistanceVarity value) { }

}

