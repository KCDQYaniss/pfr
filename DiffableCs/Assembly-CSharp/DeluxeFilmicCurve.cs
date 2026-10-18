//Type is in global namespace

public class DeluxeFilmicCurve
{
	[SerializeField]
	public float m_BlackPoint; //Field offset: 0x10
	[SerializeField]
	public float m_WhitePoint; //Field offset: 0x14
	[SerializeField]
	public float m_CrossOverPoint; //Field offset: 0x18
	[SerializeField]
	public float m_ToeStrength; //Field offset: 0x1C
	[SerializeField]
	public float m_ShoulderStrength; //Field offset: 0x20
	[SerializeField]
	public float m_Highlights; //Field offset: 0x24
	public float m_k; //Field offset: 0x28
	public Vector4 m_ToeCoef; //Field offset: 0x2C
	public Vector4 m_ShoulderCoef; //Field offset: 0x3C

	public DeluxeFilmicCurve() { }

	public float ComputeK(float t, float c, float b, float s, float w) { }

	public void ComputeShaderCoefficients(float t, float c, float b, float s, float w, float k) { }

	public float GetExposure() { }

	public float Graph(float x, float t, float c, float b, float s, float w, float k) { }

	public float Shoulder(float x, float t, float c, float b, float s, float w, float k) { }

	public void StoreK() { }

	public float Toe(float x, float t, float c, float b, float s, float w, float k) { }

	public void UpdateCoefficients() { }

}

