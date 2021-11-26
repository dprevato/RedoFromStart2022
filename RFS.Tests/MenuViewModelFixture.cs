using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using JetBrains.Annotations;
using Moq;
using RedoFromStart.ViewModels;
using Xunit;

namespace RFS.Tests
{
    public class MenuViewModelFixture
    {
        private readonly Mock<MenuViewModel>  _mockMenuViewModel;
        private readonly string _plant;

        public MenuViewModelFixture() {
            _plant = "OEB";
            _mockMenuViewModel = new Mock<MenuViewModel>();
        }

        [Fact]
        public void PlantSelectedShouldBeTrue() {
            _mockMenuViewModel.Setup(x => x.SelectedPlant).Returns(_plant);
            _mockMenuViewModel.Setup(X => X.PlantSelected).Returns(true);

            _mockMenuViewModel.Verify(x => x.PlantSelected, Times.Once);

            Assert.true(_mockMenuViewModel.Object.PlantSelected, true);
        }
    }
}
