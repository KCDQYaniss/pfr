namespace EFT.UI;

public sealed class PlayerEquipmentWindow : Window
{
	private sealed class PreviewInventoryProfileInfo : IInventoryProfileInfo
	{
		private readonly Profile _profile; //Field offset: 0x10
		[CompilerGenerated]
		private Action OnCompletableItemValueChanged; //Field offset: 0x18
		[CompilerGenerated]
		private Inventory <InventoryInfo>k__BackingField; //Field offset: 0x20

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
			 get { } //Length: 38
			 set { } //Length: 3
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
			 get { } //Length: 29
		}

		public override string Nickname
		{
			 get { } //Length: 36
		}

		public override string ProfileId
		{
			 get { } //Length: 27
		}

		public override EPlayerSide Side
		{
			 get { } //Length: 35
		}

		public override IInventoryProfileSkillInfo SkillsInfo
		{
			 get { } //Length: 30
		}

		public override Dictionary TradersInfo
		{
			 get { } //Length: 30
		}

		public PreviewInventoryProfileInfo(Profile profile) { }

		[CompilerGenerated]
		public override void add_OnCompletableItemValueChanged(Action value) { }

		public override void AddToCarriedQuestItems(string itemTemplateId) { }

		public override void CheckChamber(MongoID weaponId) { }

		public override void CheckMagazines(MongoID magazineId, int value) { }

		public override int CheckMagazinesValue(MongoID magazineId) { }

		public override bool Examined(MongoID templateId) { }

		public override bool Examined(Item item) { }

		public override bool ForgetInEncyclopedia(MongoID itemId) { }

		public override IReadOnlyDictionary get_CompletableItems() { }

		public override int get_Experience() { }

		[CompilerGenerated]
		public override Inventory get_InventoryInfo() { }

		public override int get_MagDrillsMastering() { }

		public override string get_Nickname() { }

		public override string get_ProfileId() { }

		public override EPlayerSide get_Side() { }

		public override IInventoryProfileSkillInfo get_SkillsInfo() { }

		public override Dictionary get_TradersInfo() { }

		public override bool IsCheckedChambers(MongoID weaponId) { }

		public override bool IsCheckedMagazines(MongoID magazineId) { }

		public override void LearnInEncyclopedia(MongoID itemId) { }

		[CompilerGenerated]
		public override void remove_OnCompletableItemValueChanged(Action value) { }

		public override void set_Experience(int value) { }

		[CompilerGenerated]
		private void set_InventoryInfo(Inventory value) { }

		public override IResult SetCompletableItemValue(MongoID completableItem, bool completed, bool force = false) { }

		public void SetInventoryInfo(Inventory inventory) { }

		public override void UnCheckChamber(MongoID weaponId) { }

		public override void UnCheckMagazines(MongoID magazineId) { }

	}

	[SerializeField]
	private EquipmentBuildGear _equipmentPanel; //Field offset: 0xB8
	[SerializeField]
	private ContainersPanel _containersPanel; //Field offset: 0xC0
	[SerializeField]
	private HealthParametersPanel _healthPanel; //Field offset: 0xC8
	[SerializeField]
	private ChatSpecialIconSettings _iconSettings; //Field offset: 0xD0
	private InventoryEquipment _currentEquipment; //Field offset: 0xD8
	private DefaultItemContext _equipmentContext; //Field offset: 0xE0
	private PlayerEquipmentWindowContext _windowContext; //Field offset: 0xE8
	private InventoryController _previewInventoryController; //Field offset: 0xF0
	private PreviewInventoryProfileInfo _cachedPreviewProfileInfo; //Field offset: 0xF8
	private Profile _cachedProfile; //Field offset: 0x100

	public PlayerEquipmentWindow() { }

	public virtual void Close() { }

	public PlayerEquipmentWindowContext Show(GroupPlayer groupPlayer, Profile currentPlayerProfile, InsuranceCompany insuranceCompany) { }

}

