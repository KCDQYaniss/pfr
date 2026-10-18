namespace EFT;

public interface INetworkGameSession : IAbstractSession
{

	public bool ObserveOnly
	{
		 get { } //Length: 0
	}

	public void CmdConfirmQuestTemplates(string playerProfileID, string error) { }

	public void CmdGetRadiotransmitterData(string playerProfileID) { }

	public void CmdGetTraderServicesData(string playerProfileID, string traderId) { }

	public void GameStarted() { }

	public bool get_ObserveOnly() { }

	public void OnPlayerNpcStatisticsChanged(string playerProfileID, string statisticsType, int valueToSet) { }

	public void PlayerEffectsPause(string playerProfileID, bool isPaused) { }

	public void PrepareForPostRaid(float disconnectDelay) { }

	public void ReportVoipAbuse() { }

	public void Respawn() { }

	public void RestartGame() { }

	public void RestartGameInitiate() { }

	public void Spawn() { }

	public void StartGame() { }

	public void StartGameAfterTeleport() { }

	public void StopGame() { }

}

