using ErniAcademy.Serializers.Contracts;

namespace ErniAcademy.Serializers.UnitTests.SerializersTests;

public class MessagePackTests : BaseTests
{
    protected override string ContentType => "application/x-net-messagepack";

    protected override ISerializer BuildSut() => new ErniAcademy.Serializers.MessagePack.MessagePackSerializer();
}
