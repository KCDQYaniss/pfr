namespace ChartAndGraph;

public class ItemLabels : AlignedItemLabels
{
	[Range(0, 7)]
	[SerializeField]
	private int fractionDigits; //Field offset: 0x68

	protected virtual Action Assign
	{
		 get { } //Length: 113
	}

	public int FractionDigits
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	public ItemLabels() { }

	[CompilerGenerated]
	private void <get_Assign>b__5_0(IInternalUse x, bool clear) { }

	protected virtual Action get_Assign() { }

	public int get_FractionDigits() { }

	public void set_FractionDigits(int value) { }

}

