namespace Schisted.RulesValidator.Core.Rules
{
    using System;
    using Contracts;
    using Entities;

    public class TestObjectRangeRule : IRule<TestObject, ValidateRuleResult>
    {

        public bool IsValid(TestObject test)
        {
            Result = new ValidateRuleResult()
            {
                Message = "Range OK",
                ObjectType = typeof(Enum),
                Valid = true
            };

            return Result.Valid;
        }

        public ValidateRuleResult Result { get; set; }

    }

}
