namespace Audio.Data;

[DefaultMember("Item")]
public class AudioMixerParamsContainer : IEnumerable
{
	[SerializeField]
	private string[] _mixerParams; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 26
	}

	public string Item
	{
		 get { } //Length: 43
	}

	public AudioMixerParamsContainer() { }

	public int get_Count() { }

	public string get_Item(int i) { }

	public IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

