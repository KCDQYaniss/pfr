//Type is in global namespace

public class LightSwitcherOverkill : CameraLightSwitcher
{
	private readonly List _allLights; //Field offset: 0x28

	public LightSwitcherOverkill() { }

	protected virtual void OnPostRender() { }

	protected virtual void OnPreCull() { }

}

