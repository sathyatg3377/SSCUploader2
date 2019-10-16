using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to disable plugin
  /// </summary>
  [DataContract]
  public class PluginDisableRequest {
    /// <summary>
    /// List containing single plugin ID to disable
    /// </summary>
    /// <value>List containing single plugin ID to disable</value>
    [DataMember(Name="pluginIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginIds")]
    public List<long?> PluginIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PluginDisableRequest {\n");
      sb.Append("  PluginIds: ").Append(PluginIds).Append("\n");
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
