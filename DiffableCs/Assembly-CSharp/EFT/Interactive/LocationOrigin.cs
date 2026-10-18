namespace EFT.Interactive;

[DisallowMultipleComponent]
public sealed class LocationOrigin : MonoBehaviour
{
	[SerializeField]
	private List _locations; //Field offset: 0x20

	public LocationOrigin() { }

	public bool ContainLocation(string location) { }

	public float GetDistanceSqr(Vector3 position) { }

}

