//Type is in global namespace

public class PhotoCamera : MonoBehaviour
{
	internal sealed class TextureRenderFinishedHandler : MulticastDelegate
	{

		public TextureRenderFinishedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhotoCamera sender, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhotoCamera sender) { }

	}

	private RenderTexture _renderTexture; //Field offset: 0x20
	private Camera _photoCamera; //Field offset: 0x28
	private bool _shouldDrawMesh; //Field offset: 0x30
	private bool _shouldReturnTexture; //Field offset: 0x31
	private int _layer; //Field offset: 0x34
	private Vector3 _offsetFromCamera; //Field offset: 0x38
	[CompilerGenerated]
	private TextureRenderFinishedHandler OnTextureRenderFinished; //Field offset: 0x48
	private Action _callback; //Field offset: 0x50
	private GameObject _objectToDraw; //Field offset: 0x58
	private Matrix4x4 _matrix; //Field offset: 0x60
	private Light _light; //Field offset: 0xA0

	public event TextureRenderFinishedHandler OnTextureRenderFinished
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public PhotoCamera() { }

	[CompilerGenerated]
	public void add_OnTextureRenderFinished(TextureRenderFinishedHandler value) { }

	public void Awake() { }

	private void DrawObjectRecursively(Transform t) { }

	private Mesh GetMeshFromSubmesh(int[] triangles, Mesh originalMesh) { }

	public void MakeTexture(GameObject gObject, Action callback, int cameraOrthoSize, Vector2 renderTextureSize) { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	[CompilerGenerated]
	public void remove_OnTextureRenderFinished(TextureRenderFinishedHandler value) { }

}

