using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Kelson.Lua.Listeners
{
    public class XmlPrinter : ILuaListener, IDisposable
    {
        private readonly TextWriter output;

        public XmlPrinter(TextWriter output)
        {
            this.output = output;
        }

        public void Dispose()
        {
            output.Flush();            
        }

        private int depth;

        private void Space(int indent)
        {
            for (int i = 0; i < indent - 2; i++)
                output.Write(' ');
        }

        private void DefaultEnter(ParserRuleContext context)
        {
            depth += 2;
            string contextName = context.GetType().Name;
            string tag = contextName.Substring(0, contextName.IndexOf("Context"));
            Space(depth);
            output.WriteLine($"<{tag}>");
        }

        private void DefaultExit(ParserRuleContext context)
        {            
            string contextName = context.GetType().Name;
            string tag = contextName.Substring(0, contextName.IndexOf("Context"));
            Space(depth);
            output.WriteLine($"</{tag}>");
            depth -= 2;
        }

        public void EnterArgs([NotNull] LuaParser.ArgsContext context)
        {
            DefaultEnter(context);
        }

        public void EnterBlock([NotNull] LuaParser.BlockContext context)
        {
            DefaultEnter(context);
        }

        public void EnterChunk([NotNull] LuaParser.ChunkContext context)
        {
            DefaultEnter(context);
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void EnterExp([NotNull] LuaParser.ExpContext context)
        {
            DefaultEnter(context);
        }

        public void EnterExplist([NotNull] LuaParser.ExplistContext context)
        {
            DefaultEnter(context);
        }

        public void EnterField([NotNull] LuaParser.FieldContext context)
        {
            DefaultEnter(context);
        }

        public void EnterFieldlist([NotNull] LuaParser.FieldlistContext context)
        {
            DefaultEnter(context);
        }

        public void EnterFieldsep([NotNull] LuaParser.FieldsepContext context)
        {
            DefaultEnter(context);
        }

        public void EnterFuncbody([NotNull] LuaParser.FuncbodyContext context)
        {
            DefaultEnter(context);
        }

        public void EnterFuncname([NotNull] LuaParser.FuncnameContext context)
        {
            DefaultEnter(context);
        }

        public void EnterFunctioncall([NotNull] LuaParser.FunctioncallContext context)
        {
            DefaultEnter(context);
        }

        public void EnterFunctiondef([NotNull] LuaParser.FunctiondefContext context)
        {
            DefaultEnter(context);
        }

        public void EnterLabel([NotNull] LuaParser.LabelContext context)
        {
            DefaultEnter(context);
        }

        public void EnterNameAndArgs([NotNull] LuaParser.NameAndArgsContext context)
        {
            DefaultEnter(context);
        }

        public void EnterNamelist([NotNull] LuaParser.NamelistContext context)
        {
            DefaultEnter(context);
        }

        public void EnterNumber([NotNull] LuaParser.NumberContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorAnd([NotNull] LuaParser.OperatorAndContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorOr([NotNull] LuaParser.OperatorOrContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorPower([NotNull] LuaParser.OperatorPowerContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context)
        {
            DefaultEnter(context);
        }

        public void EnterOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context)
        {
            DefaultEnter(context);
        }

        public void EnterParlist([NotNull] LuaParser.ParlistContext context)
        {
            DefaultEnter(context);
        }

        public void EnterPrefixexp([NotNull] LuaParser.PrefixexpContext context)
        {
            DefaultEnter(context);
        }

        public void EnterRetstat([NotNull] LuaParser.RetstatContext context)
        {
            DefaultEnter(context);
        }

        public void EnterStat([NotNull] LuaParser.StatContext context)
        {
            DefaultEnter(context);
        }

        public void EnterString([NotNull] LuaParser.StringContext context)
        {
            DefaultEnter(context);
        }

        public void EnterTableconstructor([NotNull] LuaParser.TableconstructorContext context)
        {
            DefaultEnter(context);
        }

        public void EnterVar([NotNull] LuaParser.VarContext context)
        {
            DefaultEnter(context);
        }

        public void EnterVarlist([NotNull] LuaParser.VarlistContext context)
        {
            DefaultEnter(context);
        }

        public void EnterVarOrExp([NotNull] LuaParser.VarOrExpContext context)
        {
            DefaultEnter(context);
        }

        public void EnterVarSuffix([NotNull] LuaParser.VarSuffixContext context)
        {
            DefaultEnter(context);
        }

        public void ExitArgs([NotNull] LuaParser.ArgsContext context)
        {
            DefaultExit(context);
        }

        public void ExitBlock([NotNull] LuaParser.BlockContext context)
        {
            DefaultExit(context);
        }

        public void ExitChunk([NotNull] LuaParser.ChunkContext context)
        {
            DefaultExit(context);
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void ExitExp([NotNull] LuaParser.ExpContext context)
        {
            DefaultExit(context);
        }

        public void ExitExplist([NotNull] LuaParser.ExplistContext context)
        {
            DefaultExit(context);
        }

        public void ExitField([NotNull] LuaParser.FieldContext context)
        {
            DefaultExit(context);
        }

        public void ExitFieldlist([NotNull] LuaParser.FieldlistContext context)
        {
            DefaultExit(context);
        }

        public void ExitFieldsep([NotNull] LuaParser.FieldsepContext context)
        {
            DefaultExit(context);
        }

        public void ExitFuncbody([NotNull] LuaParser.FuncbodyContext context)
        {
            DefaultExit(context);
        }

        public void ExitFuncname([NotNull] LuaParser.FuncnameContext context)
        {
            DefaultExit(context);
        }

        public void ExitFunctioncall([NotNull] LuaParser.FunctioncallContext context)
        {
            DefaultExit(context);
        }

        public void ExitFunctiondef([NotNull] LuaParser.FunctiondefContext context)
        {
            DefaultExit(context);
        }

        public void ExitLabel([NotNull] LuaParser.LabelContext context)
        {
            DefaultExit(context);
        }

        public void ExitNameAndArgs([NotNull] LuaParser.NameAndArgsContext context)
        {
            DefaultExit(context);
        }

        public void ExitNamelist([NotNull] LuaParser.NamelistContext context)
        {
            DefaultExit(context);
        }

        public void ExitNumber([NotNull] LuaParser.NumberContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorAnd([NotNull] LuaParser.OperatorAndContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorOr([NotNull] LuaParser.OperatorOrContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorPower([NotNull] LuaParser.OperatorPowerContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context)
        {
            DefaultExit(context);
        }

        public void ExitOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context)
        {
            DefaultExit(context);
        }

        public void ExitParlist([NotNull] LuaParser.ParlistContext context)
        {
            DefaultExit(context);
        }

        public void ExitPrefixexp([NotNull] LuaParser.PrefixexpContext context)
        {
            DefaultExit(context);
        }

        public void ExitRetstat([NotNull] LuaParser.RetstatContext context)
        {
            DefaultExit(context);
        }

        public void ExitStat([NotNull] LuaParser.StatContext context)
        {
            DefaultExit(context);
        }

        public void ExitString([NotNull] LuaParser.StringContext context)
        {
            DefaultExit(context);
        }

        public void ExitTableconstructor([NotNull] LuaParser.TableconstructorContext context)
        {
            DefaultExit(context);
        }

        public void ExitVar([NotNull] LuaParser.VarContext context)
        {
            DefaultExit(context);
        }

        public void ExitVarlist([NotNull] LuaParser.VarlistContext context)
        {
            DefaultExit(context);
        }

        public void ExitVarOrExp([NotNull] LuaParser.VarOrExpContext context)
        {
            DefaultExit(context);
        }

        public void ExitVarSuffix([NotNull] LuaParser.VarSuffixContext context)
        {
            DefaultExit(context);
        }

        public void VisitErrorNode(IErrorNode node)
        {            
        }

        public void VisitTerminal(ITerminalNode node)
        {
            Space(depth + 2);
            output.WriteLine(node.ToStringTree());
        }

        public void EnterStat_empty([NotNull] LuaParser.Stat_emptyContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_empty([NotNull] LuaParser.Stat_emptyContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_globalassign([NotNull] LuaParser.Stat_globalassignContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_globalassign([NotNull] LuaParser.Stat_globalassignContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_functioncall([NotNull] LuaParser.Stat_functioncallContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_functioncall([NotNull] LuaParser.Stat_functioncallContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_label([NotNull] LuaParser.Stat_labelContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_label([NotNull] LuaParser.Stat_labelContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_break([NotNull] LuaParser.Stat_breakContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_break([NotNull] LuaParser.Stat_breakContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_goto([NotNull] LuaParser.Stat_gotoContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_goto([NotNull] LuaParser.Stat_gotoContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_do([NotNull] LuaParser.Stat_doContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_do([NotNull] LuaParser.Stat_doContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_while([NotNull] LuaParser.Stat_whileContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_while([NotNull] LuaParser.Stat_whileContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_repeat([NotNull] LuaParser.Stat_repeatContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_repeat([NotNull] LuaParser.Stat_repeatContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_if([NotNull] LuaParser.Stat_ifContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_if([NotNull] LuaParser.Stat_ifContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_fornum([NotNull] LuaParser.Stat_fornumContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_fornum([NotNull] LuaParser.Stat_fornumContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_foriter([NotNull] LuaParser.Stat_foriterContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_foriter([NotNull] LuaParser.Stat_foriterContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_functiondef([NotNull] LuaParser.Stat_functiondefContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_functiondef([NotNull] LuaParser.Stat_functiondefContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_localfunctiondef([NotNull] LuaParser.Stat_localfunctiondefContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_localfunctiondef([NotNull] LuaParser.Stat_localfunctiondefContext context)
        {
            DefaultExit(context);
        }

        public void EnterStat_localassignment([NotNull] LuaParser.Stat_localassignmentContext context)
        {
            DefaultEnter(context);
        }

        public void ExitStat_localassignment([NotNull] LuaParser.Stat_localassignmentContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_nil([NotNull] LuaParser.Exp_nilContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_nil([NotNull] LuaParser.Exp_nilContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_bool([NotNull] LuaParser.Exp_boolContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_bool([NotNull] LuaParser.Exp_boolContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_number([NotNull] LuaParser.Exp_numberContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_number([NotNull] LuaParser.Exp_numberContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_string([NotNull] LuaParser.Exp_stringContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_string([NotNull] LuaParser.Exp_stringContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_params([NotNull] LuaParser.Exp_paramsContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_params([NotNull] LuaParser.Exp_paramsContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_functiondef([NotNull] LuaParser.Exp_functiondefContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_functiondef([NotNull] LuaParser.Exp_functiondefContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_prefixexp([NotNull] LuaParser.Exp_prefixexpContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_prefixexp([NotNull] LuaParser.Exp_prefixexpContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_tableconstructor([NotNull] LuaParser.Exp_tableconstructorContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_tableconstructor([NotNull] LuaParser.Exp_tableconstructorContext context)
        {
            DefaultExit(context);
        }

        public void EnterExp_unary([NotNull] LuaParser.Exp_unaryContext context)
        {
            DefaultEnter(context);
        }

        public void ExitExp_unary([NotNull] LuaParser.Exp_unaryContext context)
        {
            DefaultExit(context);
        }

        public void EnterBinaryop([NotNull] LuaParser.BinaryopContext context)
        {
            DefaultEnter(context);
        }

        public void ExitBinaryop([NotNull] LuaParser.BinaryopContext context)
        {
            DefaultExit(context);
        }
    }
}
