namespace UnityEngine.Rendering.PostProcessing;

public sealed class Spline
{
	public const int k_Precision = 128; //Field offset: 0x0
	public const float k_Step = 0.0078125; //Field offset: 0x0
	public AnimationCurve curve; //Field offset: 0x10
	[SerializeField]
	private bool m_Loop; //Field offset: 0x18
	[SerializeField]
	private float m_ZeroValue; //Field offset: 0x1C
	[SerializeField]
	private float m_Range; //Field offset: 0x20
	private AnimationCurve m_InternalLoopingCurve; //Field offset: 0x28
	private int frameCount; //Field offset: 0x30
	public float[] cachedData; //Field offset: 0x38

	public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	public void Cache(int frame) { }

	public float Evaluate(float t, int length) { }

	public float Evaluate(float t) { }

	public virtual int GetHashCode() { }

}

