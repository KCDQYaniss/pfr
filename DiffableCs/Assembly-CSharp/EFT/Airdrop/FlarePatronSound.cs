namespace EFT.Airdrop;

public class FlarePatronSound : MonoBehaviour
{
	[SerializeField]
	private AudioClip _audioClip; //Field offset: 0x20
	[SerializeField]
	private float _volume; //Field offset: 0x28
	[SerializeField]
	private float _rolloff; //Field offset: 0x2C
	private BetterSource _source; //Field offset: 0x30

	public FlarePatronSound() { }

	public override void Init(float lifetime) { }

	private void InitSource() { }

	private void OnDestroy() { }

	private void Play(float lifetime) { }

	private void ReleaseSource() { }

	protected override void Update() { }

}

