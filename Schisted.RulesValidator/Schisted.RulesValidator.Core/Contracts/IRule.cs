namespace Schisted.RulesValidator.Core.Contracts
{

    public interface IRule<TSource, TResult> 
        where TSource : class
        where TResult : class
    {

        bool IsValid(TSource entity);
        TResult Result { get; set; }

    }

}
