//Type is in global namespace

public interface ISeasonsController : IDisposable
{

	public event Action SnowLevelOnTerrainChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action StatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ESeason Season
	{
		 get { } //Length: 0
	}

	public float SnowLevelOnTerrain
	{
		 get { } //Length: 0
	}

	public ESeasonStatus Status
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_SnowLevelOnTerrainChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_StatusChangedEvent(Action value) { }

	public ESeason get_Season() { }

	public float get_SnowLevelOnTerrain() { }

	public ESeasonStatus get_Status() { }

	public Task HandleReconnect(ESeasonStatus seasonStatus, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings) { }

	public void Register(IWinterEventVisual winterVisual) { }

	[CompilerGenerated]
	public void remove_SnowLevelOnTerrainChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_StatusChangedEvent(Action value) { }

	public void Unregister(IWinterEventVisual winterVisual) { }

}

