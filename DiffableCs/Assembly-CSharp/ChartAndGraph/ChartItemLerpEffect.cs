namespace ChartAndGraph;

public abstract class ChartItemLerpEffect : ChartItemEffect
{
	private const int NoOp = 0; //Field offset: 0x0
	private const int GrowOp = 1; //Field offset: 0x0
	private const int ShrinkOp = 2; //Field offset: 0x0
	private const int GrowShrinkOp = 3; //Field offset: 0x0
	public float TimeScale; //Field offset: 0x38
	public AnimationCurve GrowEaseFunction; //Field offset: 0x40
	public AnimationCurve ShrinkEaseFunction; //Field offset: 0x48
	private float mStartTime; //Field offset: 0x50
	private float mStartValue; //Field offset: 0x54
	private int Operation; //Field offset: 0x58
	private bool mDeactivateOnEnd; //Field offset: 0x5C

	protected ChartItemLerpEffect() { }

	protected abstract void ApplyLerp(float value) { }

	public bool CheckAnimationEnded(float time, AnimationCurve curve) { }

	private void FixEaseFunction(AnimationCurve curve) { }

	protected abstract float GetStartValue() { }

	public void Grow() { }

	public void GrowAndShrink() { }

	public void Shrink() { }

	protected virtual void Start() { }

	public virtual void TriggerIn(bool deactivateOnEnd) { }

	public virtual void TriggerOut(bool deactivateOnEnd) { }

	private void Update() { }

}

