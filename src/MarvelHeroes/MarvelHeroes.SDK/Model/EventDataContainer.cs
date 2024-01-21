using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MarvelHeroes.SDK.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EventDataContainer {
    /// <summary>
    /// Gets or Sets Offset
    /// </summary>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public List<ModelEvent> Results { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventDataContainer {\n");
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Results: ").Append(Results).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
