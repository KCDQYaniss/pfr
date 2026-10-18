namespace GPUInstancer;

public class GrassPrefabVariant : MonoBehaviour
{
	private static readonly string arrayIndexId; //Field offset: 0x0
	private static readonly string dryColorId; //Field offset: 0x8
	private static readonly string healthyColorId; //Field offset: 0x10
	[SerializeField]
	public int ArrayIndex; //Field offset: 0x20
	[SerializeField]
	private Color DryColor; //Field offset: 0x24
	[SerializeField]
	private Color HealthyColor; //Field offset: 0x34

	private static GrassPrefabVariant() { }

	public GrassPrefabVariant() { }

	private void OnValidate() { }

	private void SetMpb() { }

}

