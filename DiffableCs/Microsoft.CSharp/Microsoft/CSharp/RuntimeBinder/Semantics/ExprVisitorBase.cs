namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class ExprVisitorBase
{

	protected ExprVisitorBase() { }

	protected override Expr Dispatch(Expr pExpr) { }

	protected Expr Visit(Expr pExpr) { }

	protected override Expr VisitADD(ExprBinOp pExpr) { }

	protected override Expr VisitADDR(ExprUnaryOp pExpr) { }

	protected override Expr VisitARRAYINDEX(ExprArrayIndex pExpr) { }

	protected override Expr VisitARRINIT(ExprArrayInit pExpr) { }

	protected override Expr VisitASSIGNMENT(ExprAssignment pExpr) { }

	protected override Expr VisitBINOP(ExprBinOp pExpr) { }

	protected override Expr VisitBITAND(ExprBinOp pExpr) { }

	protected override Expr VisitBITNOT(ExprUnaryOp pExpr) { }

	protected override Expr VisitBITOR(ExprBinOp pExpr) { }

	protected override Expr VisitBITXOR(ExprBinOp pExpr) { }

	protected override Expr VisitCALL(ExprCall pExpr) { }

	protected override Expr VisitCAST(ExprCast pExpr) { }

	private void VisitChildren(Expr pExpr) { }

	protected override Expr VisitCOMPARE(ExprBinOp pExpr) { }

	protected override Expr VisitCONCAT(ExprConcat pExpr) { }

	protected override Expr VisitCONSTANT(ExprConstant pExpr) { }

	protected override Expr VisitDEC(ExprUnaryOp pExpr) { }

	protected override Expr VisitDECIMALDEC(ExprUnaryOp pExpr) { }

	protected override Expr VisitDECIMALINC(ExprUnaryOp pExpr) { }

	protected override Expr VisitDECIMALNEG(ExprUnaryOp pExpr) { }

	protected override Expr VisitDELEGATEADD(ExprBinOp pExpr) { }

	protected override Expr VisitDELEGATEEQ(ExprBinOp pExpr) { }

	protected override Expr VisitDELEGATENE(ExprBinOp pExpr) { }

	protected override Expr VisitDELEGATESUB(ExprBinOp pExpr) { }

	protected override Expr VisitDIV(ExprBinOp pExpr) { }

	protected override Expr VisitEQ(ExprBinOp pExpr) { }

	protected override Expr VisitEQUALS(ExprBinOp pExpr) { }

	protected override Expr VisitEXPR(Expr pExpr) { }

	protected override Expr VisitFALSE(ExprUnaryOp pExpr) { }

	protected override Expr VisitFIELD(ExprField pExpr) { }

	protected override Expr VisitFIELDINFO(ExprFieldInfo pExpr) { }

	protected override Expr VisitGE(ExprBinOp pExpr) { }

	protected override Expr VisitGT(ExprBinOp pExpr) { }

	protected override Expr VisitINC(ExprUnaryOp pExpr) { }

	protected override Expr VisitINDIR(ExprBinOp pExpr) { }

	protected override Expr VisitLE(ExprBinOp pExpr) { }

	protected override Expr VisitLIST(ExprList pExpr) { }

	protected override Expr VisitLOCAL(ExprLocal pExpr) { }

	protected override Expr VisitLOGAND(ExprBinOp pExpr) { }

	protected override Expr VisitLOGNOT(ExprUnaryOp pExpr) { }

	protected override Expr VisitLOGOR(ExprBinOp pExpr) { }

	protected override Expr VisitLSHIFT(ExprBinOp pExpr) { }

	protected override Expr VisitLT(ExprBinOp pExpr) { }

	protected override Expr VisitMEMGRP(ExprMemberGroup pExpr) { }

	protected override Expr VisitMETHODINFO(ExprMethodInfo pExpr) { }

	protected override Expr VisitMOD(ExprBinOp pExpr) { }

	protected override Expr VisitMUL(ExprBinOp pExpr) { }

	protected override Expr VisitMULTI(ExprMulti pExpr) { }

	protected override Expr VisitMULTIGET(ExprMultiGet pExpr) { }

	protected override Expr VisitNE(ExprBinOp pExpr) { }

	protected override Expr VisitNEG(ExprUnaryOp pExpr) { }

	protected override Expr VisitPROP(ExprProperty pExpr) { }

	protected override Expr VisitRSHIFT(ExprBinOp pExpr) { }

	protected override Expr VisitSAVE(ExprBinOp pExpr) { }

	protected override Expr VisitSEQUENCE(ExprBinOp pExpr) { }

	protected override Expr VisitSTRINGEQ(ExprBinOp pExpr) { }

	protected override Expr VisitSTRINGNE(ExprBinOp pExpr) { }

	protected override Expr VisitSUB(ExprBinOp pExpr) { }

	protected override Expr VisitSWAP(ExprBinOp pExpr) { }

	protected override Expr VisitTRUE(ExprUnaryOp pExpr) { }

	protected override Expr VisitTYPEOF(ExprTypeOf pExpr) { }

	protected override Expr VisitUNARYOP(ExprUnaryOp pExpr) { }

	protected override Expr VisitUPLUS(ExprUnaryOp pExpr) { }

	protected override Expr VisitUSERDEFINEDCONVERSION(ExprUserDefinedConversion pExpr) { }

	protected override Expr VisitUSERLOGOP(ExprUserLogicalOp pExpr) { }

	protected override Expr VisitWRAP(ExprWrap pExpr) { }

	protected override Expr VisitZEROINIT(ExprZeroInit pExpr) { }

}

