using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Arkivujo.Alfresco.Core.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ChildAssociation {
    /// <summary>
    /// Gets or Sets ChildId
    /// </summary>
    [DataMember(Name="childId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childId")]
    public string ChildId { get; set; }

    /// <summary>
    /// Gets or Sets AssocType
    /// </summary>
    [DataMember(Name="assocType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assocType")]
    public string AssocType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChildAssociation {\n");
      sb.Append("  ChildId: ").Append(ChildId).Append("\n");
      sb.Append("  AssocType: ").Append(AssocType).Append("\n");
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
