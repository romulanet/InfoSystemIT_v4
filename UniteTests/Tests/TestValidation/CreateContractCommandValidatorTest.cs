using Business.CQRS.ContractUnit.Commands.CreateContract;
using FluentValidation.Results;
using NUnit.Framework;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using Assert = NUnit.Framework.Assert;

namespace UnitTests.Tests.TestValidation
{
    public class CreateContractCommandValidatorTest
    {
        private readonly CreateContractCommandValidator _validator;

        public CreateContractCommandValidatorTest() => _validator = new CreateContractCommandValidator();

        [Test]
        public void CreateContractCommandValidator_Test()
        {
            //Arrange
            CreateContractCommand createContractCommand = GetCreateContractCommand();

            CreateContractCommandValidator validator = new CreateContractCommandValidator();
            //Act
            ValidationResult result = validator.Validate(createContractCommand);

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
