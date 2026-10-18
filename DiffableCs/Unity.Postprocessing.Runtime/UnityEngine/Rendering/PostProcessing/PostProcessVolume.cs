namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Volume", 1001)]
[ExecuteAlways]
public sealed class PostProcessVolume : MonoBehaviour
{
	public PostProcessProfile sharedProfile; //Field offset: 0x20
	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	public bool isGlobal; //Field offset: 0x28
	[Min(0)]
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	public float blendDistance; //Field offset: 0x2C
	[Range(0, 1)]
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	public float weight; //Field offset: 0x30
	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	public float priority; //Field offset: 0x34
	private int m_PreviousLayer; //Field offset: 0x38
	private float m_PreviousPriority; //Field offset: 0x3C
	private List m_TempColliders; //Field offset: 0x40
	private PostProcessProfile m_InternalProfile; //Field offset: 0x48

	public PostProcessProfile profile
	{
		 get { } //Length: 1011
		 set { } //Length: 82
	}

	internal PostProcessProfile profileRef
	{
		internal get { } //Length: 221
	}

	public PostProcessVolume() { }

	public PostProcessProfile get_profile() { }

	internal PostProcessProfile get_profileRef() { }

	public bool HasInstantiatedProfile() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

	public void set_profile(PostProcessProfile value) { }

	private void Update() { }

}

