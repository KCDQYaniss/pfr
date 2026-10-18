namespace JetBrains.Annotations;

[AttributeUsage(18436)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly ImplicitUseKindFlags <UseKindFlags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly ImplicitUseTargetFlags <TargetFlags>k__BackingField; //Field offset: 0x14

	public MeansImplicitUseAttribute() { }

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags) { }

}

