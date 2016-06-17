namespace Schisted.RulesValidator.Core.Rules
{
    using System;
    using Contracts;
    using Entities;

    public class TestObjectEmptyRule : IRule<TestObject, ValidateRuleResult>
    {
        public bool IsValid(TestObject test)
        {
            Result = new ValidateRuleResult()
            {
                Message = "Not is empty",
                ObjectType = typeof(Enum),
                Valid = true
            };

            return Result.Valid;
        }

        public ValidateRuleResult Result { get; set; }

    }

}
