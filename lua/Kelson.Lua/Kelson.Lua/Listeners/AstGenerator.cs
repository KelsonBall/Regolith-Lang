using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;

namespace Kelson.Lua.Listeners
{
    public class AstGenerator : ILuaListener
    {
        public void EnterArgs([NotNull] LuaParser.ArgsContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterBinaryop([NotNull] LuaParser.BinaryopContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterBlock([NotNull] LuaParser.BlockContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterChunk([NotNull] LuaParser.ChunkContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void EnterExp([NotNull] LuaParser.ExpContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExplist([NotNull] LuaParser.ExplistContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_bool([NotNull] LuaParser.Exp_boolContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_functiondef([NotNull] LuaParser.Exp_functiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_nil([NotNull] LuaParser.Exp_nilContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_number([NotNull] LuaParser.Exp_numberContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_params([NotNull] LuaParser.Exp_paramsContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_prefixexp([NotNull] LuaParser.Exp_prefixexpContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_string([NotNull] LuaParser.Exp_stringContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_tableconstructor([NotNull] LuaParser.Exp_tableconstructorContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterExp_unary([NotNull] LuaParser.Exp_unaryContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterField([NotNull] LuaParser.FieldContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterFieldlist([NotNull] LuaParser.FieldlistContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterFieldsep([NotNull] LuaParser.FieldsepContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterFuncbody([NotNull] LuaParser.FuncbodyContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterFuncname([NotNull] LuaParser.FuncnameContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterFunctioncall([NotNull] LuaParser.FunctioncallContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterFunctiondef([NotNull] LuaParser.FunctiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterLabel([NotNull] LuaParser.LabelContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterNameAndArgs([NotNull] LuaParser.NameAndArgsContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterNamelist([NotNull] LuaParser.NamelistContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterNumber([NotNull] LuaParser.NumberContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorAnd([NotNull] LuaParser.OperatorAndContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorOr([NotNull] LuaParser.OperatorOrContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorPower([NotNull] LuaParser.OperatorPowerContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterParlist([NotNull] LuaParser.ParlistContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterPrefixexp([NotNull] LuaParser.PrefixexpContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterRetstat([NotNull] LuaParser.RetstatContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat([NotNull] LuaParser.StatContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_break([NotNull] LuaParser.Stat_breakContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_do([NotNull] LuaParser.Stat_doContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_empty([NotNull] LuaParser.Stat_emptyContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_foriter([NotNull] LuaParser.Stat_foriterContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_fornum([NotNull] LuaParser.Stat_fornumContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_functioncall([NotNull] LuaParser.Stat_functioncallContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_functiondef([NotNull] LuaParser.Stat_functiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_globalassign([NotNull] LuaParser.Stat_globalassignContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_goto([NotNull] LuaParser.Stat_gotoContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_if([NotNull] LuaParser.Stat_ifContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_label([NotNull] LuaParser.Stat_labelContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_localassignment([NotNull] LuaParser.Stat_localassignmentContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_localfunctiondef([NotNull] LuaParser.Stat_localfunctiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_repeat([NotNull] LuaParser.Stat_repeatContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStat_while([NotNull] LuaParser.Stat_whileContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterString([NotNull] LuaParser.StringContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterTableconstructor([NotNull] LuaParser.TableconstructorContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterVar([NotNull] LuaParser.VarContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterVarlist([NotNull] LuaParser.VarlistContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterVarOrExp([NotNull] LuaParser.VarOrExpContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterVarSuffix([NotNull] LuaParser.VarSuffixContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitArgs([NotNull] LuaParser.ArgsContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitBinaryop([NotNull] LuaParser.BinaryopContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitBlock([NotNull] LuaParser.BlockContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitChunk([NotNull] LuaParser.ChunkContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void ExitExp([NotNull] LuaParser.ExpContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExplist([NotNull] LuaParser.ExplistContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_bool([NotNull] LuaParser.Exp_boolContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_functiondef([NotNull] LuaParser.Exp_functiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_nil([NotNull] LuaParser.Exp_nilContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_number([NotNull] LuaParser.Exp_numberContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_params([NotNull] LuaParser.Exp_paramsContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_prefixexp([NotNull] LuaParser.Exp_prefixexpContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_string([NotNull] LuaParser.Exp_stringContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_tableconstructor([NotNull] LuaParser.Exp_tableconstructorContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitExp_unary([NotNull] LuaParser.Exp_unaryContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitField([NotNull] LuaParser.FieldContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitFieldlist([NotNull] LuaParser.FieldlistContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitFieldsep([NotNull] LuaParser.FieldsepContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitFuncbody([NotNull] LuaParser.FuncbodyContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitFuncname([NotNull] LuaParser.FuncnameContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitFunctioncall([NotNull] LuaParser.FunctioncallContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitFunctiondef([NotNull] LuaParser.FunctiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitLabel([NotNull] LuaParser.LabelContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitNameAndArgs([NotNull] LuaParser.NameAndArgsContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitNamelist([NotNull] LuaParser.NamelistContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitNumber([NotNull] LuaParser.NumberContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorAnd([NotNull] LuaParser.OperatorAndContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorOr([NotNull] LuaParser.OperatorOrContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorPower([NotNull] LuaParser.OperatorPowerContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitParlist([NotNull] LuaParser.ParlistContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitPrefixexp([NotNull] LuaParser.PrefixexpContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitRetstat([NotNull] LuaParser.RetstatContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat([NotNull] LuaParser.StatContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_break([NotNull] LuaParser.Stat_breakContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_do([NotNull] LuaParser.Stat_doContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_empty([NotNull] LuaParser.Stat_emptyContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_foriter([NotNull] LuaParser.Stat_foriterContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_fornum([NotNull] LuaParser.Stat_fornumContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_functioncall([NotNull] LuaParser.Stat_functioncallContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_functiondef([NotNull] LuaParser.Stat_functiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_globalassign([NotNull] LuaParser.Stat_globalassignContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_goto([NotNull] LuaParser.Stat_gotoContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_if([NotNull] LuaParser.Stat_ifContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_label([NotNull] LuaParser.Stat_labelContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_localassignment([NotNull] LuaParser.Stat_localassignmentContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_localfunctiondef([NotNull] LuaParser.Stat_localfunctiondefContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_repeat([NotNull] LuaParser.Stat_repeatContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStat_while([NotNull] LuaParser.Stat_whileContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitString([NotNull] LuaParser.StringContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitTableconstructor([NotNull] LuaParser.TableconstructorContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitVar([NotNull] LuaParser.VarContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitVarlist([NotNull] LuaParser.VarlistContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitVarOrExp([NotNull] LuaParser.VarOrExpContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitVarSuffix([NotNull] LuaParser.VarSuffixContext context)
        {
            throw new NotImplementedException();
        }

        public void VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException();
        }

        public void VisitTerminal(ITerminalNode node)
        {
            throw new NotImplementedException();
        }
    }
}
