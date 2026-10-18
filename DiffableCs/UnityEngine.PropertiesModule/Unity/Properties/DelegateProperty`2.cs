namespace Unity.Properties;

public class DelegateProperty`2 : Property
{
	private readonly PropertyGetter m_Getter; //Field offset: 0x0
	private readonly PropertySetter m_Setter; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x0

	public virtual string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DelegateProperty`2(string name, PropertyGetter getter, PropertySetter setter = null) { }

	[CompilerGenerated]
	public virtual string get_Name() { }

}

