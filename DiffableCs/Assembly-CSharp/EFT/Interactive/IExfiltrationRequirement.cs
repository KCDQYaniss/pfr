namespace EFT.Interactive;

public interface IExfiltrationRequirement
{

	public void Enter(Player player, ExfiltrationPoint point) { }

	public void Exit(Player player, ExfiltrationPoint point) { }

	public bool Met(Player player, ExfiltrationPoint point) { }

	public void OnDestroy() { }

	public void Start(ExfiltrationPoint point) { }

}

