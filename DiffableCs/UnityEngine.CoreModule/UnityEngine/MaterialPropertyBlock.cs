namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
public sealed class MaterialPropertyBlock
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public MaterialPropertyBlock() { }

	public void Clear() { }

	[ThreadSafe]
	private void Clear(bool keepMemory) { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	private static void DestroyImpl(IntPtr mpb) { }

	private void Dispose() { }

	protected virtual void Finalize() { }

	public Vector4 GetVector(string name) { }

	[NativeName("GetVectorFromScript")]
	[ThreadSafe]
	private Vector4 GetVectorImpl(int name) { }

	private void GetVectorImpl_Injected(int name, out Vector4 ret) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	[NativeName("SetColorFromScript")]
	[ThreadSafe]
	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	[ThreadSafe]
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloatArray(int nameID, float[] values) { }

	private void SetFloatArray(int name, float[] values, int count) { }

	[NativeName("SetFloatArrayFromScript")]
	[ThreadSafe]
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	public void SetInt(string name, int value) { }

	public void SetInt(int nameID, int value) { }

	public void SetInteger(int nameID, int value) { }

	[NativeName("SetIntFromScript")]
	[ThreadSafe]
	private void SetIntImpl(int name, int value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	[NativeName("SetMatrixFromScript")]
	[ThreadSafe]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	private void SetTextureImpl(int name, Texture value) { }

	public void SetVector(int nameID, Vector4 value) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	private void SetVectorImpl(int name, Vector4 value) { }

	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

}

