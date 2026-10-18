namespace UnityEngine.UI.Extensions;

[ExecuteInEditMode]
public class SoftMask : MonoBehaviour
{
	private static readonly int _hardBlend; //Field offset: 0x0
	private static readonly int _min; //Field offset: 0x4
	private static readonly int _max; //Field offset: 0x8
	private static readonly int _flipAlphaMask; //Field offset: 0xC
	private static readonly int _alphaMask; //Field offset: 0x10
	private static readonly int _alphaUv; //Field offset: 0x14
	private static readonly int _noOuterClip; //Field offset: 0x18
	private static readonly int _cutOff; //Field offset: 0x1C
	private Material mat; //Field offset: 0x20
	private Canvas canvas; //Field offset: 0x28
	public Shader ImageMaskShader; //Field offset: 0x30
	[Tooltip("The area that is to be used as the container.")]
	public RectTransform MaskArea; //Field offset: 0x38
	private RectTransform myRect; //Field offset: 0x40
	[Tooltip("A Rect Transform that can be used to scale and move the mask - Does not apply to Text UI Components being masked")]
	public RectTransform maskScalingRect; //Field offset: 0x48
	[Tooltip("Texture to be used to do the soft alpha")]
	public Texture AlphaMask; //Field offset: 0x50
	[Range(0, 1)]
	[Tooltip("At what point to apply the alpha min range 0-1")]
	public float CutOff; //Field offset: 0x58
	[Tooltip("Implement a hard blend based on the Cutoff")]
	public bool HardBlend; //Field offset: 0x5C
	[Tooltip("Flip the masks alpha value")]
	public bool FlipAlphaMask; //Field offset: 0x5D
	[Tooltip("If Mask Scaling Rect is given and this value is true, the area around the mask will not be clipped")]
	public bool DontClipMaskScalingRect; //Field offset: 0x5E
	[Tooltip("If set to true, this mask is applied to all child Graphic objects belonging to this object.")]
	public bool CascadeToALLChildren; //Field offset: 0x5F
	private Vector3[] worldCorners; //Field offset: 0x60
	private Vector2 AlphaUV; //Field offset: 0x68
	private Vector2 min; //Field offset: 0x70
	private Vector2 max; //Field offset: 0x78
	private Vector2 p; //Field offset: 0x80
	private Vector2 siz; //Field offset: 0x88
	private Vector2 tp; //Field offset: 0x90
	private bool MaterialNotSupported; //Field offset: 0x98
	private Rect maskRect; //Field offset: 0x9C
	private Rect contentRect; //Field offset: 0xAC
	private Vector2 centre; //Field offset: 0xBC

	private static SoftMask() { }

	public SoftMask() { }

	private void GetCanvas() { }

	private void SetMask() { }

	private void SetSAM(Transform t) { }

	private void Start() { }

	private void Update() { }

}

