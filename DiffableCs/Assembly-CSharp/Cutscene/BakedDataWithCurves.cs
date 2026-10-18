namespace Cutscene;

[CreateAssetMenu(menuName = "uLipSync/Backed data with curves")]
public class BakedDataWithCurves : BakedData
{
	internal class CurveData
	{
		public bool isBlendShape; //Field offset: 0x10
		public int blendShapeIndex; //Field offset: 0x14
		public string paramName; //Field offset: 0x18
		public AnimationCurve curve; //Field offset: 0x20
		public float resetValue; //Field offset: 0x28

		public CurveData() { }

	}

	[SerializeField]
	public List curves; //Field offset: 0x48

	public BakedDataWithCurves() { }

}

