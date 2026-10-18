namespace EFT.InventoryLogic;

public class SightMod : FunctionalMod
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <AddOpticCrateAttribute>b__2_0() { }

		internal EItemAttributeDisplayType <AddOpticCrateAttribute>b__2_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string cratesStr; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal string <AddOpticCrateAttribute>b__1() { }

	}

	[Component]
	public readonly SightComponent Sight; //Field offset: 0x90

	public SightMod(string id, SightModTemplate template) { }

	private void AddOpticCrateAttribute(SightModTemplate template) { }

}

