// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>ExtendedLocation details data.</summary>
    public partial class A2AFabricSpecificLocationDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="A2AFabricSpecificLocationDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal A2AFabricSpecificLocationDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_initialPrimaryExtendedLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("initialPrimaryExtendedLocation"), out var __jsonInitialPrimaryExtendedLocation) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocation.FromJson(__jsonInitialPrimaryExtendedLocation) : InitialPrimaryExtendedLocation;}
            {_initialRecoveryExtendedLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("initialRecoveryExtendedLocation"), out var __jsonInitialRecoveryExtendedLocation) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocation.FromJson(__jsonInitialRecoveryExtendedLocation) : InitialRecoveryExtendedLocation;}
            {_primaryExtendedLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("primaryExtendedLocation"), out var __jsonPrimaryExtendedLocation) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocation.FromJson(__jsonPrimaryExtendedLocation) : PrimaryExtendedLocation;}
            {_recoveryExtendedLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("recoveryExtendedLocation"), out var __jsonRecoveryExtendedLocation) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocation.FromJson(__jsonRecoveryExtendedLocation) : RecoveryExtendedLocation;}
            {_initialPrimaryZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialPrimaryZone"), out var __jsonInitialPrimaryZone) ? (string)__jsonInitialPrimaryZone : (string)InitialPrimaryZone;}
            {_initialRecoveryZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialRecoveryZone"), out var __jsonInitialRecoveryZone) ? (string)__jsonInitialRecoveryZone : (string)InitialRecoveryZone;}
            {_initialPrimaryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialPrimaryFabricLocation"), out var __jsonInitialPrimaryFabricLocation) ? (string)__jsonInitialPrimaryFabricLocation : (string)InitialPrimaryFabricLocation;}
            {_initialRecoveryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialRecoveryFabricLocation"), out var __jsonInitialRecoveryFabricLocation) ? (string)__jsonInitialRecoveryFabricLocation : (string)InitialRecoveryFabricLocation;}
            {_primaryZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("primaryZone"), out var __jsonPrimaryZone) ? (string)__jsonPrimaryZone : (string)PrimaryZone;}
            {_recoveryZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryZone"), out var __jsonRecoveryZone) ? (string)__jsonRecoveryZone : (string)RecoveryZone;}
            {_primaryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("primaryFabricLocation"), out var __jsonPrimaryFabricLocation) ? (string)__jsonPrimaryFabricLocation : (string)PrimaryFabricLocation;}
            {_recoveryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryFabricLocation"), out var __jsonRecoveryFabricLocation) ? (string)__jsonRecoveryFabricLocation : (string)RecoveryFabricLocation;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new A2AFabricSpecificLocationDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="A2AFabricSpecificLocationDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="A2AFabricSpecificLocationDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._initialPrimaryExtendedLocation ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._initialPrimaryExtendedLocation.ToJson(null,serializationMode) : null, "initialPrimaryExtendedLocation" ,container.Add );
            AddIf( null != this._initialRecoveryExtendedLocation ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._initialRecoveryExtendedLocation.ToJson(null,serializationMode) : null, "initialRecoveryExtendedLocation" ,container.Add );
            AddIf( null != this._primaryExtendedLocation ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._primaryExtendedLocation.ToJson(null,serializationMode) : null, "primaryExtendedLocation" ,container.Add );
            AddIf( null != this._recoveryExtendedLocation ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._recoveryExtendedLocation.ToJson(null,serializationMode) : null, "recoveryExtendedLocation" ,container.Add );
            AddIf( null != (((object)this._initialPrimaryZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialPrimaryZone.ToString()) : null, "initialPrimaryZone" ,container.Add );
            AddIf( null != (((object)this._initialRecoveryZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialRecoveryZone.ToString()) : null, "initialRecoveryZone" ,container.Add );
            AddIf( null != (((object)this._initialPrimaryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialPrimaryFabricLocation.ToString()) : null, "initialPrimaryFabricLocation" ,container.Add );
            AddIf( null != (((object)this._initialRecoveryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialRecoveryFabricLocation.ToString()) : null, "initialRecoveryFabricLocation" ,container.Add );
            AddIf( null != (((object)this._primaryZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._primaryZone.ToString()) : null, "primaryZone" ,container.Add );
            AddIf( null != (((object)this._recoveryZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryZone.ToString()) : null, "recoveryZone" ,container.Add );
            AddIf( null != (((object)this._primaryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._primaryFabricLocation.ToString()) : null, "primaryFabricLocation" ,container.Add );
            AddIf( null != (((object)this._recoveryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryFabricLocation.ToString()) : null, "recoveryFabricLocation" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}