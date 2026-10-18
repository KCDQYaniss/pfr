namespace Dissonance.Datastructures;

internal class WindowDeviationCalculator : BaseWindowCalculator
{
	private float _sum; //Field offset: 0x18
	private float _sumOfSquares; //Field offset: 0x1C
	[CompilerGenerated]
	private float <StdDev>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <Mean>k__BackingField; //Field offset: 0x24

	public float Confidence
	{
		 get { } //Length: 108
	}

	public private float Mean
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float StdDev
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public WindowDeviationCalculator(uint size) { }

	private float CalculateDeviation(float mean, float meanOfSquares) { }

	public virtual void Clear() { }

	public float get_Confidence() { }

	[CompilerGenerated]
	public float get_Mean() { }

	[CompilerGenerated]
	public float get_StdDev() { }

	[CompilerGenerated]
	private void set_Mean(float value) { }

	[CompilerGenerated]
	private void set_StdDev(float value) { }

	protected virtual void Updated(Nullable removed, float added) { }

}

