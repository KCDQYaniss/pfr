//Type is in global namespace

public class BotStroboscopeLight : BotData
{
	private const float SWITCH_PERIOD = 0.1; //Field offset: 0x0
	private bool _canUse; //Field offset: 0x18
	private bool _switcher; //Field offset: 0x19
	private bool _enabled; //Field offset: 0x1A
	private float _nextSwitch; //Field offset: 0x1C
	private float _endTotal; //Field offset: 0x20
	private BotLight _light; //Field offset: 0x28

	public BotStroboscopeLight(BotOwner owner, BotLight light) { }

	public void EnableFor(float period) { }

	public void ManualUpdate() { }

}

