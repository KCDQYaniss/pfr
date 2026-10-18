//Type is in global namespace

public class SpotLightFakeGI : MonoBehaviour
{
	internal class Circle
	{
		[Range(0, 1)]
		public float Radius; //Field offset: 0x10
		public int Count; //Field offset: 0x14

		public Circle() { }

	}

	public float GILightOffsetA; //Field offset: 0x20
	public float GILightOffsetB; //Field offset: 0x24
	public float GILightScale; //Field offset: 0x28
	public float GILightIntensity; //Field offset: 0x2C
	public LayerMask CheckLayerMask; //Field offset: 0x30
	public Circle[] CheckCircles; //Field offset: 0x38
	public AnimationCurve GIIntensityByDistanceMultyplier; //Field offset: 0x40

	public SpotLightFakeGI() { }

}

