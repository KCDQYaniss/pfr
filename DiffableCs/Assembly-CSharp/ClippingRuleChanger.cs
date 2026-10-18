//Type is in global namespace

public class ClippingRuleChanger : MonoBehaviour
{
	[SerializeField]
	private EClippingCustoms _clippingCustoms; //Field offset: 0x20

	public EClippingCustoms GetClippingCustoms
	{
		 get { } //Length: 5
	}

	public ClippingRuleChanger() { }

	public EClippingCustoms get_GetClippingCustoms() { }

}

