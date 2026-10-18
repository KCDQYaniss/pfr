namespace EFT.Repairing;

public interface IRepairController
{

	public RepairController RepairController
	{
		 get { } //Length: 0
	}

	public RepairController get_RepairController() { }

	public Task RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItemId) { }

}

