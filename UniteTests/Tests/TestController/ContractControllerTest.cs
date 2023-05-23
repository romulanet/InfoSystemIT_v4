using Domain.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Persistence.Repositories;
using Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests.Tests.TestController
{
    public class ContractControllerTest
    {
        private readonly Mock<ISender> _mockRepo;
        private readonly ContractController _controller;
        private readonly CancellationToken _cancellationToken;

        public ContractControllerTest()
        {
            _mockRepo = new Mock<ISender>();
            _controller = new ContractController(_mockRepo.Object);
            _cancellationToken = new CancellationToken();
        }

        [Fact]
        public void ActionExecutes_ReturnsView()
        {
            var result = _controller.Get(_cancellationToken);
            Assert.IsType<OkResult>(result);
        }

    }
}
