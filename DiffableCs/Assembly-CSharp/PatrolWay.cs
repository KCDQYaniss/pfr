//Type is in global namespace

public class PatrolWay : MonoBehaviour
{
	public PatrolType PatrolType; //Field offset: 0x20
	public List Points; //Field offset: 0x28
	[SerializeField]
	private int _maxPersons; //Field offset: 0x30
	private HashSet _users; //Field offset: 0x38
	public float CoefSubPoints; //Field offset: 0x40

	public int MaxPersons
	{
		 get { } //Length: 4
	}

	private Vector3 MiddlePos
	{
		private get { } //Length: 586
	}

	public PatrolWay() { }

	public void AddUser(BotOwner owner) { }

	public string AllUsersDebugIdInfo() { }

	public string AllUsersDebugIdInfoRole() { }

	public bool CanBeUsedByRole(WildSpawnType settingsRole) { }

	public void EditorInitPoints() { }

	public int get_MaxPersons() { }

	private Vector3 get_MiddlePos() { }

	public PatrolPoint GetNearestPatrolPoint(Vector3 point, out float sqrDistance) { }

	public bool HaveFreeSpace(BotOwner exeptBot) { }

	public bool HaveFreeSpace() { }

	public void InitPoints() { }

	public bool IsCloseToSelect(BotOwner owner, float closeToSelectReservWay) { }

	public void RemoveMe(BotOwner owner) { }

	public override bool Suitable(BotOwner bot, IGetProfileData data) { }

	public override string SuitableData() { }

	public int UsersCount() { }

}

