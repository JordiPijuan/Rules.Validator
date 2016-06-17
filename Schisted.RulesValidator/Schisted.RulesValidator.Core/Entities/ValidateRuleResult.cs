namespace Schisted.RulesValidator.Core.Entities
{
    using System;

    public class ValidateRuleResult
    {

        public Type ObjectType { get; set; }
        public string Message { get; set; }
        public bool Valid { get; set; }

    }

}
