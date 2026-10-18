//Type is in global namespace

public class TwoValueBar : MonoBehaviour
{
	[SerializeField]
	private RectTransform _baseFill; //Field offset: 0x20
	[SerializeField]
	private RectTransform _newFill; //Field offset: 0x28
	[SerializeField]
	private RectTransform _newGlow; //Field offset: 0x30
	[SerializeField]
	private float _spacing; //Field offset: 0x38
	private float _effectiveSpacing; //Field offset: 0x3C

	public TwoValueBar() { }

	public void SetBase(float value) { }

	public void SetNew(float value) { }

}

