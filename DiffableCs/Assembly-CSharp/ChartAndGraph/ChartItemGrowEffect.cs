namespace ChartAndGraph;

internal class ChartItemGrowEffect : ChartItemEffect
{
	private const int NoOp = 0; //Field offset: 0x0
	private const int GrowOp = 1; //Field offset: 0x0
	private const int ShrinkOp = 2; //Field offset: 0x0
	private const int GrowShrinkOp = 3; //Field offset: 0x0
	public float GrowMultiplier; //Field offset: 0x38
	public bool VerticalOnly; //Field offset: 0x3C
	public float TimeScale; //Field offset: 0x40
	public AnimationCurve GrowEaseFunction; //Field offset: 0x48
	public AnimationCurve ShrinkEaseFunction; //Field offset: 0x50
	private float mScaleMultiplier; //Field offset: 0x58
	private float mStartTime; //Field offset: 0x5C
	private float mStartValue; //Field offset: 0x60
	private int Operation; //Field offset: 0x64
	private bool mDeactivateOnEnd; //Field offset: 0x68

	internal virtual Quaternion Rotation
	{
		internal get { } //Length: 71
	}

	internal virtual Vector3 ScaleMultiplier
	{
		internal get { } //Length: 50
	}

	internal virtual Vector3 Translation
	{
		internal get { } //Length: 79
	}

	public ChartItemGrowEffect() { }

	public bool CheckAnimationEnded(float time, AnimationCurve curve) { }

	private void FixEaseFunction(AnimationCurve curve) { }

	internal virtual Quaternion get_Rotation() { }

	internal virtual Vector3 get_ScaleMultiplier() { }

	internal virtual Vector3 get_Translation() { }

	public void Grow() { }

	public void GrowAndShrink() { }

	public void Shrink() { }

	public virtual void TriggerIn(bool deactivateOnEnd) { }

	public virtual void TriggerOut(bool deactivateOnEnd) { }

	private void Update() { }

}

