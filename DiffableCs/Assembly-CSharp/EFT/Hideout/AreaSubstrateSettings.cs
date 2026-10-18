namespace EFT.Hideout;

public sealed class AreaSubstrateSettings : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary _areaRelatedPanels; //Field offset: 0x58
	[SerializeField]
	private Dictionary _panelsVisibilitySettings; //Field offset: 0x60

	public Dictionary Panels
	{
		 get { } //Length: 5
	}

	public Dictionary VisibilitySettings
	{
		 get { } //Length: 5
	}

	public AreaSubstrateSettings() { }

	public Dictionary get_Panels() { }

	public Dictionary get_VisibilitySettings() { }

}

