namespace EFT.GameTriggers;

public class LocalClientTriggersModule : TriggersModule
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Awake>b__4_0(WorldInteractiveObject wio) { }

		internal WorldInteractiveObject <Awake>b__4_1(WorldInteractiveObject wio) { }

	}

	private Dictionary _worldInteractiveObjects; //Field offset: 0x28

	public LocalClientTriggersModule() { }

	public virtual bool ApplyDamage(int playerRaidId, DamageData[] damageData) { }

	private void Awake() { }

	public virtual void Interact(WorldInteractiveObject worldInteractiveObject, EInteractionType interactionType, int profileId) { }

	public virtual void Interact(string interactableId, EInteractionType interactionType, int playerRaidId) { }

	protected virtual bool TryFindInteractiveObject(string id, out WorldInteractiveObject result) { }

	public virtual bool TryFindInventoryController(int playerRaidId, out InventoryController inventoryController) { }

	protected virtual bool TryFindSkillManager(int playerRaidId, out SkillManager result) { }

	public virtual bool TryGetHealthsController(int playerRaidId, out ActiveHealthController healthController) { }

	private bool TryGetPlayer(int playerRaidId, out Player player) { }

	public virtual bool TryGetQuestController(int playerRaidId, out QuestController questController) { }

	protected virtual IEnumerable WorldInteractiveObjects() { }

}

