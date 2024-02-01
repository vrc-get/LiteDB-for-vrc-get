using System;

namespace LiteDB
{
    internal static class Unsupported
    {
        public static Exception AesRemoved => Create("AES is removed");
        public static Exception Query => Create("SQL support is removed");
        public static Exception Shared => Create("Shared Connection is removed");
        public static Exception WhereQuery => Create("Where querty support is removed");
        public static Exception EntityMapper => Create("EntityMapper is removed");

        // EXPRESSION_PARSER_ONLY_FOR_INDEX
        public static Exception ParametersInExpression => Create("Parameters in expression");
        public static Exception FunctionsInExpression => Create("Functions in expression");
        public static Exception SourceInExpression => Create("'*' in expression");
        public static Exception OperatorsInExpression => Create("Operators in expression");

        private static Exception Create(string message) => new LiteException(LiteException.UNSUPPORTED, message);
    }
}
