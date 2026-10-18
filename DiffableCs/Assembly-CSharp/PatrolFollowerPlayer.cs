//Type is in global namespace

public class PatrolFollowerPlayer : BotData
{
	private const float POSIBLE_OFFSET = 5.2; //Field offset: 0x0
	private const float SHALL_RUN = 10.5; //Field offset: 0x0
	private const float TARGET_DIST = 3.5; //Field offset: 0x0
	private float _nextGetPlayerPos; //Field offset: 0x18
	private float _nextInnerPos; //Field offset: 0x1C
	private readonly Player _player; //Field offset: 0x20
	private Vector3 lastSelectedPoint; //Field offset: 0x28
	private bool shalGoToCover; //Field offset: 0x34
	private bool _prevWasClose; //Field offset: 0x35

	public PatrolFollowerPlayer(Player player, BotOwner owner) { }

	private NavMeshPathStatus GoTo(Vector3 v) { }

	private void TryGoToPlayer() { }

	public void Update() { }

}

