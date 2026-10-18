namespace EFT.Interactive;

public class TransitRequirement : ITransitRequirement
{
	public string RequirementTip; //Field offset: 0x10

	public override bool IsEntryStage
	{
		 get { } //Length: 3
	}

	public TransitRequirement() { }

	public override bool get_IsEntryStage() { }

	public override string GetLocalizedTip() { }

	public override bool Met(Player player) { }

}

