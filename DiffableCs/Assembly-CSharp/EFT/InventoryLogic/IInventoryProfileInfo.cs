namespace EFT.InventoryLogic;

public interface IInventoryProfileInfo
{

	public event Action OnCompletableItemValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IReadOnlyDictionary CompletableItems
	{
		 get { } //Length: 0
	}

	public int Experience
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Inventory InventoryInfo
	{
		 get { } //Length: 0
	}

	public int MagDrillsMastering
	{
		 get { } //Length: 0
	}

	public string Nickname
	{
		 get { } //Length: 0
	}

	public string ProfileId
	{
		 get { } //Length: 0
	}

	public EPlayerSide Side
	{
		 get { } //Length: 0
	}

	public IInventoryProfileSkillInfo SkillsInfo
	{
		 get { } //Length: 0
	}

	public Dictionary TradersInfo
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnCompletableItemValueChanged(Action value) { }

	public void AddToCarriedQuestItems(string itemTemplateId) { }

	public void CheckChamber(MongoID weaponId) { }

	public void CheckMagazines(MongoID magazineId, int value) { }

	public int CheckMagazinesValue(MongoID magazineId) { }

	public bool Examined(Item item) { }

	public bool Examined(MongoID templateId) { }

	public bool ForgetInEncyclopedia(MongoID itemId) { }

	public IReadOnlyDictionary get_CompletableItems() { }

	public int get_Experience() { }

	public Inventory get_InventoryInfo() { }

	public int get_MagDrillsMastering() { }

	public string get_Nickname() { }

	public string get_ProfileId() { }

	public EPlayerSide get_Side() { }

	public IInventoryProfileSkillInfo get_SkillsInfo() { }

	public Dictionary get_TradersInfo() { }

	public bool IsCheckedChambers(MongoID weaponId) { }

	public bool IsCheckedMagazines(MongoID magazineId) { }

	public void LearnInEncyclopedia(MongoID itemId) { }

	[CompilerGenerated]
	public void remove_OnCompletableItemValueChanged(Action value) { }

	public void set_Experience(int value) { }

	public IResult SetCompletableItemValue(MongoID completableItem, bool completed, bool force = false) { }

	public void UnCheckChamber(MongoID weaponId) { }

	public void UnCheckMagazines(MongoID magazineId) { }

}

