using EA.Serializers.Contracts;

namespace EA.Serializers.UnitTests.SerializersTests;

public class MessagePackTests : BaseTests
{
    protected override string ContentType => "application/x-net-messagepack";

    protected override ISerializer BuildSut() => new EA.Serializers.MessagePack.MessagePackSerializer();
}
