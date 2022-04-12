using ErniAcademy.Serializers.Contracts;

namespace ErniAcademy.Serializers.UnitTests.SerializersTests;

public class NewtonsoftJsonTests : BaseTests
{
    protected override string ContentType => "application/json";

    protected override ISerializer BuildSut() => new ErniAcademy.Serializers.NewtonsoftJson.JsonSerializer();
}
