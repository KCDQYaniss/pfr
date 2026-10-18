//Type is in global namespace

public class AIPlaceInfoLogicStopAllWaitLayers : AIPlaceInfo
{
	public float Radius; //Field offset: 0x88
	public List PlacesToStop; //Field offset: 0x90
	private bool _isRaised; //Field offset: 0x98

	public AIPlaceInfoLogicStopAllWaitLayers() { }

	private int DeactivatedBots(List bots, int deactivated) { }

	private void OnDrawGizmosSelected() { }

	protected virtual void OnEnterPlace(Player player) { }

	public void StopWait(Player player) { }

}

