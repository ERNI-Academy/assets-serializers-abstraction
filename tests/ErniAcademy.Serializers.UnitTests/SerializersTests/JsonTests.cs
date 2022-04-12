using ErniAcademy.Serializers.Contracts;

namespace ErniAcademy.Serializers.UnitTests.SerializersTests;

public class JsonTests : BaseTests
{
    protected override string ContentType => "application/json";

    protected override ISerializer BuildSut() => new ErniAcademy.Serializers.Json.JsonSerializer();
}
