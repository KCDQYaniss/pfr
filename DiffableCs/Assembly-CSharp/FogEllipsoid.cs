//Type is in global namespace

[ExecuteInEditMode]
public class FogEllipsoid : MonoBehaviour
{
	internal enum Blend
	{
		Additive = 0,
		Multiplicative = 1,
	}

	public Blend m_Blend; //Field offset: 0x20
	public float m_Density; //Field offset: 0x24
	[MinValue(0)]
	public float m_Radius; //Field offset: 0x28
	[MinValue(0)]
	public float m_Stretch; //Field offset: 0x2C
	[Range(0, 1)]
	public float m_Feather; //Field offset: 0x30
	[Range(0, 1)]
	public float m_NoiseAmount; //Field offset: 0x34
	public float m_NoiseSpeed; //Field offset: 0x38
	[MinValue(0)]
	public float m_NoiseScale; //Field offset: 0x3C
	private bool m_AddedToLightManager; //Field offset: 0x40

	public FogEllipsoid() { }

	private void AddToLightManager() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void Update() { }

}

