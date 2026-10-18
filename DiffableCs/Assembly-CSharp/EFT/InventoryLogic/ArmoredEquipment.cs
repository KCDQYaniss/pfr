namespace EFT.InventoryLogic;

public class ArmoredEquipment : Equipment
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__8_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__8_0(Slot slot) { }

		internal EItemAttributeDisplayType <.ctor>b__8_3() { }

	}

	[Component]
	public readonly RepairableComponent Repairable; //Field offset: 0x90
	[Component]
	public readonly ArmorComponent Armor; //Field offset: 0x98
	[Component]
	public readonly TogglableComponent Togglable; //Field offset: 0xA0
	[Component]
	public readonly FaceShieldComponent FaceShield; //Field offset: 0xA8
	[Component]
	public BuffComponent Buff; //Field offset: 0xB0
	private ArmoredEquipmentTemplate _template; //Field offset: 0xB8

	public float BlindnessProtection
	{
		 get { } //Length: 34
	}

	public ArmoredEquipment(string id, ArmoredEquipmentTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__8_1() { }

	[CompilerGenerated]
	private string <.ctor>b__8_2() { }

	public float get_BlindnessProtection() { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext context) { }

}

