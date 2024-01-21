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
  public class ModelEvent {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The title of the event.
    /// </summary>
    /// <value>The title of the event.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// A description of the event.
    /// </summary>
    /// <value>A description of the event.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The canonical URL identifier for this resource.
    /// </summary>
    /// <value>The canonical URL identifier for this resource.</value>
    [DataMember(Name="resourceURI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceURI")]
    public string ResourceURI { get; set; }

    /// <summary>
    /// Gets or Sets Urls
    /// </summary>
    [DataMember(Name="urls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urls")]
    public List<Url> Urls  { get; set; }

    /// <summary>
    /// Gets or Sets Modified
    /// </summary>
    [DataMember(Name="modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modified")]
    public DateTime? Modified { get; set; }

    /// <summary>
    /// Gets or Sets Start
    /// </summary>
    [DataMember(Name="start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start")]
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or Sets End
    /// </summary>
    [DataMember(Name="end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end")]
    public DateTime? End { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public Image Thumbnail { get; set; }

    /// <summary>
    /// Gets or Sets Comics
    /// </summary>
    [DataMember(Name="comics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comics")]
    public ComicList Comics { get; set; }

    /// <summary>
    /// Gets or Sets Stories
    /// </summary>
    [DataMember(Name="stories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stories")]
    public StoryList Stories { get; set; }

    /// <summary>
    /// Gets or Sets Series
    /// </summary>
    [DataMember(Name="series", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "series")]
    public SeriesList Series { get; set; }

    /// <summary>
    /// Gets or Sets Characters
    /// </summary>
    [DataMember(Name="characters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characters")]
    public CharacterList Characters { get; set; }

    /// <summary>
    /// Gets or Sets Creators
    /// </summary>
    [DataMember(Name="creators", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creators")]
    public CreatorList Creators { get; set; }

    /// <summary>
    /// Gets or Sets Next
    /// </summary>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public EventSummary Next { get; set; }

    /// <summary>
    /// Gets or Sets Previous
    /// </summary>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public EventSummary Previous { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelEvent {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ResourceURI: ").Append(ResourceURI).Append("\n");
      sb.Append("  Urls: ").Append(Urls).Append("\n");
      sb.Append("  Modified: ").Append(Modified).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  End: ").Append(End).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Comics: ").Append(Comics).Append("\n");
      sb.Append("  Stories: ").Append(Stories).Append("\n");
      sb.Append("  Series: ").Append(Series).Append("\n");
      sb.Append("  Characters: ").Append(Characters).Append("\n");
      sb.Append("  Creators: ").Append(Creators).Append("\n");
      sb.Append("  Next: ").Append(Next).Append("\n");
      sb.Append("  Previous: ").Append(Previous).Append("\n");
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
