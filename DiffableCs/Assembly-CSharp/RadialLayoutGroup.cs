//Type is in global namespace

public class RadialLayoutGroup : LayoutGroup
{
	[SerializeField]
	private float _fDistance; //Field offset: 0x60
	[Range(0, 360)]
	[SerializeField]
	private float _minAngle; //Field offset: 0x64
	[Range(0, 360)]
	[SerializeField]
	private float _maxAngle; //Field offset: 0x68
	[Range(0, 360)]
	public float StartAngle; //Field offset: 0x6C

	public RadialLayoutGroup() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	private void CalculateRadial() { }

	protected virtual void OnEnable() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

