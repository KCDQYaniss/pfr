namespace EFT.Hideout;

public class ImprovementController : IUpdate
{
	private List _areas; //Field offset: 0x10
	private List _improvements; //Field offset: 0x18
	private Dictionary _improvementDataBy; //Field offset: 0x20

	public ImprovementController() { }

	public void SetImprovementDataset(Dictionary improvements) { }

	public void SetImprovements(AreaData area) { }

	public override void Update(float deltaTime) { }

	public void UpdateImprovement(Improvement improvement) { }

	public void UpdateImprovementData(string id, ImprovementData improvement) { }

	public void UpdateImprovementDataset(Dictionary improvements) { }

	public void UpdateImprovements() { }

}

