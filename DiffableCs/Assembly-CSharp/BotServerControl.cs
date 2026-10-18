//Type is in global namespace

public class BotServerControl : MonoBehaviour
{
	private Vector3 _target; //Field offset: 0x20
	[CompilerGenerated]
	private BotOwner <ControllableBot>k__BackingField; //Field offset: 0x30

	public private BotOwner ControllableBot
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotServerControl() { }

	[CompilerGenerated]
	public BotOwner get_ControllableBot() { }

	[CompilerGenerated]
	private void set_ControllableBot(BotOwner value) { }

	public void SetBotUnderControl(BotOwner bot) { }

	public void SetSpring(bool sprint) { }

	private void Update() { }

	private void UpdateKeyboard() { }

}

