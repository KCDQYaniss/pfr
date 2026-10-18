//Type is in global namespace

public class AIPlaceLogicMultipleCores : AIPlaceInfoLogic
{
	[SerializeField]
	private EAIPlaceMultipleCoresMarker _marker; //Field offset: 0x20
	[SerializeField]
	private List _corePoints; //Field offset: 0x28
	private AIPlaceInfo _placeInfo; //Field offset: 0x30
	private bool[] _occupied; //Field offset: 0x38

	public EAIPlaceMultipleCoresMarker Marker
	{
		 get { } //Length: 4
	}

	public int PlaceId
	{
		 get { } //Length: 235
	}

	public AIPlaceLogicMultipleCores() { }

	[ContextMenu("Collect Child AIPlaceCorePointMarker")]
	public void CollectChildCorePointMarkers() { }

	public virtual void EditorCheck() { }

	public virtual void EditorCheck(AIPlaceInfo aIPlace) { }

	private void EnsureOccupiedArray() { }

	public EAIPlaceMultipleCoresMarker get_Marker() { }

	public int get_PlaceId() { }

	public float GetSqrDistanceTo(Vector3 from) { }

	public bool HasMarker(EAIPlaceMultipleCoresMarker marker) { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnDrawGizmosSelected() { }

	public bool TryTakeFreePoint(Vector3 from, float maxDist, int personsCount, out Vector3 position, out bool isIndoor) { }

	private void ValidateCorePoints(AIPlaceInfo placeInfo) { }

}

