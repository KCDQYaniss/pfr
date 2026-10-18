namespace EFT.Hideout;

public sealed class PanelVisibilitySettings
{
	public List CurrentLevel; //Field offset: 0x10
	public List NextLevel; //Field offset: 0x18

	public PanelVisibilitySettings() { }

	private EPanelType CurrentLevelAddFunction() { }

	private EPanelType NextLevelAddFunction() { }

}

