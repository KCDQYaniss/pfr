//Type is in global namespace

public class AIPlaceLogicEventRaiseByGroupSize : AIPlaceInfoLogic
{
	[Tooltip("Нижняя граница диапазона, который EditorCheck старается полностью покрыть правилами.")]
	public int CoverageMin; //Field offset: 0x20
	[Tooltip("Верхняя граница диапазона для автозаполнения в EditorCheck.")]
	public int CoverageMax; //Field offset: 0x24
	public List Rules; //Field offset: 0x28
	public bool EnterRaise; //Field offset: 0x30
	public bool ExitRaise; //Field offset: 0x31
	public bool OnlyPlayerNotAI; //Field offset: 0x32
	private bool _isEventRaised; //Field offset: 0x33
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x38

	public AIPlaceLogicEventRaiseByGroupSize() { }

	private int CountPlayersWithSameGroup(Player reference) { }

	public virtual void Dispose() { }

	public virtual void EditorCheck() { }

	private AIPlaceGroupSizeEventRule FindRuleForCount(int count) { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void NormalizeRulesInPlace() { }

	private void OnPlayerEnter(Player player) { }

	private void OnPlayerExit(Player player) { }

	private void TryRaiseForPlayer(Player player) { }

}

