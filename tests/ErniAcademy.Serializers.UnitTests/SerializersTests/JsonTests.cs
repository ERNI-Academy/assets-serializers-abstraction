using EA.Serializers.Contracts;

namespace EA.Serializers.UnitTests.SerializersTests;

public class JsonTests : BaseTests
{
    protected override string ContentType => "application/json";

    protected override ISerializer BuildSut() => new EA.Serializers.Json.JsonSerializer();
}
