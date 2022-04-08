using EA.Serializers.Contracts;
using EA.Serializers.UnitTests.Models;
using FluentAssertions;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace EA.Serializers.UnitTests.SerializersTests;

public abstract class BaseTests
{
    protected ISerializer _sut;

    protected BaseTests()
    {
        _sut = BuildSut();
    }

    protected abstract string ContentType { get; }
    protected abstract ISerializer BuildSut();

    [Fact]
    public void ContentType_Tests()
    {
        //Act
        var actual = _sut.ContentType;

        //Assert
        actual.Should().Be(ContentType);
    }

    [Fact]
    public void Given_SerializeToStream_Should_Serialize()
    {
        //Arrange
        var model = DummyModel.Build();

        //Act
        using Stream stream = new MemoryStream();
        _sut.SerializeToStream(model, stream);

        //Assert
        var actual = _sut.DeserializeFromStream<DummyModel>(stream);
        actual.Should().BeEquivalentTo(model);
    }

    [Fact]
    public async Task Given_SerializeToStreamAsync_Should_Serialize()
    {
        //Arrange
        var model = DummyModel.Build();

        //Act
        await using Stream stream = new MemoryStream();
        await _sut.SerializeToStreamAsync(model, stream);

        //Assert
        var actual = await _sut.DeserializeFromStreamAsync<DummyModel>(stream);
        actual.Should().BeEquivalentTo(model);
    }

    [Fact]
    public void Given_SerializeToString_Should_Serialize()
    {
        //Arrange
        var model = DummyModel.Build();

        //Act
        var str = _sut.SerializeToString(model);

        //Assert
        var actual = _sut.DeserializeFromString<DummyModel>(str);
        actual.Should().BeEquivalentTo(model);
    }
}
