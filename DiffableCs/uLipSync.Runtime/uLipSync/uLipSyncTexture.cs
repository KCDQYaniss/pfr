namespace uLipSync;

public class uLipSyncTexture : MonoBehaviour
{
	internal class TextureInfo
	{
		public string phoneme; //Field offset: 0x10
		public Texture texture; //Field offset: 0x18
		public Vector2 uvScale; //Field offset: 0x20
		public Vector2 uvOffset; //Field offset: 0x28

		public TextureInfo() { }

	}

	public UpdateMethod updateMethod; //Field offset: 0x20
	public Renderer targetRenderer; //Field offset: 0x28
	public List textures; //Field offset: 0x30
	public float minVolume; //Field offset: 0x38
	[Range(0, 1)]
	public float minDuration; //Field offset: 0x3C
	private Material _mat; //Field offset: 0x40
	private Texture _initialTexture; //Field offset: 0x48
	private LipSyncInfo _info; //Field offset: 0x50
	private List _phonemeHistory; //Field offset: 0x68
	private Dictionary _phonemeCountTable; //Field offset: 0x70
	private float _keepTimer; //Field offset: 0x78
	private bool _lipSyncUpdated; //Field offset: 0x7C
	private float _volume; //Field offset: 0x80
	private string _phoneme; //Field offset: 0x88

	public private Texture initialTexture
	{
		 get { } //Length: 596
		private set { } //Length: 82
	}

	public uLipSyncTexture() { }

	private void Apply() { }

	private void FixedUpdate() { }

	public Texture get_initialTexture() { }

	private void LateUpdate() { }

	public void OnLipSyncUpdate(LipSyncInfo info) { }

	private void set_initialTexture(Texture value) { }

	private void Update() { }

	private void UpdateLipSync() { }

	private void UpdateVolume() { }

	private void UpdateVowels() { }

}

