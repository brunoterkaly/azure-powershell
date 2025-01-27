namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input for remove disk(s) operation.</summary>
    public partial class RemoveDisksInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RemoveDisksInputProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputInternal.ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputPropertiesInternal)Property).ProviderSpecificDetail = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputProperties _property;

        /// <summary>Remove disk input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RemoveDisksInputProperties()); set => this._property = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputPropertiesInternal)Property).ProviderSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputPropertiesInternal)Property).ProviderSpecificDetailInstanceType = value ?? null; }

        /// <summary>Creates an new <see cref="RemoveDisksInput" /> instance.</summary>
        public RemoveDisksInput()
        {

        }
    }
    /// Input for remove disk(s) operation.
    public partial interface IRemoveDisksInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }

    }
    /// Input for remove disk(s) operation.
    internal partial interface IRemoveDisksInputInternal

    {
        /// <summary>Remove disk input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksInputProperties Property { get; set; }
        /// <summary>
        /// The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider,
        /// it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }

    }
}