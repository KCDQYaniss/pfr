//Type is in global namespace

[DefaultMember("Item")]
public class WalkPreset : ScriptableObject
{
	public AnimVal[] Curves; //Field offset: 0x18

	public AnimVal Item
	{
		 get { } //Length: 43
	}

	public WalkPreset() { }

	public AnimVal get_Item(int index) { }

}

