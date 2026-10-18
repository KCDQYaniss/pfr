//Type is in global namespace

internal class MetaXRAcousticMaterialMapping : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public PhysicMaterial pmat; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <findAcousticMaterial>b__0(Pair pair) { }

	}

	public class Pair
	{
		[SerializeField]
		internal PhysicMaterial physicMaterial; //Field offset: 0x10
		[SerializeField]
		internal MetaXRAcousticMaterialProperties acousticMaterial; //Field offset: 0x18

		public Pair() { }

	}

	private static MetaXRAcousticMaterialMapping instance; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	internal Pair[] mapping; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	[Tooltip("Acoustic material to apply when there is no physics material.")]
	internal MetaXRAcousticMaterialProperties fallbackMaterial; //Field offset: 0x20

	internal static MetaXRAcousticMaterialMapping Instance
	{
		internal get { } //Length: 709
	}

	public MetaXRAcousticMaterialMapping() { }

	internal MetaXRAcousticMaterialProperties findAcousticMaterial(PhysicMaterial pmat) { }

	internal static MetaXRAcousticMaterialMapping get_Instance() { }

}

