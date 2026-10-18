namespace EFT.PrefabSettings;

public sealed class TripwireVisual : MonoBehaviour
{
	[SerializeField]
	private Transform _pivotPosition; //Field offset: 0x20
	[SerializeField]
	private GameObject _grenadeModel; //Field offset: 0x28

	public GameObject GrenadeModel
	{
		 get { } //Length: 5
	}

	public Transform PivotPosition
	{
		 get { } //Length: 5
	}

	public TripwireVisual() { }

	public GameObject get_GrenadeModel() { }

	public Transform get_PivotPosition() { }

}

