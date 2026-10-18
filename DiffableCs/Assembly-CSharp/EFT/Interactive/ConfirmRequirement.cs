namespace EFT.Interactive;

public sealed class ConfirmRequirement : TransitRequirement
{

	public virtual bool IsEntryStage
	{
		 get { } //Length: 3
	}

	public ConfirmRequirement() { }

	public virtual bool get_IsEntryStage() { }

}

