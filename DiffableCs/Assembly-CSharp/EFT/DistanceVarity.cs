namespace EFT;

[DefaultMember("Item")]
public class DistanceVarity
{
	public AudioClip[] Clips; //Field offset: 0x10

	public AudioClip Item
	{
		 get { } //Length: 43
		 set { } //Length: 30
	}

	public int Length
	{
		 get { } //Length: 26
	}

	public DistanceVarity() { }

	public AudioClip get_Item(int i) { }

	public int get_Length() { }

	public void set_Item(int i, AudioClip value) { }

}

