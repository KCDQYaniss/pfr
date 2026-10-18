namespace Prism.Utils;

public class PrismAnimCurveCreator : MonoBehaviour
{
	public float[] curvePointsX; //Field offset: 0x20
	public float[] curvePointsY; //Field offset: 0x28
	public AnimationCurve thisCurve; //Field offset: 0x30

	public PrismAnimCurveCreator() { }

	[ContextMenu("Generate curve")]
	private void GenerateCurve() { }

}

