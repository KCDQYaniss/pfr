//Type is in global namespace

public class BotTradersServices
{
	private BotLighthouseKeeperServices _lighthouseKeeperServices; //Field offset: 0x10
	private BotBTRService _btrServices; //Field offset: 0x18

	public BotBTRService BTRServices
	{
		 get { } //Length: 5
	}

	public BotLighthouseKeeperServices LighthouseKeeperServices
	{
		 get { } //Length: 5
	}

	public BotTradersServices(BotsController botController) { }

	public void Dispose() { }

	public BotBTRService get_BTRServices() { }

	public BotLighthouseKeeperServices get_LighthouseKeeperServices() { }

}

