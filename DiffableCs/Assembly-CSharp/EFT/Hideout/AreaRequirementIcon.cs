namespace EFT.Hideout;

public sealed class AreaRequirementIcon : AreaIcon
{
	private AreaRequirement _requirement; //Field offset: 0x158

	public AreaRequirementIcon() { }

	protected virtual void SetLevel() { }

	protected virtual void SetStatus() { }

	public void Show(AreaData data, AreaRequirement requirement) { }

}

