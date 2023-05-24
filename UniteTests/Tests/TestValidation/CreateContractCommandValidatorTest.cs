using Business.CQRS.ContractUnit.Commands.CreateContract;
using FluentValidation.Results;
using Assert = NUnit.Framework.Assert;

namespace UnitTests.Tests.TestValidation
{
    public class CreateContractCommandValidatorTest
    {
        private readonly CreateContractCommandValidator _validator;

        public CreateContractCommandValidatorTest() => _validator = new CreateContractCommandValidator();

        [Fact]
        public void CreateContractCommandValidator_Test()
        {
            //Arrange
            CreateContractCommand createContractCommand = GetCreateContractCommand();

            //Act
            ValidationResult result = _validator.Validate(createContractCommand);

            //Asert
            Assert.IsTrue(!result.Errors.Any());
        }

        private CreateContractCommand GetCreateContractCommand()
        {
            var createNewContractCommand = new CreateContractCommand("SomeTitle", "SomeDescription", "20000");
            return createNewContractCommand;
        }
    }
}
