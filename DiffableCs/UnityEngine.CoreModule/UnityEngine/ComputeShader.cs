namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public sealed class ComputeShader : Object
{

	public LocalKeywordSpace keywordSpace
	{
		 get { } //Length: 97
	}

	[NativeName("DispatchComputeShader")]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	public int FindKernel(string name) { }

	public LocalKeywordSpace get_keywordSpace() { }

	private void get_keywordSpace_Injected(out LocalKeywordSpace ret) { }

	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	public void SetBool(int nameID, bool val) { }

	public void SetBool(string name, bool val) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	private void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size) { }

	public void SetFloat(string name, float val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<float>", HasExplicitThis = True)]
	public void SetFloat(int nameID, float val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetArray<float>", HasExplicitThis = True)]
	private void SetFloatArray(int nameID, float[] values) { }

	public void SetFloats(int nameID, float[] values) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
	public void SetInt(int nameID, int val) { }

	public void SetInt(string name, int val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetArray<int>", HasExplicitThis = True)]
	private void SetIntArray(int nameID, int[] values) { }

	public void SetInts(string name, int[] values) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Matrix4x4f>", HasExplicitThis = True)]
	public void SetMatrix(int nameID, Matrix4x4 val) { }

	private void SetMatrix_Injected(int nameID, ref Matrix4x4 val) { }

	[NativeMethod(Name = "ComputeShaderScripting::SetTexture", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	public void SetTexture(int kernelIndex, int nameID, Texture texture) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = True)]
	public void SetVector(int nameID, Vector4 val) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

