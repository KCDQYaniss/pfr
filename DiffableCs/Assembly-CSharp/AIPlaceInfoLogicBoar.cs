//Type is in global namespace

public class AIPlaceInfoLogicBoar : AIPlaceInfoLogic
{
	public bool PermanentVision; //Field offset: 0x20
	public List PossiblePositions; //Field offset: 0x28
	private Nullable _cacheProperty; //Field offset: 0x30

	public Vector3 Position
	{
		 get { } //Length: 289
	}

	public AIPlaceInfoLogicBoar() { }

	public Vector3 get_Position() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnDrawGizmosSelected() { }

}

