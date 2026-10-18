namespace EFT.UI.Builds;

public sealed class EquipmentBuild : IBuild
{
	[CompilerGenerated]
	private readonly MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly EEquipmentBuildType <BuildType>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <EquipmentWeight>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <EquipmentWeightElite>k__BackingField; //Field offset: 0x38
	private InventoryEquipment _equipment; //Field offset: 0x40

	public override EEquipmentBuildType BuildType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public private InventoryEquipment Equipment
	{
		 get { } //Length: 5
		private set { } //Length: 211
	}

	public private float EquipmentWeight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float EquipmentWeightElite
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public override MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public private override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EquipmentBuild(MongoID id, string name, InventoryEquipment equipment, EEquipmentBuildType buildType = 0) { }

	[JsonConstructor]
	private EquipmentBuild(MongoID id, string name, MongoID rootItem, FlatItem[] items, EEquipmentBuildType buildType) { }

	private EquipmentBuild(MongoID id, string name, EEquipmentBuildType buildType) { }

	public EquipmentBuild(string name, InventoryEquipment equipment) { }

	public void ChangeName(string newName) { }

	[CompilerGenerated]
	public override EEquipmentBuildType get_BuildType() { }

	public InventoryEquipment get_Equipment() { }

	[CompilerGenerated]
	public float get_EquipmentWeight() { }

	[CompilerGenerated]
	public float get_EquipmentWeightElite() { }

	[CompilerGenerated]
	public override MongoID get_Id() { }

	[CompilerGenerated]
	public override string get_Name() { }

	private void set_Equipment(InventoryEquipment value) { }

	[CompilerGenerated]
	private void set_EquipmentWeight(float value) { }

	[CompilerGenerated]
	private void set_EquipmentWeightElite(float value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

}

