namespace EFT.Interactive;

public interface ITransitRequirement
{

	public bool IsEntryStage
	{
		 get { } //Length: 0
	}

	public bool get_IsEntryStage() { }

	public string GetLocalizedTip() { }

	public bool Met(Player player) { }

}

