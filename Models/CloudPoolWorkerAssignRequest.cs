using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to assign cloud workers to cloud pool
  /// </summary>
  [DataContract]
  public class CloudPoolWorkerAssignRequest {
    /// <summary>
    /// List of worker UUIds to assign to the cloud pool
    /// </summary>
    /// <value>List of worker UUIds to assign to the cloud pool</value>
    [DataMember(Name="workerUuids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerUuids")]
    public List<string> WorkerUuids { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPoolWorkerAssignRequest {\n");
      sb.Append("  WorkerUuids: ").Append(WorkerUuids).Append("\n");
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
