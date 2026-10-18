namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerInventoryInfo : IInventoryProfileInfo
{
	private class ObservedProfileSkillInfo : IInventoryProfileSkillInfo
	{

		public override float AttentionEliteLuckySearchValue
		{
			 get { } //Length: 4
		}

		public override float AttentionExamineValue
		{
			 get { } //Length: 4
		}

		public override float AttentionLootSpeedValue
		{
			 get { } //Length: 4
		}

		public override bool IsMagDrillsInstantCheck
		{
			 get { } //Length: 3
		}

		public override bool IsSearchDouble
		{
			 get { } //Length: 3
		}

		public override bool IsTroubleFixingExamineMalfElite
		{
			 get { } //Length: 3
		}

		public override int MagDrillsLevel
		{
			 get { } //Length: 3
		}

		public override float SearchBuffSpeedValue
		{
			 get { } //Length: 4
		}

		public ObservedProfileSkillInfo() { }

		public override float get_AttentionEliteLuckySearchValue() { }

		public override float get_AttentionExamineValue() { }

		public override float get_AttentionLootSpeedValue() { }

		public override bool get_IsMagDrillsInstantCheck() { }

		public override bool get_IsSearchDouble() { }

		public override bool get_IsTroubleFixingExamineMalfElite() { }

		public override int get_MagDrillsLevel() { }

		public override float get_SearchBuffSpeedValue() { }

	}

	[CompilerGenerated]
	private Action OnCompletableItemValueChanged; //Field offset: 0x10
	[CompilerGenerated]
	private Inventory <InventoryInfo>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IInventoryProfileSkillInfo <SkillsInfo>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Experience>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly int <MagDrillsMastering>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private readonly Dictionary <TradersInfo>k__BackingField; //Field offset: 0x30
	private readonly ObservedPlayerInfoContainer _infoContainer; //Field offset: 0x38

	public override event Action OnCompletableItemValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override IReadOnlyDictionary CompletableItems
	{
		 get { } //Length: 3
	}

	public override int Experience
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private override Inventory InventoryInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override int MagDrillsMastering
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override string Nickname
	{
		 get { } //Length: 27
	}

	public override string ProfileId
	{
		 get { } //Length: 27
	}

	public override EPlayerSide Side
	{
		 get { } //Length: 26
	}

	public override IInventoryProfileSkillInfo SkillsInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Dictionary TradersInfo
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public ObservedPlayerInventoryInfo(ObservedPlayerInfoContainer infoContainer, Inventory inventory) { }

	[CompilerGenerated]
	public override void add_OnCompletableItemValueChanged(Action value) { }

	public override void AddToCarriedQuestItems(string itemTemplateId) { }

	public override void CheckChamber(MongoID weaponId) { }

	public override void CheckMagazines(MongoID magazineId, int value) { }

	public override int CheckMagazinesValue(MongoID magazineId) { }

	public override bool Examined(Item item) { }

	public override bool Examined(MongoID templateId) { }

	public override bool ForgetInEncyclopedia(MongoID itemId) { }

	public override IReadOnlyDictionary get_CompletableItems() { }

	[CompilerGenerated]
	public override int get_Experience() { }

	[CompilerGenerated]
	public override Inventory get_InventoryInfo() { }

	[CompilerGenerated]
	public override int get_MagDrillsMastering() { }

	public override string get_Nickname() { }

	public override string get_ProfileId() { }

	public override EPlayerSide get_Side() { }

	[CompilerGenerated]
	public override IInventoryProfileSkillInfo get_SkillsInfo() { }

	[CompilerGenerated]
	public override Dictionary get_TradersInfo() { }

	public override bool IsCheckedChambers(MongoID weaponId) { }

	public override bool IsCheckedMagazines(MongoID magazineId) { }

	public override void LearnInEncyclopedia(MongoID itemId) { }

	[CompilerGenerated]
	public override void remove_OnCompletableItemValueChanged(Action value) { }

	public void ReplaceInventory(Inventory inventory) { }

	[CompilerGenerated]
	public override void set_Experience(int value) { }

	[CompilerGenerated]
	private void set_InventoryInfo(Inventory value) { }

	public override IResult SetCompletableItemValue(MongoID itemId, bool completed, bool force = false) { }

	public override void UnCheckChamber(MongoID weaponId) { }

	public override void UnCheckMagazines(MongoID magazineId) { }

}

