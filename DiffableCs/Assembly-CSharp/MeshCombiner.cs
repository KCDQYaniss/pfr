//Type is in global namespace

public class MeshCombiner : MonoBehaviour
{
	public Material[] Materials; //Field offset: 0x20

	public MeshCombiner() { }

	private void Awake() { }

	private static void Combine(Renderer[] renderers, Transform combinedParent, Material material) { }

	private static void Combine(CombineInstance[] instancesAccumulator, Transform parent, Renderer origin) { }

}

