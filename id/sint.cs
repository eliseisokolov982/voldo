YourType obj = new YourType();

// Serialize
string json = JsonSerializer.Serialize(obj, AppJsonSerializerContext.Default.YourType);

// Deserialize
YourType deserializedObj = JsonSerializer.Deserialize<YourType>(json, AppJsonSerializerContext.Default.YourType);
