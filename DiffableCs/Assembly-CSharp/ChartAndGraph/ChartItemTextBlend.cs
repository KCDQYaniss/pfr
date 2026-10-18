namespace ChartAndGraph;

internal class ChartItemTextBlend : ChartItemLerpEffect
{
	private Text mText; //Field offset: 0x60
	private Shadow[] mShadows; //Field offset: 0x68
	private Dictionary mInitialValues; //Field offset: 0x70
	private CanvasRenderer mRenderer; //Field offset: 0x78

	internal virtual Quaternion Rotation
	{
		internal get { } //Length: 71
	}

	internal virtual Vector3 ScaleMultiplier
	{
		internal get { } //Length: 24
	}

	internal virtual Vector3 Translation
	{
		internal get { } //Length: 79
	}

	public ChartItemTextBlend() { }

	protected virtual void ApplyLerp(float value) { }

	private CanvasRenderer EnsureRenderer() { }

	internal virtual Quaternion get_Rotation() { }

	internal virtual Vector3 get_ScaleMultiplier() { }

	internal virtual Vector3 get_Translation() { }

	protected virtual float GetStartValue() { }

	protected virtual void Start() { }

}

