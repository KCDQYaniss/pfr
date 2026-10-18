//Type is in global namespace

public struct SeasonGrass
{
	[HideInInspector]
	[SerializeField]
	private ResourceKey _textureKey; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private ResourceKey _bumpKey; //Field offset: 0x8
	public Color DetailHealthyColor; //Field offset: 0x10
	public Color DetailDryColor; //Field offset: 0x20
	public Color WindWaveTintColor; //Field offset: 0x30

	public ResourceKey BumpKey
	{
		 get { } //Length: 5
	}

	public ResourceKey TextureKey
	{
		 get { } //Length: 4
	}

	public ResourceKey get_BumpKey() { }

	public ResourceKey get_TextureKey() { }

}

