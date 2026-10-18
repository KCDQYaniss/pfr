//Type is in global namespace

public sealed class MetaXRAudioSettings : ScriptableObject
{
	private static MetaXRAudioSettings instance; //Field offset: 0x0
	[SerializeField]
	public int voiceLimit; //Field offset: 0x18

	public static MetaXRAudioSettings Instance
	{
		 get { } //Length: 709
	}

	public MetaXRAudioSettings() { }

	public static MetaXRAudioSettings get_Instance() { }

}

