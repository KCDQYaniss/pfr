//Type is in global namespace

public class SimpleSparksAdapter : Emitter
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

	private const int Count = 128; //Field offset: 0x0
	private const float Step = 0.0078125; //Field offset: 0x0
	public SimpleSparksRenderer SimpleSparksObject; //Field offset: 0x20
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue LifetimeCurve; //Field offset: 0x28
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue SpeedCurve; //Field offset: 0x30
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue GravityCurve; //Field offset: 0x38
	[UberDraw("Curve 240;Value 60", True)]
	public CurveValue DragCurve; //Field offset: 0x40
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue EmissionCurve; //Field offset: 0x48
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue SizeCurve; //Field offset: 0x50
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue TurbulenceAmplitudeCurve; //Field offset: 0x58
	[UberDraw("Curve 240;Value 120 S 0 255", True)]
	public ByteCurveValue TurbulenceFrequencyCurve; //Field offset: 0x60
	public float EmissionTimeShift; //Field offset: 0x68

	public SimpleSparksAdapter() { }

	private void Awake() { }

	public virtual void Emit(Vector3 pos, Vector3 vel) { }

	private static float LimitDrag(float val) { }

	private void OnValidate() { }

}

