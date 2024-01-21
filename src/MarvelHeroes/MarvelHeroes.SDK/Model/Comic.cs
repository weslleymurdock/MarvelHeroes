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
  public class Comic {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets DigitalId
    /// </summary>
    [DataMember(Name="digitalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "digitalId")]
    public int? DigitalId { get; set; }

    /// <summary>
    /// The canonical title of the comic.
    /// </summary>
    /// <value>The canonical title of the comic.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets IssueNumber
    /// </summary>
    [DataMember(Name="issueNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueNumber")]
    public double? IssueNumber { get; set; }

    /// <summary>
    /// If the issue is a variant (e.g. an alternate cover, second printing, or director’s cut), a text description of the variant.
    /// </summary>
    /// <value>If the issue is a variant (e.g. an alternate cover, second printing, or director’s cut), a text description of the variant.</value>
    [DataMember(Name="variantDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variantDescription")]
    public string VariantDescription { get; set; }

    /// <summary>
    /// The preferred description of the comic.
    /// </summary>
    /// <value>The preferred description of the comic.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Modified
    /// </summary>
    [DataMember(Name="modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modified")]
    public DateTime? Modified { get; set; }

    /// <summary>
    /// The ISBN for the comic (generally only populated for collection formats).
    /// </summary>
    /// <value>The ISBN for the comic (generally only populated for collection formats).</value>
    [DataMember(Name="isbn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isbn")]
    public string Isbn { get; set; }

    /// <summary>
    /// The UPC barcode number for the comic (generally only populated for periodical formats).
    /// </summary>
    /// <value>The UPC barcode number for the comic (generally only populated for periodical formats).</value>
    [DataMember(Name="upc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upc")]
    public string Upc { get; set; }

    /// <summary>
    /// The Diamond code for the comic.
    /// </summary>
    /// <value>The Diamond code for the comic.</value>
    [DataMember(Name="diamondCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diamondCode")]
    public string DiamondCode { get; set; }

    /// <summary>
    /// The EAN barcode for the comic.
    /// </summary>
    /// <value>The EAN barcode for the comic.</value>
    [DataMember(Name="ean", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ean")]
    public string Ean { get; set; }

    /// <summary>
    /// The ISSN barcode for the comic.
    /// </summary>
    /// <value>The ISSN barcode for the comic.</value>
    [DataMember(Name="issn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issn")]
    public string Issn { get; set; }

    /// <summary>
    /// The publication format of the comic e.g. comic, hardcover, trade paperback.
    /// </summary>
    /// <value>The publication format of the comic e.g. comic, hardcover, trade paperback.</value>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public string Format { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [DataMember(Name="pageCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageCount")]
    public int? PageCount { get; set; }

    /// <summary>
    /// Gets or Sets TextObjects
    /// </summary>
    [DataMember(Name="textObjects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textObjects")]
    public List<TextObject> TextObjects { get; set; }

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
    /// Gets or Sets Series
    /// </summary>
    [DataMember(Name="series", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "series")]
    public SeriesSummary Series { get; set; }

    /// <summary>
    /// Gets or Sets Variants
    /// </summary>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variants")]
    public List<ComicSummary> Variants { get; set; }

    /// <summary>
    /// Gets or Sets Collections
    /// </summary>
    [DataMember(Name="collections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collections")]
    public List<ComicSummary> Collections { get; set; }

    /// <summary>
    /// Gets or Sets CollectedIssues
    /// </summary>
    [DataMember(Name="collectedIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectedIssues")]
    public List<ComicSummary> CollectedIssues { get; set; }

    /// <summary>
    /// Gets or Sets Dates
    /// </summary>
    [DataMember(Name="dates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dates")]
    public List<ComicDate> Dates { get; set; }

    /// <summary>
    /// Gets or Sets Prices
    /// </summary>
    [DataMember(Name="prices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prices")]
    public List<ComicPrice> Prices { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public Image Thumbnail { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<Image> Images { get; set; }

    /// <summary>
    /// Gets or Sets Creators
    /// </summary>
    [DataMember(Name="creators", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creators")]
    public CreatorList Creators { get; set; }

    /// <summary>
    /// Gets or Sets Characters
    /// </summary>
    [DataMember(Name="characters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characters")]
    public CharacterList Characters { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Comic {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DigitalId: ").Append(DigitalId).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  IssueNumber: ").Append(IssueNumber).Append("\n");
      sb.Append("  VariantDescription: ").Append(VariantDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Modified: ").Append(Modified).Append("\n");
      sb.Append("  Isbn: ").Append(Isbn).Append("\n");
      sb.Append("  Upc: ").Append(Upc).Append("\n");
      sb.Append("  DiamondCode: ").Append(DiamondCode).Append("\n");
      sb.Append("  Ean: ").Append(Ean).Append("\n");
      sb.Append("  Issn: ").Append(Issn).Append("\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  TextObjects: ").Append(TextObjects).Append("\n");
      sb.Append("  ResourceURI: ").Append(ResourceURI).Append("\n");
      sb.Append("  Urls: ").Append(Urls).Append("\n");
      sb.Append("  Series: ").Append(Series).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
      sb.Append("  Collections: ").Append(Collections).Append("\n");
      sb.Append("  CollectedIssues: ").Append(CollectedIssues).Append("\n");
      sb.Append("  Dates: ").Append(Dates).Append("\n");
      sb.Append("  Prices: ").Append(Prices).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  Creators: ").Append(Creators).Append("\n");
      sb.Append("  Characters: ").Append(Characters).Append("\n");
      sb.Append("  Stories: ").Append(Stories).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
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
