namespace Koenigz.PerfectCulling;

[CreateAssetMenu]
public class PerfectCullingColorTable : ScriptableObject
{
	[HideInInspector]
	[SerializeField]
	private Color32[] m_colors; //Field offset: 0x18

	public Color32[] Colors
	{
		 get { } //Length: 5
	}

	public static PerfectCullingColorTable Instance
	{
		 get { } //Length: 30
	}

	public PerfectCullingColorTable() { }

	[ContextMenu("Generate")]
	private void Generate() { }

	public Color32[] get_Colors() { }

	public static PerfectCullingColorTable get_Instance() { }

}

