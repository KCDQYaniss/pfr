namespace EFT;

public class RadioTransmitterHandler : BaseRecodableItemHandler
{
	private const string LIGHTHOUSE_LOCATION_ID = "Lighthouse"; //Field offset: 0x0
	private Player _player; //Field offset: 0x18
	private RadioTransmitterRecodableComponent _recodableComponent; //Field offset: 0x20
	private bool _isOfflineGame; //Field offset: 0x28
	private bool _inLighthouseLocation; //Field offset: 0x29
	private List _teammatesList; //Field offset: 0x30
	private List _exceptionBotsList; //Field offset: 0x38
	private WildSpawnType[] _exceptionBotRoles; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnStatusChanged; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnAllTeammatesChangeRadioTransmitterStatus; //Field offset: 0x50

	public event Action OnAllTeammatesChangeRadioTransmitterStatus
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RadioTransmitterRecodableComponent RecodableComponent
	{
		 get { } //Length: 5
	}

	public RadioTransmitterStatus Status
	{
		 get { } //Length: 26
	}

	public RadioTransmitterHandler(RadioTransmitterRecodableComponent radioTransmitterRecodableComponent, Player player) { }

	[CompilerGenerated]
	public void add_OnAllTeammatesChangeRadioTransmitterStatus(Action value) { }

	[CompilerGenerated]
	public void add_OnStatusChanged(Action value) { }

	private bool AllTeammatesHaveEncodedRadioTransmitter() { }

	private void DetermainLocation() { }

	private void DetermainServerMode() { }

	protected virtual void Finalize() { }

	private void FindExceptionBots() { }

	private void FindPlayerTeammates() { }

	public RadioTransmitterRecodableComponent get_RecodableComponent() { }

	public RadioTransmitterStatus get_Status() { }

	private void InitializeHandler(RadioTransmitterRecodableComponent radioTransmitterRecodableComponent, Player player) { }

	public void OnGetRadioTransmitterStatusFromClient() { }

	public void OnPlayerAddRecodableHandler(Player player) { }

	private void OnPlayerConnectOrReconnect() { }

	public void OnPlayerRemoveRecodableHandler() { }

	private void OnStartSession() { }

	private void RecalculatePlayerRadioTransmitterState() { }

	private void RecalculateStatuses() { }

	private void RecalculateTeammatesRadioTransmitterState() { }

	public void ReInitInOfflineGame(RadioTransmitterRecodableComponent radioTransmitterRecodableComponent, LocalPlayer player) { }

	[CompilerGenerated]
	public void remove_OnAllTeammatesChangeRadioTransmitterStatus(Action value) { }

	[CompilerGenerated]
	public void remove_OnStatusChanged(Action value) { }

	private void SendClientRadioTransmitterState() { }

	private void SendObserverRadioTransmitterStateForAll() { }

	private void SendRadioTransmitterDataToClient() { }

	public void SetEncoded(bool isEncoded) { }

	private void SetInitialRadioTransmitterState() { }

	private void SetInitialStatus() { }

	private void SetPlayer(Player player) { }

	private void SetRecodableComponent(RadioTransmitterRecodableComponent recodableComponent) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

