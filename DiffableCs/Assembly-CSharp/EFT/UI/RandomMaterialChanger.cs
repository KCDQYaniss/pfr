namespace EFT.UI;

public sealed class RandomMaterialChanger : MonoBehaviour
{
	[Header("Materials list")]
	[SerializeField]
	private Material[] _materials; //Field offset: 0x20
	[Header("Material change on start")]
	[SerializeField]
	private bool _changeOnStart; //Field offset: 0x28
	[Header("Material change on object activation")]
	[SerializeField]
	private bool _changeOnEnable; //Field offset: 0x29
	private Renderer _objectRenderer; //Field offset: 0x30

	public RandomMaterialChanger() { }

	public void ChangeMaterial() { }

	private void OnEnable() { }

	private void Start() { }

}

