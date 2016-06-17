namespace Schisted.RulesValidator.Core.Contracts
{
    using System.Collections.Generic;

    public interface IRulesValidator<TSource, TResult> 
        where TSource : class
        where TResult : class
    {

        IList<IRule<TSource, TResult>> RulesCollection { get; set; }
        IList<TResult> ResultCollection { get; set; }
        void Validate(TSource entity);

    }

}
