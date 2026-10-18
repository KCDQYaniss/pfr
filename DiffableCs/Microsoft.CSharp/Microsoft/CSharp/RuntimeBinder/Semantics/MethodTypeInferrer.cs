namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class MethodTypeInferrer
{
	[Flags]
	private enum Dependency
	{
		Unknown = 0,
		NotDependent = 1,
		DependsMask = 16,
		Indirect = 18,
	}

	private enum NewInferenceResult
	{
		InferenceFailed = 0,
		MadeProgress = 1,
		NoProgress = 2,
		Success = 3,
	}

	private readonly ExpressionBinder _binder; //Field offset: 0x10
	private readonly TypeArray _pMethodTypeParameters; //Field offset: 0x20
	private readonly TypeArray _pMethodFormalParameterTypes; //Field offset: 0x28
	private readonly ArgInfos _pMethodArguments; //Field offset: 0x30
	private readonly List[] _pExactBounds; //Field offset: 0x38
	private readonly List[] _pUpperBounds; //Field offset: 0x40
	private readonly List[] _pLowerBounds; //Field offset: 0x48
	private readonly CType[] _pFixedResults; //Field offset: 0x50
	private Dependency[][] _ppDependencies; //Field offset: 0x58
	private bool _dependenciesDirty; //Field offset: 0x60

	private MethodTypeInferrer(ExpressionBinder exprBinder, TypeArray pMethodFormalParameterTypes, ArgInfos pMethodArguments, TypeArray pMethodTypeParameters) { }

	private void AddExactBound(TypeParameterType pParam, CType pBound) { }

	private void AddLowerBound(TypeParameterType pParam, CType pBound) { }

	private void AddUpperBound(TypeParameterType pParam, CType pBound) { }

	private bool AllFixed() { }

	private bool AnyDependsOn(int iParam) { }

	private void DeduceAllDependencies() { }

	private bool DeduceDependencies() { }

	private bool DependsOn(int iParam, int jParam) { }

	private bool DependsOnAny(int iParam) { }

	private bool DependsTransitivelyOn(int iParam, int jParam) { }

	private NewInferenceResult DoSecondPhase() { }

	private bool ExactArrayInference(CType pSource, CType pDest) { }

	private bool ExactConstructedInference(CType pSource, CType pDest) { }

	private void ExactInference(CType pSource, CType pDest) { }

	private bool ExactNullableInference(CType pSource, CType pDest) { }

	private void ExactTypeArgumentInference(AggregateType pSource, AggregateType pDest) { }

	private bool ExactTypeParameterInference(CType pSource, CType pDest) { }

	private bool Fix(int iParam) { }

	private NewInferenceResult FixDependentParameters() { }

	private NewInferenceResult FixNondependentParameters() { }

	private TypeArray GetResults() { }

	private bool HasBound(int iParam) { }

	public static bool Infer(ExpressionBinder binder, MethodSymbol pMethod, TypeArray pMethodFormalParameterTypes, ArgInfos pMethodArguments, out TypeArray ppInferredTypeArguments) { }

	private bool InferTypeArgs() { }

	private void InferTypeArgsFirstPhase() { }

	private bool InferTypeArgsSecondPhase() { }

	private void InitializeDependencies() { }

	private static bool IsReallyAType(CType pType) { }

	private bool IsUnfixed(TypeParameterType pParam) { }

	private bool IsUnfixed(int iParam) { }

	private bool LowerBoundArrayInference(CType pSource, CType pDest) { }

	private bool LowerBoundClassInference(CType pSource, AggregateType pDest) { }

	private bool LowerBoundConstructedInference(CType pSource, CType pDest) { }

	private void LowerBoundInference(CType pSource, CType pDest) { }

	private bool LowerBoundInterfaceInference(CType pSource, AggregateType pDest) { }

	private void LowerBoundTypeArgumentInference(AggregateType pSource, AggregateType pDest) { }

	private bool LowerBoundTypeParameterInference(CType pSource, CType pDest) { }

	private void SetIndirectsToUnknown() { }

	private void SetUnknownsToNotDependent() { }

	private void UpdateDependenciesAfterFix(int iParam) { }

	private bool UpperBoundArrayInference(CType pSource, CType pDest) { }

	private bool UpperBoundClassInference(AggregateType pSource, CType pDest) { }

	private bool UpperBoundConstructedInference(CType pSource, CType pDest) { }

	private void UpperBoundInference(CType pSource, CType pDest) { }

	private bool UpperBoundInterfaceInference(AggregateType pSource, CType pDest) { }

	private void UpperBoundTypeArgumentInference(AggregateType pSource, AggregateType pDest) { }

	private bool UpperBoundTypeParameterInference(CType pSource, CType pDest) { }

}

