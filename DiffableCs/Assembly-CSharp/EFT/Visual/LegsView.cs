namespace EFT.Visual;

public class LegsView : MonoBehaviour
{
	[SerializeField]
	private bool _isRightLeg; //Field offset: 0x20
	[SerializeField]
	private Transform _holster; //Field offset: 0x28

	public bool IsRightLegHolster
	{
		 get { } //Length: 5
	}

	public LegsView() { }

	public bool get_IsRightLegHolster() { }

	public void SetHolster(PlayerBody playerBody) { }

}

