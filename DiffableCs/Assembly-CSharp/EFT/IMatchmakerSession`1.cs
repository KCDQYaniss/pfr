namespace EFT;

public interface IMatchmakerSession`1 : IProfileSession, IBackendSession
{

	public DateTime GetCurrentLocationTime
	{
		 get { } //Length: 0
	}

	public WeatherNode Weather
	{
		 get { } //Length: 0
	}

	public void AcceptGroupInvite(string requestId, Callback callback) { }

	public Task CancelAllInvites() { }

	public void CancelInvite(string requestId, Callback callback) { }

	public void DeclineGroupInvite(string requestId, Callback callback) { }

	public void DisbandRaidGroup(Callback callback) { }

	public Task ExitFromMatchmakerGroupMenu() { }

	public DateTime get_GetCurrentLocationTime() { }

	public WeatherNode get_Weather() { }

	public void GetGroupStatus(Callback callback) { }

	public void GetRaidReadyStatus(object readyStatusParams, Callback callback) { }

	public Task LeaveMatchmakerGroup() { }

	public void RemovePlayerFromGroup(string profileAid, Callback callback) { }

	public void SendGroupInvite(string accountId, bool inLobby, Callback callback) { }

	public Task SendRaidSettings(TRaidSettings raidSettings) { }

	public void SetNotReadyReadyStatus(Callback callback) { }

	public void SetReadyRaidStatus(Callback callback) { }

	public Task StartLookingForGroup() { }

	public Task StopLookingForGroup() { }

	public void TransferGroupLeadership(string profileAid, Callback callback) { }

}

