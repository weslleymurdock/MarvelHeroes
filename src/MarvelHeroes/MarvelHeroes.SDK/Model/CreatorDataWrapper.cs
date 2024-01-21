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
  public class CreatorDataWrapper {
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public int? Code { get; set; }

    /// <summary>
    /// A string description of the call status.
    /// </summary>
    /// <value>A string description of the call status.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The copyright notice for the returned result.
    /// </summary>
    /// <value>The copyright notice for the returned result.</value>
    [DataMember(Name="copyright", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copyright")]
    public string Copyright { get; set; }

    /// <summary>
    /// The attribution notice for this result.  Please display either this notice or the contents of the attributionHTML field on all screens which contain data from the Marvel Comics API.
    /// </summary>
    /// <value>The attribution notice for this result.  Please display either this notice or the contents of the attributionHTML field on all screens which contain data from the Marvel Comics API.</value>
    [DataMember(Name="attributionText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributionText")]
    public string AttributionText { get; set; }

    /// <summary>
    /// An HTML representation of the attribution notice for this result.  Please display either this notice or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.
    /// </summary>
    /// <value>An HTML representation of the attribution notice for this result.  Please display either this notice or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.</value>
    [DataMember(Name="attributionHTML", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributionHTML")]
    public string AttributionHTML { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public CreatorDataContainer Data { get; set; }

    /// <summary>
    /// A digest value of the content returned by the call.
    /// </summary>
    /// <value>A digest value of the content returned by the call.</value>
    [DataMember(Name="etag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "etag")]
    public string Etag { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreatorDataWrapper {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Copyright: ").Append(Copyright).Append("\n");
      sb.Append("  AttributionText: ").Append(AttributionText).Append("\n");
      sb.Append("  AttributionHTML: ").Append(AttributionHTML).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Etag: ").Append(Etag).Append("\n");
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
