using Xunit;

namespace RFS.Tests
{
    public class ViewAViewModelFixture
    {
        private readonly Mock<IMessageService> _messageServiceMock;
        private readonly Mock<IRegionManager> _regionManagerMock;

        private const string DefaultMessage = "Kiss My Ass";

        public ViewAViewModelFixture() {
            _messageServiceMock = new Mock<IMessageService>();
            _messageServiceMock.Setup(x => x.GetMessage()).Returns(DefaultMessage);

            _regionManagerMock = new Mock<IRegionManager>();

        }
        [Fact]
        public void MessagePropertyValueUpdated()
        {
            var vm = new ViewAViewModel(_regionManagerMock.Object, _messageServiceMock.Object);
            _messageServiceMock.Verify(x => x.GetMessage(), Times.Once);
            Assert.Equal(DefaultMessage, vm.Message);
        }

        [Fact]
        public void MessageRaisePropertyChangeCalled() {
            var vm = new ViewAViewModel(_regionManagerMock.Object, _messageServiceMock.Object);
            Assert.PropertyChanged(vm, nameof(vm.Message), () => vm.Message = "Changed");
        }
    }
}
