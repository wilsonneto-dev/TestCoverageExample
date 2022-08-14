using FluentAssertions;

namespace Lib.UnitTests;
public class WorkspaceTests
{
    [Fact]
    public void Instantiate()
    {
        var expectedName = "Workspace Name";

        var workspace = new Workspace(expectedName);

        workspace.Should().NotBeNull();
        workspace.Name.Should().Be(expectedName);
    }
}
