namespace EFT.ActiveHeadphones;

public class HeadphonesLocalTemplatesContainer : IDataContainer
{
	private readonly HeadphonesTemplate _fallback; //Field offset: 0x10
	private readonly HeadphonesTemplate _fullMute; //Field offset: 0x18
	private readonly HeadphonesApplyContext _fallbackContext; //Field offset: 0x20
	private readonly HeadphonesApplyContext _fullMuteContext; //Field offset: 0x30
	private ClientCustomHeadphonesTemplates _templates; //Field offset: 0x40
	private HeadphonesApplyContext _default; //Field offset: 0x48
	private HeadphonesApplyContext _lowMute; //Field offset: 0x58
	private HeadphonesApplyContext _strongMute; //Field offset: 0x68
	private HeadphonesApplyContext _spectator; //Field offset: 0x78

	public HeadphonesApplyContext Default
	{
		 get { } //Length: 26
	}

	public HeadphonesApplyContext FullMute
	{
		 get { } //Length: 11
	}

	public HeadphonesApplyContext LowMute
	{
		 get { } //Length: 26
	}

	public HeadphonesApplyContext Spectator
	{
		 get { } //Length: 26
	}

	public HeadphonesApplyContext StrongMute
	{
		 get { } //Length: 26
	}

	public HeadphonesLocalTemplatesContainer() { }

	public HeadphonesApplyContext get_Default() { }

	public HeadphonesApplyContext get_FullMute() { }

	public HeadphonesApplyContext get_LowMute() { }

	public HeadphonesApplyContext get_Spectator() { }

	public HeadphonesApplyContext get_StrongMute() { }

	public HeadphonesApplyContext GetHeadphonesTemplateByDeaf(EDeafStrength deafStrength) { }

	public void SetTemplates(ClientCustomHeadphonesTemplates templates) { }

}

