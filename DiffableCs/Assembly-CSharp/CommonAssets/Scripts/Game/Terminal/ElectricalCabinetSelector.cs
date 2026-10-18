namespace CommonAssets.Scripts.Game.Terminal;

public sealed class ElectricalCabinetSelector : MonoBehaviour
{
	internal class GroupSizeConfiguration
	{
		[SerializeField]
		public int MaxGroupSize; //Field offset: 0x10
		[SerializeField]
		public List AvailableCabinets; //Field offset: 0x18
		[SerializeField]
		public int CabinetsToBreak; //Field offset: 0x20

		public GroupSizeConfiguration() { }

	}

	private const string CUTSCENE_ID = "Final_trkv_2"; //Field offset: 0x0
	[SerializeField]
	private List _groupConfigurations; //Field offset: 0x20
	[SerializeField]
	private HandlerAndExpandable _handlerAndExpandable; //Field offset: 0x28
	private Action _unsubscribeAction; //Field offset: 0x30

	public ElectricalCabinetSelector() { }

	private GroupSizeConfiguration GetConfigurationForGroupSize(int maxGroupSize) { }

	private int GetMaxGroupSize() { }

	private List SelectCabinetsToBreak(GroupSizeConfiguration configuration) { }

	private void SetupCabinets() { }

	private void Start() { }

	private void WaitForGameStart(CutSceneEndEvent endEvent) { }

}

