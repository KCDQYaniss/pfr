//Type is in global namespace

public class AIDangerPlacesHolder : MonoBehaviour
{
	[SerializeField]
	public List PlacesToAvoid; //Field offset: 0x20
	public bool AlwaysDraw; //Field offset: 0x28

	public AIDangerPlacesHolder() { }

	private void DrawGizmos() { }

	public void InGameRestore(AICoversData data) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

}

