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
  public class CreatorList {
    /// <summary>
    /// Gets or Sets Available
    /// </summary>
    [DataMember(Name="available", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "available")]
    public int? Available { get; set; }

    /// <summary>
    /// Gets or Sets Returned
    /// </summary>
    [DataMember(Name="returned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returned")]
    public int? Returned { get; set; }

    /// <summary>
    /// The path to the full list of creators in this collection.
    /// </summary>
    /// <value>The path to the full list of creators in this collection.</value>
    [DataMember(Name="collectionURI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectionURI")]
    public string CollectionURI { get; set; }

    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<CreatorSummary> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreatorList {\n");
      sb.Append("  Available: ").Append(Available).Append("\n");
      sb.Append("  Returned: ").Append(Returned).Append("\n");
      sb.Append("  CollectionURI: ").Append(CollectionURI).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
