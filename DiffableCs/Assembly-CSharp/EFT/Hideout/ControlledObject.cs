namespace EFT.Hideout;

public abstract class ControlledObject
{
	[CompilerGenerated]
	private bool <MainObject>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AmbianceAffectedObjects <Parent>k__BackingField; //Field offset: 0x18

	public bool MainObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public AmbianceAffectedObjects Parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected ControlledObject() { }

	public abstract void Destroy() { }

	public abstract void Disable() { }

	[CompilerGenerated]
	public bool get_MainObject() { }

	[CompilerGenerated]
	public AmbianceAffectedObjects get_Parent() { }

	public abstract void PerformTransition() { }

	[CompilerGenerated]
	public void set_MainObject(bool value) { }

	[CompilerGenerated]
	public void set_Parent(AmbianceAffectedObjects value) { }

}

