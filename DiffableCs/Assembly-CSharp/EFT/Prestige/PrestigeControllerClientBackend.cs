namespace EFT.Prestige;

public sealed class PrestigeControllerClientBackend : PrestigeControllerClient
{
	private readonly QuestBook _questBook; //Field offset: 0x68
	private ConditionsConnectorsManagerPrestigeClientBackend _conditionsConnectorsManagerPrestigeClientBackend; //Field offset: 0x70

	public virtual bool CanUpgrade
	{
		 get { } //Length: 3
	}

	public ConditionsConnectorsManagerPrestigeClientBackend ConditionsConnectorsManagerPrestigeClientBackend
	{
		 get { } //Length: 5
		 set { } //Length: 228
	}

	public PrestigeControllerClientBackend(Profile profile, InventoryController inventoryController, QuestBook questBook, IQuestSession session) { }

	protected virtual void AddQuestNote(PrestigeLevel conditional, Condition condition, QuestNoteTemplate noteTemplate) { }

	public virtual bool get_CanUpgrade() { }

	public ConditionsConnectorsManagerPrestigeClientBackend get_ConditionsConnectorsManagerPrestigeClientBackend() { }

	protected virtual void InitConditionsConnectorsManager() { }

	public void set_ConditionsConnectorsManagerPrestigeClientBackend(ConditionsConnectorsManagerPrestigeClientBackend value) { }

}

