//Type is in global namespace

public class GroupLabels : ItemLabelsBase
{
	[SerializeField]
	[Tooltip("Detemines the alignment of the group labels")]
	private GroupLabelAlignment alignment; //Field offset: 0x60

	public GroupLabelAlignment Alignment
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	protected virtual Action Assign
	{
		 get { } //Length: 113
	}

	public GroupLabels() { }

	[CompilerGenerated]
	private void <get_Assign>b__5_0(IInternalUse x, bool clear) { }

	public GroupLabelAlignment get_Alignment() { }

	protected virtual Action get_Assign() { }

	public void set_Alignment(GroupLabelAlignment value) { }

}

