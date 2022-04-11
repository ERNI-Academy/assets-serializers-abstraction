using EA.Serializers.Contracts;
using Newtonsoft.Json;

namespace EA.Serializers.NewtonsoftJson;

public class JsonSerializer : ISerializer
{
    private readonly Newtonsoft.Json.JsonSerializer _jsonSerializer;
    private readonly JsonSerializerSettings _jsonSerializerSettings;

    public JsonSerializer(JsonSerializerSettings? jsonSerializerSettings = null)
    {
        _jsonSerializerSettings = jsonSerializerSettings ?? new JsonSerializerSettings();
        _jsonSerializer = Newtonsoft.Json.JsonSerializer.Create(_jsonSerializerSettings);
    }

    public string ContentType => "application/json";

    public void SerializeToStream<TItem>(TItem item, Stream stream)
    {
        var writer = new StreamWriter(stream);
        var jsonWriter = new JsonTextWriter(writer);
        _jsonSerializer.Serialize(jsonWriter, item);
        writer.Flush();
        jsonWriter.Flush();
        stream.Position = 0;
    }

    public async Task SerializeToStreamAsync<TItem>(TItem item, Stream stream, CancellationToken cancellationToken = default)
    {
        var writer = new StreamWriter(stream);
        var jsonWriter = new JsonTextWriter(writer);
        _jsonSerializer.Serialize(jsonWriter, item);
        await writer.FlushAsync();
        await jsonWriter.FlushAsync(cancellationToken);
        stream.Position = 0;
    }

    public string SerializeToString<TItem>(TItem item) => JsonConvert.SerializeObject(item, _jsonSerializerSettings);

    public TItem DeserializeFromStream<TItem>(Stream stream)
    {
        TItem item;
        using (StreamReader reader = new StreamReader(stream))
        using (JsonTextReader jsonReader = new JsonTextReader(reader))
        {
            item = _jsonSerializer.Deserialize<TItem>(jsonReader);
        }
        return item;
    }

    public TItem DeserializeFromString<TItem>(string item) => JsonConvert.DeserializeObject<TItem>(item, _jsonSerializerSettings);

    public ValueTask<TItem> DeserializeFromStreamAsync<TItem>(Stream stream, CancellationToken cancellationToken = default)
    {
        TItem item;
        using (StreamReader reader = new StreamReader(stream))
        using (JsonTextReader jsonReader = new JsonTextReader(reader))
        {
            item = _jsonSerializer.Deserialize<TItem>(jsonReader);
        }
        return new ValueTask<TItem>(item);
    }
}
