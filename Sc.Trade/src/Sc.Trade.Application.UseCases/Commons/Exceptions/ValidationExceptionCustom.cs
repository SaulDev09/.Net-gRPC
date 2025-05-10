using FluentValidation.Results;

namespace Sc.Trade.Application.UseCases.Commons.Exceptions
{
    public class ValidationExceptionCustom : Exception
    {
        public List<string> Errors { get; set; }

        public ValidationExceptionCustom() : base("Validation exception")
        {
            Errors = [];
        }

        public ValidationExceptionCustom(IEnumerable<ValidationFailure> failures) : this()
        {
            var errors = failures
                .Select(x => x.ErrorMessage)
                .ToList();

            Errors = errors;
        }



    }
}
