//Type is in global namespace

public class MuzzleSparks : MonoBehaviour
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__LimitDrag; //Field offset: 0x0

	}

	internal class ByteCurveValue
	{
		public AnimationCurve Curve; //Field offset: 0x10
		public byte Value; //Field offset: 0x18
		public byte[] Values; //Field offset: 0x20

		public ByteCurveValue() { }

		public void RecalcVals(Func func) { }

		public void RecalcVals() { }

	}

	internal class CurveValue
	{
		public AnimationCurve Curve; //Field offset: 0x10
		public float Value; //Field offset: 0x18
		public float[] Values; //Field offset: 0x20

		public CurveValue() { }

		public void RecalcVals(Func func) { }

		public void RecalcVals() { }

	}

	private const float Step = 0.0078125; //Field offset: 0x0
	private const int Count = 128; //Field offset: 0x0
	public float StartPos; //Field offset: 0x20
	public float EmitterRadius; //Field offset: 0x24
	public float ConusSize; //Field offset: 0x28
	public int CountMin; //Field offset: 0x2C
	public int CountRange; //Field offset: 0x30
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue LifetimeCurve; //Field offset: 0x38
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue SpeedCurve; //Field offset: 0x40
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue GravityCurve; //Field offset: 0x48
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue DragCurve; //Field offset: 0x50
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue EmissionCurve; //Field offset: 0x58
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue SizeCurve; //Field offset: 0x60
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue TurbulenceAmplitudeCurve; //Field offset: 0x68
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue TurbulenceFrequencyCurve; //Field offset: 0x70
	public float EmissionTimeShift; //Field offset: 0x78
	private Transform _transform; //Field offset: 0x80

	public MuzzleSparks() { }

	private void Awake() { }

	public void Emit(ISparksEmitter emitter) { }

	private static float LimitDrag(float val) { }

	private void OnEnabled() { }

	private void OnValidate() { }

}

