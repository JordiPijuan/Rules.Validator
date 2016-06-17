namespace Schisted.RulesValidator.Core.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Entities;
    using Rules;

    public class TestObjectRulesValidator : IRulesValidator<TestObject, ValidateRuleResult>
    {

        public TestObjectRulesValidator()
        {
            RulesCollection = new List<IRule<TestObject, ValidateRuleResult>>()
            {
                Activator.CreateInstance<TestObjectNullRule>(),
                Activator.CreateInstance<TestObjectEmptyRule>(),
                Activator.CreateInstance<TestObjectRangeRule>()
            };

            //RulesCollection = Activator.CreateInstance<List<IRule<TestObject>>>();
            //RulesCollection.Add(Activator.CreateInstance<TestObjectNullRule>());
            //RulesCollection.Add(Activator.CreateInstance<TestObjectEmptyRule>());
            //RulesCollection.Add(Activator.CreateInstance<TestObjectRangeRule>());

            ResultCollection = Activator.CreateInstance<List<ValidateRuleResult>>();
        }

        public void Validate(TestObject test)
        {
            RulesCollection
                .ToList()
                .ForEach(rule => 
                {
                    rule.IsValid(test);

                    ResultCollection.Add(rule.Result);
                });
        }

        public IList<IRule<TestObject, ValidateRuleResult>> RulesCollection { get; set; }
        public IList<ValidateRuleResult> ResultCollection { get; set; }

    }

}
