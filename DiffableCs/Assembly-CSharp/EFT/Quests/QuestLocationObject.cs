namespace EFT.Quests;

public abstract class QuestLocationObject : MonoBehaviour, IQuestObject
{
	[SerializeField]
	private string _id; //Field offset: 0x20
	[SerializeField]
	private string _questTemplateId; //Field offset: 0x28
	[SerializeField]
	private string _conditionId; //Field offset: 0x30
	private Nullable _conditionMongoId; //Field offset: 0x38
	protected int _netId; //Field offset: 0x58

	public override string ConditionId
	{
		 get { } //Length: 76
	}

	public GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override string Id
	{
		 get { } //Length: 5
	}

	public override int NetworkId
	{
		 get { } //Length: 4
	}

	public override string QuestTemplateId
	{
		 get { } //Length: 5
	}

	protected QuestLocationObject() { }

	public int BuildNetId() { }

	public override string get_ConditionId() { }

	public GameObject get_GameObject() { }

	public override string get_Id() { }

	public override int get_NetworkId() { }

	public override string get_QuestTemplateId() { }

	public override void SetQuestObjectActiveState(bool state) { }

	public bool TryGetConditionMongoId(out MongoID id) { }

}

