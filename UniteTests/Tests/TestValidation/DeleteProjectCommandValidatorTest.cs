using Business.CQRS.ContractUnit.Commands.DeleteContract;
using FluentValidation.Results;
using Assert = NUnit.Framework.Assert;

namespace UnitTests.Tests.TestValidation
{
    public class DeleteProjectCommandValidatorTest
    {
        private readonly DeleteProjectCommandValidator _validator;

        public DeleteProjectCommandValidatorTest() => _validator = new DeleteProjectCommandValidator();

        [Fact]
        public void CreateContractCommandValidator_Test()
        {
            //Arrange
            DeleteProjectCommand createContractCommand = GetDeleteProjectCommand();

            //Act
            ValidationResult result = _validator.Validate(createContractCommand);

            //Asert
            Assert.IsTrue(!result.Errors.Any());
        }

        private DeleteProjectCommand GetDeleteProjectCommand()
        {
            var Id = Guid.NewGuid();
            var createNewContractCommand = new DeleteProjectCommand(Id);
            return createNewContractCommand;
        }
    }
}
