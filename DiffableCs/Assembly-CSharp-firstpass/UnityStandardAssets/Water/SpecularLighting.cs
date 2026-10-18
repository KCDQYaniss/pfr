namespace UnityStandardAssets.Water;

[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]
public class SpecularLighting : MonoBehaviour
{
	private static readonly int _worldLightDir; //Field offset: 0x0
	public Transform specularLight; //Field offset: 0x20
	private WaterBase m_WaterBase; //Field offset: 0x28

	private static SpecularLighting() { }

	public SpecularLighting() { }

	public void Start() { }

	public void Update() { }

}

