namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Vcores capability</summary>
    public partial class VcoreCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapabilityInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapabilityInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapabilityInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for SupportedIop</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapabilityInternal.SupportedIop { get => this._supportedIop; set { {_supportedIop = value;} } }

        /// <summary>Internal Acessors for SupportedMemoryPerVcoreMb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapabilityInternal.SupportedMemoryPerVcoreMb { get => this._supportedMemoryPerVcoreMb; set { {_supportedMemoryPerVcoreMb = value;} } }

        /// <summary>Internal Acessors for VCore</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapabilityInternal.VCore { get => this._vCore; set { {_vCore = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>vCore name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="SupportedIop" /> property.</summary>
        private long? _supportedIop;

        /// <summary>supported IOPS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public long? SupportedIop { get => this._supportedIop; }

        /// <summary>Backing field for <see cref="SupportedMemoryPerVcoreMb" /> property.</summary>
        private long? _supportedMemoryPerVcoreMb;

        /// <summary>supported memory per vCore in MB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public long? SupportedMemoryPerVcoreMb { get => this._supportedMemoryPerVcoreMb; }

        /// <summary>Backing field for <see cref="VCore" /> property.</summary>
        private long? _vCore;

        /// <summary>supported vCores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public long? VCore { get => this._vCore; }

        /// <summary>Creates an new <see cref="VcoreCapability" /> instance.</summary>
        public VcoreCapability()
        {

        }
    }
    /// Vcores capability
    public partial interface IVcoreCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>vCore name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"vCore name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>supported IOPS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"supported IOPS",
        SerializedName = @"supportedIops",
        PossibleTypes = new [] { typeof(long) })]
        long? SupportedIop { get;  }
        /// <summary>supported memory per vCore in MB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"supported memory per vCore in MB",
        SerializedName = @"supportedMemoryPerVcoreMB",
        PossibleTypes = new [] { typeof(long) })]
        long? SupportedMemoryPerVcoreMb { get;  }
        /// <summary>supported vCores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"supported vCores",
        SerializedName = @"vCores",
        PossibleTypes = new [] { typeof(long) })]
        long? VCore { get;  }

    }
    /// Vcores capability
    internal partial interface IVcoreCapabilityInternal

    {
        /// <summary>vCore name</summary>
        string Name { get; set; }
        /// <summary>The status</summary>
        string Status { get; set; }
        /// <summary>supported IOPS</summary>
        long? SupportedIop { get; set; }
        /// <summary>supported memory per vCore in MB</summary>
        long? SupportedMemoryPerVcoreMb { get; set; }
        /// <summary>supported vCores</summary>
        long? VCore { get; set; }

    }
}