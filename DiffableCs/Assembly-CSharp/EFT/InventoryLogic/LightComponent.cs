namespace EFT.InventoryLogic;

public class LightComponent : ItemComponent
{
	[Diffable]
	public bool IsActive; //Field offset: 0x18
	private readonly ILightComponentTemplate _template; //Field offset: 0x20
	private int _selectedMode; //Field offset: 0x28

	[Diffable]
	public int SelectedMode
	{
		 get { } //Length: 4
		 set { } //Length: 26
	}

	public LightComponent(Item item, ILightComponentTemplate template) { }

	private int ClampSelectedMode(int value) { }

	public int get_SelectedMode() { }

	public LightsState GetLightState(bool toggleActive = false, bool switchMod = false) { }

	public void set_SelectedMode(int value) { }

	public bool SetLightState(LightsState state) { }

}

