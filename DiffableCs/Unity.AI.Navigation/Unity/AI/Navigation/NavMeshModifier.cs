namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMeshModifier", 32)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifier.html")]
public class NavMeshModifier : MonoBehaviour
{
	private static readonly List s_NavMeshModifiers; //Field offset: 0x0
	[SerializeField]
	private bool m_OverrideArea; //Field offset: 0x20
	[SerializeField]
	private int m_Area; //Field offset: 0x24
	[SerializeField]
	private bool m_OverrideGenerateLinks; //Field offset: 0x28
	[SerializeField]
	private bool m_GenerateLinks; //Field offset: 0x29
	[SerializeField]
	private bool m_IgnoreFromBuild; //Field offset: 0x2A
	[SerializeField]
	private bool m_ApplyToChildren; //Field offset: 0x2B
	[SerializeField]
	private List m_AffectedAgents; //Field offset: 0x30

	public static List activeModifiers
	{
		 get { } //Length: 83
	}

	public bool applyToChildren
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int area
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool generateLinks
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool ignoreFromBuild
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool overrideArea
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool overrideGenerateLinks
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private static NavMeshModifier() { }

	public NavMeshModifier() { }

	public bool AffectsAgentType(int agentTypeID) { }

	public static List get_activeModifiers() { }

	public bool get_applyToChildren() { }

	public int get_area() { }

	public bool get_generateLinks() { }

	public bool get_ignoreFromBuild() { }

	public bool get_overrideArea() { }

	public bool get_overrideGenerateLinks() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void set_applyToChildren(bool value) { }

	public void set_area(int value) { }

	public void set_generateLinks(bool value) { }

	public void set_ignoreFromBuild(bool value) { }

	public void set_overrideArea(bool value) { }

	public void set_overrideGenerateLinks(bool value) { }

}

