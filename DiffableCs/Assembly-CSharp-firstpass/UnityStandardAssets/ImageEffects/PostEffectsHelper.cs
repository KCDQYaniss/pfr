namespace UnityStandardAssets.ImageEffects;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
internal class PostEffectsHelper : MonoBehaviour
{
	private static readonly int _mainTex; //Field offset: 0x0

	private static PostEffectsHelper() { }

	public PostEffectsHelper() { }

	private static void DrawBorder(RenderTexture dest, Material material) { }

	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix) { }

	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

