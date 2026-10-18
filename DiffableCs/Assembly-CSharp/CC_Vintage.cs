//Type is in global namespace

[AddComponentMenu("Colorful/Vintage")]
[ExecuteInEditMode]
public class CC_Vintage : CC_LookupFilter
{
	internal enum Filter
	{
		None = 0,
		K506 = 1,
		Zabid = 2,
		Cognac = 3,
		Edwards = 4,
		Cheese = 5,
		LateGoose = 6,
		Bread = 7,
		Montreal = 8,
		Feather = 9,
		Jason = 10,
		Fahrenheit = 11,
		Owl = 12,
		Chillwave = 13,
		Albert = 14,
		Bayswater = 15,
		Atlanta = 16,
		Felicity = 17,
		Stefano = 18,
		Boost = 19,
		Emilia = 20,
		Doze = 21,
		Clifden = 22,
		Blender = 23,
		Tokyo = 24,
		Walk = 25,
		Olive = 26,
		Hotshot = 27,
	}

	public Filter filter; //Field offset: 0x48
	protected Filter m_CurrentFilter; //Field offset: 0x4C

	public CC_Vintage() { }

	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

