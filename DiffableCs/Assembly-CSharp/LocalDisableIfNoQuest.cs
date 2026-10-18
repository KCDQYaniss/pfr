//Type is in global namespace

public class LocalDisableIfNoQuest : MonoBehaviour
{
	[SerializeField]
	private GameObject[] disableObjects; //Field offset: 0x20
	[SerializeField]
	private MonoBehaviour[] disableBehaviours; //Field offset: 0x28
	[SerializeField]
	private string _questTemplateId; //Field offset: 0x30
	[SerializeField]
	private EQuestStatus[] _suitableQuestStatuses; //Field offset: 0x38

	public LocalDisableIfNoQuest() { }

	private bool IsQuestRequirementMet() { }

	private bool IsSuitableStatus(EQuestStatus questStatus) { }

	private void OnDestroy() { }

	private void OnRaidStarted() { }

	private void Start() { }

}

