using EntityGraphQL.Grammer;

namespace EntityGraphQL.Compiler.Util
{
    internal class BaseIdentityFinder : EntityGraphQLBaseVisitor<string>
    {
        public override string VisitIdentity(EntityGraphQLParser.IdentityContext context)
        {
            return context.GetText();
        }

        public override string VisitGqlcall(EntityGraphQLParser.GqlcallContext context)
        {
            return context.method.GetText();
        }
    }
}