//Type is in global namespace

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public sealed class AmplifyMotionPostProcess : MonoBehaviour
{
	private AmplifyMotionEffectBase m_instance; //Field offset: 0x20

	public AmplifyMotionEffectBase Instance
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public AmplifyMotionPostProcess() { }

	public AmplifyMotionEffectBase get_Instance() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_Instance(AmplifyMotionEffectBase value) { }

}

