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
  public class Series {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The canonical title of the series.
    /// </summary>
    /// <value>The canonical title of the series.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// A description of the series.
    /// </summary>
    /// <value>A description of the series.</value>
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
    /// Gets or Sets StartYear
    /// </summary>
    [DataMember(Name="startYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startYear")]
    public int? StartYear { get; set; }

    /// <summary>
    /// Gets or Sets EndYear
    /// </summary>
    [DataMember(Name="endYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endYear")]
    public int? EndYear { get; set; }

    /// <summary>
    /// The age-appropriateness rating for the series.
    /// </summary>
    /// <value>The age-appropriateness rating for the series.</value>
    [DataMember(Name="rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rating")]
    public string Rating { get; set; }

    /// <summary>
    /// Gets or Sets Modified
    /// </summary>
    [DataMember(Name="modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modified")]
    public DateTime? Modified { get; set; }

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
    /// Gets or Sets Events
    /// </summary>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public EventList Events { get; set; }

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
    public SeriesSummary Next { get; set; }

    /// <summary>
    /// Gets or Sets Previous
    /// </summary>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public SeriesSummary Previous { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Series {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ResourceURI: ").Append(ResourceURI).Append("\n");
      sb.Append("  Urls: ").Append(Urls).Append("\n");
      sb.Append("  StartYear: ").Append(StartYear).Append("\n");
      sb.Append("  EndYear: ").Append(EndYear).Append("\n");
      sb.Append("  Rating: ").Append(Rating).Append("\n");
      sb.Append("  Modified: ").Append(Modified).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Comics: ").Append(Comics).Append("\n");
      sb.Append("  Stories: ").Append(Stories).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
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
